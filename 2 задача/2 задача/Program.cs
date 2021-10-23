using System;

namespace _2_задача
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("p = ");
            int p = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= p; i++)
            {
                sum *= i;
            }
            Console.WriteLine("Сумма факториала {0} равна {1}", p, sum);
        }
    }
}
