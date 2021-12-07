using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class Device
    {
        private Request request = null;

        private Random random;
        private List<double> mu1List;
        private List<double> mu2List;

        private int processedRequestsCount = 0;

        public Device(Random random, List<double> mu1List, List<double> mu2List)
        {
            this.random = random;
            this.mu1List = mu1List;
            this.mu2List = mu2List;
        }

        internal bool isBusy()
        {
            return request != null;
        }

        internal double getEventTime()
        {
            return request != null ? request.getTime() : double.MaxValue;
        }

        internal Request removeRequest()
        {
            var requestToRemove = request;
            request = null;
            processedRequestsCount++;
            return requestToRemove;
        }

        internal void addRequest(bool isIncomming, Request request, int state)
        {
            //если заявка из входящего потока или из входящего ИПВ, то используем параметр mu1, если это заявка вызываемая заявка из внешней среды, то используем параметр mu2
            double parameter = isIncomming ? mu1List[state] : mu2List[state];
            double time = Math.Abs(Math.Log(random.NextDouble()) / parameter);
            this.request = new Request(request.getTime() + time);
        }

        internal int getProcessedRequestsCount()
        {
            return processedRequestsCount;
        }
    }
}
