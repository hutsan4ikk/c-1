using System;

namespace HUUTSAN
{
    class Program
    {
        
        
        
        
        static void Main(string[] args)
        {

           
            
            int[,] array2D = new int[,] { { 1, 2 , 3,4}, { 5 , 6 ,7 ,8} ,{8 , 9,10,11} , {11 , 12,13,14}};
           
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{array2D[i,j]} ");
                }

                Console.WriteLine();
            }


            
            Console.WriteLine();

            int n = 4;
            int min;
            
            
 
            int i1,j1;
            for(int j=0; j<n; j++)
            {
                min=array2D[0,j];
                i1=0;
                j1=j;
                for(int i=1; i<n; i++)
                    if(array2D[i,j]<min)
                    {
                        min=array2D[i,j];
                        i1=i;
                        j1=j;
                    }
                array2D[i1,j1]=array2D[n-1-j,j];
                array2D[n-1-j,j]=min;
            }
            
            
            
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{array2D[i,j]} ");
                }

                Console.WriteLine();
            }


            

        }
    }
}
