using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, i = 0, j = 0, c = 0, z = 0;
            Console.WriteLine("Введите количество столбцов в матрице: ");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество строк: ");
            N = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[N, M];
            Console.WriteLine("Введите матрицу: ");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("Элемент [" + (i + 1) + "," + (j + 1) + "]: ");
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Полученная матрица: ");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
            int min = Matrix[0, 0];
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (Matrix[i, j] < min)
                    {
                        min = Matrix[i, j];
                        c = i + 1;
                        z = j + 1;
                    }
                }
            }
            Console.WriteLine("Минимальное значение элемента={0}, его позиция в матрице={1},{2}", min, c, z);
            Console.ReadKey();
        }
    }
}
