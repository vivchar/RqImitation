using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class Request
    {
        private double time = 0;

        public Request(double time)
        {
            this.time = time;
        }

        internal double getTime() { 
            return time;
        }
    }
}
