using System;
using System.Reflection;
[assembly: AssemblyVersion("1.0.0.0")]
namespace my_prog
{
    public class calc
    {
        public int sum(int x,int y)
        {
			Console.WriteLine("This is version 1.0.0.0");
            return x + y;
        }
		public int multiplication(int x,int y)
        {
			Console.WriteLine("This is version 1.0.0.0");
            return x * y;
        }
    }
}
