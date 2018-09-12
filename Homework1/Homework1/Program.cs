using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace p_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int n1, n2;
            System.Console.Write("please input an int a: ");
            a = Console.ReadLine();
            n1 = Int32.Parse(a);
            string b;
            System.Console.Write("please input another int b: ");
            b = Console.ReadLine();
            n2 = Int32.Parse(b);
            Console.WriteLine("The product of a*b: ");
            Console.WriteLine(n1 * n2);

        }
    }
}
