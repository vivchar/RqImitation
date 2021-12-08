using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    //источник повторных вызовов
    internal class RepeatStream
    {
        private Random random;
        private double gamma;
        private List<Request> requests = new List<Request>();
        private int processedEventCount = 0; //для статистики

        public RepeatStream(Random random, double gamma)
        {
            this.random = random;
            this.gamma = gamma;
        }

        internal bool hasRequests() { 
            return requests.Any();
        }

        internal double getEventTime()
        {
            return requests.Any() ? requests.Min(it => it.getTime()) : double.MaxValue; //выбираем ближайшую заявку с минимальным временем
        }

        internal void addRequest(Request request) //добавляет заявку в ИПВ и генерирует случайную задержку для повторного вызова
        {
            double randomDelay = Math.Abs(Math.Log(random.NextDouble()) / gamma);
            //double randomDelay = random.NextDouble();
            requests.Add(new Request(request.getTime() + randomDelay));
        }

        internal int getRequestsCount() { //для статистики
            return requests.Count();
        }

        internal Request getRequest() 
        {
            //изымаем ближайшую заявку с минимальным временем
            Request request = requests.Find(it => it.getTime() == getEventTime());
            requests.Remove(request);
            processedEventCount++; //увеличиваем число обработанных заявок, для статистики
            return request;
        }

        internal int getProcessedEventCount() //для статистики
        {
            return processedEventCount;   
        }
    }
}
