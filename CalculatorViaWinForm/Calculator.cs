using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorViaWinForm
{
    
    public class Calculator
    {
        public string Plus(double fNum, double sNum)
        {
            return (fNum + sNum).ToString();
        }
        public string Minus(double fNum, double sNum)
        {
            return (fNum - sNum).ToString();
        }
        public string Devide(double fNum, double sNum)
        {
            if (sNum == 0)
            {
                return "Error";
            }
            return (fNum / sNum).ToString();
        }
        public string Multiply(double fNum, double sNum)
        {
            return (fNum * sNum).ToString();
        }

        public string SecondDeegre(double fNum, double sNum)
        {
            return Math.Pow(fNum, 2).ToString();
        }
        public string AnyDeegre(double fNum, double sNum)
        {
            return Math.Pow(fNum, sNum).ToString();
        }
        public string SecondRoot(double fNum, double sNum)
        {
            return Math.Sqrt(fNum).ToString();
        }
        public string AnyRoot(double fNum, double sNum)
        {
            return Math.Pow(fNum, 1 / sNum).ToString();
        }
    }
}
