using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Task_1
{
    public class LinqBasics {         
        
		static void Main(string[] args)
        {
			List <int> numbers = new List<int>();
			for(int i=1;i<=100;i++)
			{
				numbers.Add(i);
			}				
            Console.Write("Even Numbers: ");
            var even = numbers.Where(num => num%2==0);
            foreach (int x in even)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n");
            Console.Write("Odd Numbers: ");
            var odd = numbers.Where(num => num%2!=0);
            foreach(int x in odd)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n");

            Console.Write("Select All Numbers: ");
            var all = numbers.Select(num => num);
            foreach(int x in all)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n");

            Console.Write("Select max and min: ");
            int max = numbers.Max();
            int min = numbers.Min();
            
            Console.WriteLine("Max: "+max+" Min: "+min+"\n");

            var avg = numbers.Average();
            Console.WriteLine("Average: "+avg+"\n");
           
        }
    }
}