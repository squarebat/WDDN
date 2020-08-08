using System;
using my_prog;
namespace driver_prog
{
    public class driver
    {
        static void Main(string[] args)
        {
            calc cal = new calc();
            Console.WriteLine(cal.sum(2,3));
			Console.WriteLine(cal.multiplication(2,3));
            Console.ReadKey();
        }
    }
}