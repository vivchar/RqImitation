using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class RepeatStream
    {
        private Random random;
        private double gamma;
        private List<Request> requests = new List<Request>();
        private int processedEventCount = 0;

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

        internal void addRequest(Request request)
        {
            double randomDelay = random.NextDouble(); //todo use exp and gamma param
            requests.Add(new Request(request.getTime() + randomDelay));
        }

        internal int getRequestsCount() { 
            return requests.Count();
        }

        internal Request getRequest()
        {
            //изымаем ближайшую заявку с минимальным временем
            Request request = requests.Find(it => it.getTime() == getEventTime());
            requests.Remove(request);
            processedEventCount++; //увеличиваем число обработанных заявок
            return request;
        }

        internal int getProcessedEventCount()
        {
            return processedEventCount;   
        }
    }
}
