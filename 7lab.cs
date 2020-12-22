using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace HUUTSAN
{
    class Program
    {
      
        static void Main(string[] args)
        {

           List<double> list= new List<double>();
           int x = Convert.ToInt32(Console.ReadLine());

           for (int i = 0; i < x; i++)
           {
               list.Add(Convert.ToDouble(Console.ReadLine()));
           }

           double find = Convert.ToDouble(Console.ReadLine());

           int ind = 0;
           foreach (var v in list)
           {
               
               if (v == find)
               {
                   Console.WriteLine(ind);
               }

               ind++;
           }
           

        }
    }
}
