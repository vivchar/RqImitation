using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    //поток внешней среды для вызовов заявок
    internal class ExternalStream
    {
        private Random random;
        private double alpha;
        private double eventTime = 0;
        private int processedRequestsCount = 0; //для статистики, число обработанных событий

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
            //не генерируем сл событие, так как зависим от занятости девайса и времени
            return new Request(eventTime);
        }
    }
}
