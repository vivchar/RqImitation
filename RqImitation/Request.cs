using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    //класс описывающий заявку
    internal class Request
    {
        private double time = 0;
        private double startTime = 0; //время обращения заявки в прибор, по сути время создания заявки, так как она создается в момент обращения в прибор
        private int repeatCounter = 0; // количество попаданий в ИПВ

        public Request(double time)
        {
            this.startTime = time; //время события заявки совпадает с временем создания
            this.time = time;
        }

        internal double getTime() { 
            return time;
        }

        internal double getStartTime() { //время первого обращения заявки, для статистики
            return startTime;
        }

        internal void setTime(double time) { //установить новое время
            this.time = time;
        }

        internal void incrementRepeatCounter() { //увеличить счетчик попаданий в ИПВ
            repeatCounter++;
        }

        internal int getRepeatCounter() { //вернуть количество попаданий в ИПВ
            return repeatCounter;
        }
    }
}
