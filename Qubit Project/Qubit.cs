using System;
using System.Numerics;

namespace Qubit_Project
{
    public class Qubit
    {
        public Complex c1;
        public Complex c2;
        double MinM = Math.Pow(10, -12);
            
        public Qubit(Complex complex1, Complex complex2)
        {
            c1 = complex1;
            c2 = complex2;
            double mag = Math.Pow(complex1.Magnitude, 2) + Math.Pow(complex2.Magnitude, 2);
            if (Math.Abs(mag - 1) >= MinM)
            {
                Console.WriteLine(" Incorrect input, input will be normalized");
                c1 = (Complex) c1 / Math.Sqrt(mag);
                c2 = (Complex) c2 / Math.Sqrt(mag);
            }
        }
    }
}