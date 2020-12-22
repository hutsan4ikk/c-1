using System;

namespace HUUTSAN
{
    class Program
    {
        
        
        
        
        static void Main(string[] args)
        {


            int x = Convert.ToInt32(Console.ReadLine());

            if (x%2==0 && (x>9 && x < 100))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            

        }
    }
}
