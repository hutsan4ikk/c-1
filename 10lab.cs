
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace HUUTSAN
{
    
    
    public static class ArrExt
    {
        public static void rev(this int []arr)
        {
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    } 
    
    class Program
    {
      
        static void Main(string[] args)
        {

            int[] arr = new[] {1, 2, 3};
            arr.rev();

        }
    }
}
