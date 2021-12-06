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

        internal void addRequest(Request request)
        {
            //double mu1Time = Math.Abs(Math.Log(random.NextDouble()) / mu1List.FirstOrDefault());
            //переделать на эксп, должно зависеть от куда заявка, плюс разные состояния прибора
            double mu1Time = random.NextDouble();
            this.request = new Request(request.getTime() + mu1Time);
        }

        internal int getProcessedRequestsCount()
        {
            return processedRequestsCount;
        }
    }
}
