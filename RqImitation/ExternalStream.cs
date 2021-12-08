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
            //так как внешняя среда имеет свою интенсивность, мы должны обрабатывать только те события, когда девайс свободен, поэтому передаем текущее время всей системы
            var randomDouble = random.NextDouble();
            eventTime = currentTime - Math.Log(randomDouble) / alpha;
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
    }
}
