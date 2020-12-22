using System;

namespace HUUTSAN
{
    class Program
    {
        
        
        public static double LineSum(double n, double k)
        {
            double res = 0;
            for (int i = 0; i < k; i++)
            {
                res += ((Math.Pow(k, 2) - 1) / (Math.Pow(-1, k+1) * Math.Pow(k,2) + 7));
            }
            return res;
        }
        
        
        
        static void Main(string[] args)
        {
            

            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(LineSum(n,k));
            
        }
    }
}
