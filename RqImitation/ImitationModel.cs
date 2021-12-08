using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class ImitationModel
    {
        private double beta;

        private Random random = new Random();

        private Device device;
        private ExternalStream externalStream;
        private IncommingStream incommingStream;
        private RepeatStream repeatStream;
        private RandomEnviroment randomEnviroment;

        double currentTime = 0;

        public ImitationModel(double lambda, double beta, double alpha, double gamma, List<double> mu1List, List<double> mu2List, List<List<int>> matrixQ)
        {
            this.beta = beta;

            incommingStream = new IncommingStream(random, lambda);
            repeatStream = new RepeatStream(random, gamma);
            externalStream = new ExternalStream(random, alpha);
            device = new Device(random, mu1List, mu2List);
            randomEnviroment = new RandomEnviroment(random, matrixQ);
        }

        internal void start(int eventsCount)
        {
            ImitationForm.Start();
            ImitationForm.Log("Starting...");
            ImitationForm.Log("");
            for (int i = 1; i <= eventsCount; i++) {

                double randomEnviromentEventTime = randomEnviroment.getEventTime();
                double incommingEventTime = incommingStream.getEventTime();
                double repeatEventTime = repeatStream.getEventTime();
                double deviceFinishEventTime = device.getEventTime();
                double externalEventTime = device.isBusy() ? double.MaxValue : externalStream.getEventTime(currentTime);
                
                ImitationForm.Log("Random time:\t\t" + mapToUserFriendlyTime(randomEnviromentEventTime));
                ImitationForm.Log("Incomming time:\t\t" + mapToUserFriendlyTime(incommingEventTime));
                ImitationForm.Log("Repeat time:\t\t" + mapToUserFriendlyTime(repeatEventTime));
                ImitationForm.Log("Device time:\t\t" + mapToUserFriendlyTime(deviceFinishEventTime));
                ImitationForm.Log("External time:\t\t" + mapToUserFriendlyTime(externalEventTime));

                var timeList = new List<double>(); //добавляем времена событий в список, чтобы достать наименьшее/ближайшее
                timeList.Add(incommingEventTime);
                timeList.Add(repeatEventTime);
                timeList.Add(deviceFinishEventTime);
                timeList.Add(externalEventTime);
                timeList.Add(randomEnviromentEventTime);

                currentTime = timeList.Min(); //переключаемся на ближайшее событие, это и есть текущее время

                if (currentTime == incommingEventTime) { //обрабатываем событие из входящего потока заявок
                    ImitationForm.Log("\tIncomming event time!");
                    var incommingRequest = incommingStream.getRequest();
                    callDeviceWithIncommingRequest(incommingRequest);
                }

                if (currentTime == repeatEventTime) { //обрабатываем событие из источника повторных вызовов
                    ImitationForm.Log("\tRepeate event time!");
                    Request repeatRequest = repeatStream.getRequest();
                    callDeviceWithIncommingRequest(repeatRequest);
                }

                if (currentTime == deviceFinishEventTime) { //обрабатываем событие завершения работы прибора
                    ImitationForm.Log("\tDevice finish event time!");
                    Request finishedRequest = device.removeRequest();
                    processFinishedRequest(finishedRequest);
                }

                if (currentTime == externalEventTime) { //обрабатываем событие когда прибор свободен и он обратился к внешнему источнику заявок
                    ImitationForm.Log("\tExternal event time!");
                    Request externalRequest = externalStream.getRequest();
                    callDeviceWithOutgoingRequest(externalRequest);
                }

                if (currentTime == randomEnviromentEventTime) { //обрабатываем событие смены состояния случайной среды
                    ImitationForm.Log("\tRandom enviroment event time! " + randomEnviroment.getState());
                    randomEnviroment.generateNextState();
                }

                ImitationForm.Log(
                    "Total events count:" + i + "/" + eventsCount
                    + ", Random:" + randomEnviroment.getProcessedRequestsCount()
                    + ", Incoming:" + incommingStream.getProcessedRequestsCount() 
                    + ", Repeat:" + repeatStream.getProcessedEventCount()
                    + ", Device:" + device.getProcessedRequestsCount()
                    + ", External:" + externalStream.getProcessedRequestsCount()
                );

                ImitationForm.Log("");
            }
            ImitationForm.Log("Finishing...");
            ImitationForm.Stop();
        }

        private String mapToUserFriendlyTime(double time) {
            //выводив в удобном виде для восприятия
            return time == double.MaxValue ? "ꝏ" : string.Format("{0:N3}", time);
        }

        private void processFinishedRequest(Request request) {
            bool willLeftSystem = random.NextDouble() > beta; //рассчитываем вероятность (1 - B), что заявка покинет систему
            if (willLeftSystem)
            {
                ImitationForm.Log("\t\tRequest left a system.");
            }
            else
            {
                ImitationForm.Log("\t\tRequest can't left a system. Moving to RS. RS contains " + repeatStream.getRequestsCount() + "(+1) requests.");
                repeatStream.addRequest(request); //помещаем заявку в ИПВ, назначаем новое время
            }
        }

        private void callDeviceWithOutgoingRequest(Request request) {
            callDeviceWithRequest(false, request);
        }

        private void callDeviceWithIncommingRequest(Request request) {
            callDeviceWithRequest(true, request);
        }

        private void callDeviceWithRequest(bool isIncomming, Request request) {
            if (device.isBusy()) //проверяем занят ли девайс
            {
                ImitationForm.Log("\t\tDevice is busy. Moving to RS. RS contains " + repeatStream.getRequestsCount() + "(+1) requests.");
                repeatStream.addRequest(request); //если занят, помещаем заявку в ИПВ, назначаем новое время
            }
            else
            {
                ImitationForm.Log("\t\tDevice is free, starting process...");
                device.addRequest(isIncomming, request, randomEnviroment.getState()); //если свободен, передаем на обработку в прибор, передаем текущее состояние случайной среды
            }
        }
    }
}
