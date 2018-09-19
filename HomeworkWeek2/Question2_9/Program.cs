using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isPrime = new bool[101]; //是否素数
            int i;
            for (i = 2; i < 101; i++)
            {
                isPrime[i] = true;
            }
            int j;
            //去掉i的整数倍
            for (i = 2; i < 101; i++)
            {
                for (j = 2; i * j <= 100; j++) //j是倍数
                {
                    isPrime[i * j] = false;
                }
            }
            Console.WriteLine("100以内素数有：");        
            for (i = 2; i < 101; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}