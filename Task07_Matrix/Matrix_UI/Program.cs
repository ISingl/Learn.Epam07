using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixType;

namespace Matrix_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix(3, 3);
            Matrix b = new Matrix(3, 3);
            int n = 1;
            for(int i = 0; i < 3; i++)
                for(int j = 0; j < 3; j++)
                {
                    a[i, j] = n;
                    b[i, j] = n;
                    n++;
                }

            Matrix c = Matrix.Multiplication(a, b);

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Console.Write($"{c[i, j]} ");
            Console.ReadLine();

        }
    }
}
