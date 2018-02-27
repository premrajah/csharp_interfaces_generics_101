using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    interface IRandomizable
    {
        double GetRandomNum(double dUpperBound);
    }
}
