using System;
using System.Numerics;

namespace Qubit_Project
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please input Qubit");
            
            Console.WriteLine("Please input a");
            var numbers = Console.ReadLine();
            var numberList = numbers.Split(' ');
            var number1 = Convert.ToDouble(numberList[0]);
            var number2 = Convert.ToDouble(numberList[1]);
            //Console.WriteLine(number1 + " " + number2);
            Complex c1 = new Complex(number1, number2);
            
            Console.WriteLine("Please input b");
            var numbers2 = Console.ReadLine();
            var numberList2 = numbers2.Split(' ');
            var number12 = Convert.ToDouble(numberList2[0]);
            var number22 = Convert.ToDouble(numberList2[1]);
            //Console.WriteLine(number11 + " " + number22);
            Complex c2 = new Complex(number12, number22);
            
            Qubit q = new Qubit(c1, c2);
            Complex p1 = new Complex(0, 0);
            Complex p2 = new Complex(1, 0);
            
            Qubit p = new Qubit(p1, p2);
            TensorProduct tq = new TensorProduct(q, p);
            
            Matrix m = new Matrix();
            TensorProduct tq1 = m.GetProduct(m.HHmatrix(), tq);
            TensorProduct tq2 = m.GetProduct(m.inputMatrix(), tq1);
            TensorProduct tq3 = m.GetProduct(m.HImatrix(), tq2);
            
            //Console.WriteLine(tq3.measure());
            if (tq3.measure() == 0)
            {
                Console.WriteLine("Function is constant");
            }
            else
                Console.WriteLine("Function is not constant");
            // if we run the computer several times with the same input data, the output might be different each time.
            // In Deutsch algorthm, the input data is chosen very specifically so that output will stay the same
        }
    }
}