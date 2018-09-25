using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "";
            int BigNumber;
            Console.WriteLine("输入数据，我们能帮你求出它的素数因子 ");
            S = Console.ReadLine();
            BigNumber = Int32.Parse(S);
            int[] SourcePrimeNumber={ 2, 3, 5, 7,11, 13,17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            bool ifPrimenumber = false;
            int[] PrimerNumberBig = new int[111];
            for(int i=0;i<25 ;i++)
            {
                if( BigNumber % SourcePrimeNumber[i] == 0)
                {
                    Console.WriteLine("它的素数因子有 "+SourcePrimeNumber[i]); 
                }
                if (i == 24) { ifPrimenumber = true; }
            }
            if(ifPrimenumber)
            {
                Console.WriteLine("它的素数因子有 " +BigNumber);
            }
        }
    }
}
