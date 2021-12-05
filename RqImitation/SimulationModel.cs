using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RqImitation
{
    internal class SimulationModel
    {
        private double lambda;
        private double beta;
        private double alpha;
        private double gamma;
        private List<double> mu1List;
        private List<double> mu2List;
        private List<List<int>> matrixQ;

        public SimulationModel(double lambda, double beta, double alpha, double gamma, List<double> mu1List, List<double> mu2List, List<List<int>> matrixQ)
        {
            this.lambda = lambda;
            this.beta = beta;
            this.alpha = alpha;
            this.gamma = gamma;
            this.mu1List = mu1List;
            this.mu2List = mu2List;
            this.matrixQ = matrixQ;
        }

        internal void start(int eventsCount)
        {
            Console.WriteLine("Starting simulation");
        }
    }
}
