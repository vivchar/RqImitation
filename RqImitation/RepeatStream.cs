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
            request.setTime( request.getTime() + randomDelay); //устанавливаем новое время события для заявки, в данном случае это время когда заявка покинет прибор
            request.incrementRepeatCounter(); //так как заявка попала в ИПВ - увеличиваем счетчик для статистики
            requests.Add(request);
        }

        internal int getRequestsCount() { //для статистики
            return requests.Count();
        }

        internal List<Request> getRequests() //возвращаем список заявок в ИПВ, для статистики
        {
            return requests;
        }

        internal Request getRequest() 
        {
            //изымаем ближайшую заявку с минимальным временем
            Request request = requests.Find(it => it.getTime() == getEventTime());
            requests.Remove(request); //удаляем из списка ИПВ
            processedEventCount++; //увеличиваем число обработанных заявок, для статистики
            return request;
        }

        internal void Clear()
        {
            requests.Clear();
            processedEventCount = 0;
        }

        internal int getProcessedEventCount() //для статистики
        {
            return processedEventCount;   
        }
    }
}
