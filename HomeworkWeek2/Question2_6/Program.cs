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
            //int RootNumber = (int)Math.Sqrt(BigNumber);
            //float[] SourcePrimeNumber = new float[10];
            //float[] Number = new float[100];//100以内
            //for(int i=2;i<100;i++)
            //{
            //    Number[i] = i;
            //}
            //for(int j=2,m=0;j<100;j++)//获得质数
            //{
            //    for(float k=2;k<j&&Number[j]%k!=0;k++)
            //    {

            //    }
            //    SourcePrimeNumber[m] = Number[j];
            //    m++;
            //}
            bool ifPrimenumber = false;
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
