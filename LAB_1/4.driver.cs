using System;
using calc;
namespace driver_prog
{
    class Driver
    {
        static void Main(string[] Args)
        {
            Console.Write("Enter Number 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            addition add= new addition();
            
            Console.WriteLine("Sum of both numbers: {0}",add.add(n1,n2));
            Console.ReadKey();
        }
    }
}