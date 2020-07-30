using System;
namespace add_user_input
{
    public class Add {         
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of both numbers: {0}",n1+n2);
            Console.ReadKey();
        }
    }
}