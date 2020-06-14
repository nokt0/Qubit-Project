using System;
using System.Numerics;
using MathNet.Numerics.Distributions;

namespace Qubit_Project
{
    public class TensorProduct
    {
        public Complex alpha;
        public Complex beta;
        public Complex gama;
        public Complex delta;
        double MinM = Math.Pow(10, -12);

        public TensorProduct(Qubit q, Qubit p)
        {
            alpha = Complex.Multiply(q.c1, p.c1);
            beta = Complex.Multiply(q.c1, p.c2);
            gama = Complex.Multiply(q.c2, p.c1);
            delta = Complex.Multiply(q.c2, p.c2);
        }
        public TensorProduct()
        {
            
        }
        public int measure()
        {
            double sqr = 1 / Math.Sqrt(2);
            alpha = alpha * sqr * 0.5;
            beta = beta * sqr * 0.5;
            Console.WriteLine(alpha.Magnitude * alpha.Magnitude + beta.Magnitude * beta.Magnitude);
            double prob = alpha.Magnitude * alpha.Magnitude + beta.Magnitude * beta.Magnitude;

            int res = MathNet.Numerics.Distributions.Bernoulli.Sample(prob);
            return 1 - res;
        }
    }
}