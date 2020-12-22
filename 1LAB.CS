using System;

namespace HUUTSAN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[]resists = new int[n];
            for (int i = 0; i < resists.Length; i++)
            {
                resists[i] = Convert.ToInt32(Console.ReadLine());
            }


            int a = 1;
            int b = 0;
            foreach (var i in resists)
            {
                a *= i;
                b += i;
            }

            double result = (a *1.0) / (b * 1.0);
            Console.WriteLine($"resist is {result} ");
            
        }
    }
}
