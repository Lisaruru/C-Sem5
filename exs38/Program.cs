//Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
using System;

namespace exs38
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[6];
            double diff=0;
           void RandomArray(double[]array)
           {
                for(int i=0; i < arr.Length; i++)
                {
                    Random rnd=new Random();
                    double value=rnd.NextDouble();
                    arr[i]=value; 
                    Console.Write ($"{arr[i]} ");
                }

            }
             
           RandomArray(arr);
            double maxNum=arr[0];
            double minNum=arr[0];
            for(int i=1; i < arr.Length; i++)
                {
                if (arr[i]> maxNum) 
                    {
                        maxNum=arr[i];
                    }
                if (arr[i]< minNum)
                {
                    minNum=arr[i];
                }
                  
               }
            diff=maxNum-minNum;
            Console.WriteLine();
            Console.WriteLine(diff);
            

    }
}
}
