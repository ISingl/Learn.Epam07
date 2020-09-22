using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MatrixType
{
    public class Matrix
    {
        private double[,] Data { get; set; }
        private int N { get; set; }
        private int M { get; set; }
        public double this[int x, int y]
        {
            get 
            {
                return Data[x, y];
            }
            set
            {
                Data[x, y] = value;
            }
        }

        public Matrix(int m, int n)
        {
            M = m;
            N = n;
            Data = new double[m, n];
        }

        public static Matrix Sum(Matrix a, Matrix b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException("The argument cannot be null.");
            if (a.M != b.M || a.N != b.N)
                throw new ArgumentException("The dimensions of the matrixes do not match.");

            Matrix res = new Matrix(a.M, a.N);
            for (int i = 0; i < a.M; i++)
                for (int j = 0; j < a.N; j++)
                    res[i, j] = a[i, j] + b[i, j];

            return res;
        }

        public static Matrix Subtraction(Matrix a, Matrix b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException("The argument cannot be null.");
            if (a.M != b.M || a.N != b.N)
                throw new ArgumentException("The dimensions of the matrixes do not match.");

            Matrix res = new Matrix(a.M, a.N);
            for (int i = 0; i < a.M; i++)
                for (int j = 0; j < a.N; j++)
                    res[i, j] = a[i, j] - b[i, j];

            return res;
        }

        public static Matrix Multiplication(Matrix a, Matrix b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException("The argument cannot be null.");
            if (a.N != b.M)
                throw new ArgumentException("Matrixes can not be multiplied.");

            Matrix res = new Matrix(a.M, b.N);
            for (int i = 0; i < a.M; i++)
                for (int j = 0; j < b.M; j++)
                    for (int k = 0; k < b.N; k++)
                        res[i, j] += a[i, k] + b[k, j];

            return res;
        }
    }
}
