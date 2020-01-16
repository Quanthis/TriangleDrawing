using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {//Zadanie 6.:
            int i, n, j;
            Console.WriteLine("Tell me height of the triangle you want: (greater than 0 please) n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1; i<=n; i++)
            {
                for (j = 1; j<=n - i; j++) Console.Write(" ");
                for (j=1; j<=2*i-1; j++)   Console.Write("*");
                
                 Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
