using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Task_2
{
    public class LinqBasics {         
        
		static void Main(string[] args)
        {
            string[] names_arr = {"Kate","Eren", "Max","Raj","Armin","Mikasa","Rachel","Khadija","Jo","Jean"};
			List <string> names = new List<string>(names_arr);
            
            var k_names = names.Where(name => name.StartsWith("K")==true);

            Console.WriteLine("Names Starting with K:");
            foreach(string name in k_names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            var lt_4 = names.Where(name => name.Length<=4);

            Console.WriteLine("Names with length less than or equal to 4:");
            foreach(string name in lt_4)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            var eq_3 = names.Where(name => name.Length==3);
            
            Console.WriteLine("Names with length equal to 3:");
            foreach(string name in eq_3)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

			var ascend = names.Select(name=>name).OrderBy(name1=>name1);
            
            Console.WriteLine("Names in ascending order:");
            foreach(string name in ascend)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}