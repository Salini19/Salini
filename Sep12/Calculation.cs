using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        public double Power { get; }
        public double Number{ get; set; }

        public Calculation()
        {
            Power = 3;
        }
      
      
        public double Cube(double n)
        {
            Number = n;
            return Math.Pow(n, Power);
        }
        public double SquareRoot(double n)
        {
            Number = n;
            return Math.Sqrt(n);
            //Console.WriteLine("Squareroot : "+Math.Sqrt(d));
        }
        
    }
}
