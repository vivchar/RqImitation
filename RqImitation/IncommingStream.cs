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
        private ExponentialGenerator exponentialGenerator;
        private double lambda;
        private double eventTime = 0;
        private int processedRequestsCount = 0;  //для статистики, сколько событий обработано

        internal IncommingStream(ExponentialGenerator exponentialGenerator, double lambda) {
            this.exponentialGenerator = exponentialGenerator;
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
            eventTime = eventTime - exponentialGenerator.generate(lambda);
        }

        internal int getProcessedRequestsCount() { //статистика
            return processedRequestsCount;
        }

        internal Request getRequest() //возвращает-извлекает заявку для текушего времени
        {
            var request = new Request(eventTime); //создаем новую заявку, которая пришла из входящего потока, устанавливаем время - это время обращения заявки к прибору
            generateNextEvent(); //после того как взяли заявку для данного времени - генерируем новое время заявки
            processedRequestsCount++; //увеличиваем число обработанных заявок
            return request;
        }

        internal void Clear()
        {
            eventTime = 0;
            processedRequestsCount = 0;
        }
    }
}
