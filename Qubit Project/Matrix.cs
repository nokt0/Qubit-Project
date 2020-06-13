using System;
using System.IO;
using System.Numerics;
namespace Qubit_Project
{
    public class Matrix
    {
        public double[,] HHmatrix()
        {
            //double[,] hh = new double[4, 4] { { 0.5, 0.5, 0.5, 0.5 }, { 0.5, -0.5, 0.5, -0.5 }, { 0.5, 0.5, -0.5, -0.5}, { 0.5, -0.5, -0.5, 0.5 } };
            double[,] hh = new double[4, 4] { { 1, 1, 1, 1 }, { 1, -1, 1, -1 }, { 1, 1, -1, -1}, { 1, -1, -1, 1 } };
            return hh;
        }
        
        public double[,] HImatrix()
        {
            //double sqr = 0.707107;
            //double[,] hi = new double[4, 4] { { 1 * sqr, 0, 1 * sqr, 0 }, { 0, 1 * sqr, 0, 0 }, { 1 * sqr, 0, -1* sqr, 0}, { 0, 1*sqr, 0, -1*sqr } };
            double[,] hi = new double[4, 4] { { 1 , 0, 1 , 0 }, { 0, 1, 0, 1 }, { 1 , 0, -1, 0}, { 0, 1, 0, -1 } };
            return hi;
        }

        public double[,] inputMatrix()
        {
            String input = File.ReadAllText( @"/Users/paulshaburov/Documents/Qubit Project/Qubit Project/HiddenFile.txt" );
            
            int i = 0, j = 0;
            double[,] result = new double[4, 4];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    result[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            return result;
        }

        public TensorProduct GetProduct(double [,] matrix, TensorProduct q)
        {
            TensorProduct getQ = new TensorProduct();
            getQ.alpha = matrix[0, 0] *q.alpha + matrix[0, 1] * q.beta + matrix[0, 2] * q.gama +
                         matrix[0, 3] * q.delta;
            getQ.beta = matrix[1, 0] * q.alpha + matrix[1, 1] * q.beta + matrix[1, 2] * q.gama +
                         matrix[1, 3] * q.delta;
            getQ.gama = matrix[2, 0] * q.alpha + matrix[2, 1] * q.beta + matrix[2, 2] * q.gama +
                         matrix[2, 3] * q.delta;
            getQ.delta = matrix[3, 0] * q.alpha + matrix[3, 1] * q.beta + matrix[3, 2] * q.gama +
                         matrix[3, 3] * q.delta;
            return getQ;
        }
        
    }
}