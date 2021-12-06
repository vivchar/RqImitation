using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class ExternalStream
    {
        private Random random;
        private double alpha;
        private double eventTime = 0;
        private int processedRequestsCount = 0;

        public ExternalStream(Random random, double alpha)
        {
            this.random = random;
            this.alpha = alpha;
        }

        internal double getEventTime(double currentTime)
        {
            if (eventTime == 0)
            {
                //так как внешняя среда имеет свою интенсивность, мы должны обрабатывать только те события, когда девайс свободен, поэтому передаем текущее время всей системы
                eventTime = currentTime - Math.Log(random.NextDouble()) / alpha;
            }
            return eventTime;
        }

        internal int getProcessedRequestsCount()
        {
            return processedRequestsCount;
        }

        internal Request getRequest()
        {
            processedRequestsCount++;
            return new Request(eventTime);
        }
    }
}
