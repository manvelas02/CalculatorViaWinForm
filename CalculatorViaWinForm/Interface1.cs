using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorViaWinForm
{
    public interface ICalculatorOperation
    {
        void Operation(string operation, Func<double, double, string> op);
    }
}
