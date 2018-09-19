using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入10个数字，我们将为你算出最大值，最小值" +
                "平均值和所有元素和");
            int[] Number27 = new int[10];
            
            for(int i=0;i<10;i++)
            {
               
                Number27[i] = Int32.Parse(Console.ReadLine());
            }
            for(int j=0;j<9;j++)
            {
                if (Number27[j]< Number27[j+1])
                {
                    int k;
                    k = Number27[j];
                    Number27[j] = Number27[j + 1];
                    Number27[j + 1] = k;
                }
            }
            Console.WriteLine("最大值为" + Number27[0]);
            Console.WriteLine("最小值为" + Number27[9]);
            int n=0;
            for(int m=0;m<10;m++)
            {
                n = n + Number27[m];
            }
            double Num = (double)n / 10.0;
            Console.WriteLine("平均值为" + Num);
            Console.WriteLine("所有元素和为" + n);

        }
    }
}

