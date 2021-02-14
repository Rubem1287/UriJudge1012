using System;
using System.Globalization;
namespace Uri_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, v33, v3, a, b, c, d, e, pi;

            pi = 3.14159;

            Console.WriteLine();
            Console.Write("Digite os três valores de A, B e C : ");
            string[] vetor = Console.ReadLine().Split(' ');
            v1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            v2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            v3 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            v33 = v3;

            v33 = Math.Pow(v33, 2);

            a = (double)v1 * v3 / 2;
            b = (double) pi * v33;
            c = (double) (((v1+v2)*v3)/2);
            d = (double)v2 * v2;
            e = (double)v1 * v2;

            Console.WriteLine();
            Console.Write("Triangulo : "+a.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Circulo : " + b.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Trapézio : " + c.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Quadrado : " + d.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Retângulo : " + e.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
