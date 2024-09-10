using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1._2
{
    public interface ICalculator
    {
        decimal Add(decimal a, decimal b);
        decimal Subtract(decimal a, decimal b);
        decimal Multiply(decimal a, decimal b);
        decimal Divide(decimal a, decimal b);
    }
    
    public class Math : ICalculator
    {
        public decimal Add(decimal a, decimal b) 
        { return a + b; }

        public decimal Subtract(decimal a, decimal b) 
        { return a - b; }

        public decimal Multiply(Decimal a, decimal b) 
        { return a * b; }

        public decimal Divide(Decimal a, decimal b)
        { 
            if (a == 0 || b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
         
    }
}
