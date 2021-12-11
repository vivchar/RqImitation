using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class ExponentialGenerator
    {
        private Random random;

        internal ExponentialGenerator(Random random) { 
            this.random = random;
        }

        internal double generate(double parameter) {
            return Math.Log(random.NextDouble()) / parameter;
        }
    }
}
