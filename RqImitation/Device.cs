using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    //прибор
    internal class Device
    {
        private Request request = null;

        private ExponentialGenerator exponentialGenerator;
        private List<double> mu1List; //список мю для входящих заявок, зависит от числа состояний случайной среды S
        private List<double> mu2List; //список мю для вызываемых заявок, зависит от числа состояний случайной среды S

        private List<double> workTimes = new List<double>();

        private int processedRequestsCount = 0; //для статистики

        private int deviceState = 0; //состояние девайса 0,1,2

        public Device(ExponentialGenerator exponentialGenerator, List<double> mu1List, List<double> mu2List)
        {
            this.exponentialGenerator = exponentialGenerator;
            this.mu1List = mu1List;
            this.mu2List = mu2List;
        }

        internal bool isBusy()
        {
            return request != null;
        }

        internal double getEventTime() //время когда девайс завершит работу, если он свободен, то бесконечность
        {
            return request != null ? request.getTime() : double.MaxValue;
        }

        internal Request removeRequest() //забирает заявку из прибора
        {
            var requestToRemove = request;
            request = null;
            deviceState = 0;
            processedRequestsCount++;
            return requestToRemove;
        }

        internal void addRequest(bool isIncomming, Request request, int state) //функция передачи заявки на обработку в устройство
        {
            
            deviceState = isIncomming ? 1 : 2;
            //если заявка из входящего потока или из ИПВ, то используем параметр mu1, если это заявка вызываемая заявка из внешней среды, то используем параметр mu2
            double parameter = isIncomming ? mu1List[state] : mu2List[state];
            double workTime = Math.Abs(exponentialGenerator.generate(parameter)); //время сколько будет обрабатываться заявка, время работы прибора
            double startTime = request.getTime(); //время когда прибор начал работать
            double endTime = startTime + workTime; //время когда прибор закончит работать

            request.setTime(endTime); //устанавливаем новое время, в данном случае это когда заявка закончит обрабатываться в приборе

            workTimes.Add(workTime); //ведем статистику работы прибора

            this.request = request;
        }

        internal void Clear()
        {
            request = null;
            processedRequestsCount = 0;
            deviceState = 0;
            workTimes.Clear();
        }

        internal int getProcessedRequestsCount()
        {
            return processedRequestsCount;
        }

        internal List<double> getWorkTimes() { 
            return workTimes;
        }
    }
}
