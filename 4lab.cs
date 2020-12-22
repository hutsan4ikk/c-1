using System;

namespace HUUTSAN
{
    class Program
    {
        
        
        
        
        static void Main(string[] args)
        {

            int[] arr = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    Console.Write(arr[i] + " ");
                }

                if (i == arr.Length-1)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j]%2 != 0)
                        {
                            Console.Write(arr[j] + " ");
                        }
                    }
                }
                
                
            }


        }
    }
}

