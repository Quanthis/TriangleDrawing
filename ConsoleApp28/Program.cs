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
            Console.WriteLine("Podaj liczbę gwiazdek w wysokości trójkąta (więszką od 1) n=");
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
