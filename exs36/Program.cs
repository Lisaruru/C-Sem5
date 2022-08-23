// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).

using System;

namespace exs36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
           int oddNum=0;
           void RandomArray(int[]array)
           {
                for(int i=0; i < arr.Length; i++)
                {
                    Random rnd=new Random();
                    int value=rnd.Next(100);
                    arr[i]=value; 
                    Console.Write ($"{arr[i]} ");
                }

            }
             
           RandomArray(arr);
           
            for(int i=1; i < arr.Length; i+=2)
                { 
                    oddNum=oddNum+arr[i];
                }
            Console.WriteLine();
            Console.WriteLine(oddNum);

             

        }
    }
}
