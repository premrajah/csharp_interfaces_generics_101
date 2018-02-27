using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class MyRandomizer : IRandomizable  
    {
        public MyRandomizer() { }

        public double GetRandomNum(double dUpperBound)
        {
            Random rNumGen = new Random();
            double seed = rNumGen.NextDouble();
            return seed * dUpperBound;
        }
    }
}
