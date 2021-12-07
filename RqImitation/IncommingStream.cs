using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    //входящий пуассоновский поток
    internal class IncommingStream
    {
        private Random random;
        private double lambda;
        private double eventTime = 0;
        private int processedRequestsCount = 0;  //для статистики, сколько событий обработано

        internal IncommingStream(Random random, double lambda) {
            this.random = random;
            this.lambda = lambda;
        }

        internal double getEventTime() //возвращает ближайшее событие, если это первый вызов, то генерирует первое событие
        {
            if (eventTime == 0) {
                generateNextEvent();
                processedRequestsCount = 0;
            }
            return eventTime;
        }

        internal void generateNextEvent() // функция генерирует следующее событие
        {
            eventTime = eventTime - Math.Log(random.NextDouble()) / lambda;
        }

        internal int getProcessedRequestsCount() { 
            return processedRequestsCount;
        }

        internal Request getRequest() //возвращает-извлекает заявку для текушего времени
        {
            var request = new Request(eventTime);
            generateNextEvent(); //после того как взяли заявку для данного времени - генерируем новое время заявки
            processedRequestsCount++; //увеличиваем число обработанных заявок
            return request;
        }
    }
}
