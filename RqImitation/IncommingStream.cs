using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class IncommingStream
    {
        private Random random;
        private double lambda;
        private double eventTime = 0;
        private int processedRequestsCount = 0;

        internal IncommingStream(Random random, double lambda) {
            this.random = random;
            this.lambda = lambda;
        }

        internal double getEventTime()
        {
            if (eventTime == 0) {
                generateNextEvent();
                processedRequestsCount = 0;
            }
            return eventTime;
        }

        internal void generateNextEvent()
        {
            eventTime = eventTime - Math.Log(random.NextDouble()) / lambda;
        }

        internal int getProcessedRequestsCount() { 
            return processedRequestsCount;
        }

        internal Request getRequest()
        {
            var request = new Request(eventTime);
            generateNextEvent(); //после того как взяли заявку для данного времени - генерируем новое время заявки
            processedRequestsCount++; //увеличиваем число обработанных заявок
            return request;
        }
    }
}
