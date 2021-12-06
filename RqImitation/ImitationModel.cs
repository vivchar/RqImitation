using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class ImitationModel
    {

        private double lambda;
        private double beta;
        private double alpha;
        private double gamma;
        private List<double> mu1List;
        private List<double> mu2List;
        private List<List<int>> matrixQ;

        private Random random = new Random();

        private Device device;
        private ExternalStream externalStream;
        private IncommingStream incommingStream;
        private RepeatStream repeatStream;

        //RandomEnviroment?
        double currentTime = 0;
        int currentState = 0;

        public ImitationModel(double lambda, double beta, double alpha, double gamma, List<double> mu1List, List<double> mu2List, List<List<int>> matrixQ)
        {


            this.lambda = lambda;
            this.beta = beta;
            this.alpha = alpha;
            this.gamma = gamma;
            this.mu1List = mu1List;
            this.mu2List = mu2List;
            this.matrixQ = matrixQ;

            incommingStream = new IncommingStream(random, lambda);
            repeatStream = new RepeatStream(random, gamma);
            externalStream = new ExternalStream(random, alpha);
            device = new Device(random, mu1List, mu2List);
        }

        internal void start(int eventsCount)
        {
            ImmitationForm.Log("Starting...");
            ImmitationForm.Log("");
            for (int i = 1; i <= eventsCount; i++) {

                double incommingEventTime = incommingStream.getEventTime();
                ImmitationForm.Log("Incomming event time:\t\t\t\t" + incommingEventTime);

                double repeatEventTime = repeatStream.getEventTime();
                ImmitationForm.Log("Repeat event time:\t\t\t\t\t" + repeatEventTime);

                double deviceFinishEventTime = device.getEventTime();
                ImmitationForm.Log("Device finish event time:\t\t\t\t" + deviceFinishEventTime);

                double externalEventTime = device.isBusy() ? double.MaxValue : externalStream.getEventTime(currentTime);
                ImmitationForm.Log("External event time:\t\t\t\t" + externalEventTime);

                var timeList = new List<double>();
                timeList.Add(incommingEventTime);
                timeList.Add(repeatEventTime);
                timeList.Add(deviceFinishEventTime);
                timeList.Add(externalEventTime);

                currentTime = timeList.Min(); //переключаемся на ближайшее событие, это и есть текущее время

                if (currentTime == incommingEventTime) { //обрабатываем событие из входящего потока заявок
                    ImmitationForm.Log("Incomming event time!");
                    var incommingRequest = incommingStream.getRequest();
                    callDeviceWithRequest(incommingRequest);
                }

                if (currentTime == repeatEventTime) {
                    ImmitationForm.Log("Repeate event time!");
                    Request repeatRequest = repeatStream.getRequest();
                    callDeviceWithRequest(repeatRequest);
                }

                if (currentTime == deviceFinishEventTime) {
                    ImmitationForm.Log("Device finish event time!");
                    Request finishedRequest = device.removeRequest();
                    processFinishedRequest(finishedRequest);
                }

                if (currentTime == externalEventTime) {
                    ImmitationForm.Log("External event time!");
                    Request externalRequest = externalStream.getRequest();
                    callDeviceWithRequest(externalRequest);
                }

                ImmitationForm.Log(
                    "Total events count: " + i + "/" + eventsCount 
                    + " Incoming: " + incommingStream.getProcessedRequestsCount() 
                    + ", Repeat: " + repeatStream.getProcessedEventCount()
                    + ", Device: " + device.getProcessedRequestsCount()
                    + ", External: " + externalStream.getProcessedRequestsCount()
                );

                ImmitationForm.Log("");
            }
            ImmitationForm.Log("Finishing...");
        }

        private void processFinishedRequest(Request request) {
            bool willLeftSystem = random.NextDouble() < beta; //рассчитываем вероятность (1 - B), что заявка покинет систему
            if (willLeftSystem)
            {
                ImmitationForm.Log("Request left a system.");
            }
            else
            {
                ImmitationForm.Log("Request can't left a system. Moving to RS. RS contains " + repeatStream.getRequestsCount() + "(+1) requests.");
                repeatStream.addRequest(request); //помещаем заявку в ИПВ, назначаем новое время
            }
        }

        private void callDeviceWithRequest(Request request) {
            if (device.isBusy()) //проверяем занят ли девайс
            {
                ImmitationForm.Log("Device is busy. Moving to RS. RS contains " + repeatStream.getRequestsCount() + "(+1) requests.");
                repeatStream.addRequest(request); //если занят, помещаем заявку в ИПВ, назначаем новое время
            }
            else
            {
                ImmitationForm.Log("Device is free, starting process...");
                device.addRequest(request); //если свободен, передаем на обработку в прибор
            }
        }
    }
}
