// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
using System;

namespace exs34
{
    class Program
    {
        static void Main(string[] args)
        
        {  
           int[] arr = new int[15];
           int evenNum=0;
           void RandomArray(int[]array)
           {
                for(int i=0; i < arr.Length; i++)
                {
                    Random rnd=new Random();
                    int value=rnd.Next(100,999);
                    arr[i]=value; 
                    Console.Write ($"{arr[i]} ");
                }

            }
             
           RandomArray(arr);
           
            for(int i=0; i < arr.Length; i++)
                { 
                    if (arr[i]%2==0)
                    evenNum=evenNum+1;
                }
            Console.WriteLine();
            Console.WriteLine(evenNum);

             

        }
    }
}
