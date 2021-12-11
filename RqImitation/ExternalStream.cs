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
        private ExponentialGenerator exponentialGenerator;
        private double alpha;
        private double eventTime = 0;
        private int processedRequestsCount = 0; //для статистики, число обработанных событий

        public ExternalStream(ExponentialGenerator exponentialGenerator, double alpha)
        {
            this.exponentialGenerator = exponentialGenerator;
            this.alpha = alpha;
        }

        internal double getEventTime(double currentTime)
        {
            //так как внешняя среда имеет свою интенсивность, мы должны обрабатывать только те события, когда девайс свободен, поэтому передаем текущее время всей системы
            eventTime = currentTime - exponentialGenerator.generate(alpha);
            return eventTime;
        }

        internal int getProcessedRequestsCount() //для статистики
        {
            return processedRequestsCount;
        }

        internal Request getRequest()
        {
            processedRequestsCount++;
            //не генерируем сл событие, так как зависим от занятости девайса и времени
            return new Request(eventTime); //создаем новую заявку, которая вызвалась прибором из внешней среды. Время - это время вызова заявки
        }

        internal void Clear()
        {
            eventTime = 0;
            processedRequestsCount = 0;
        }
    }
}
