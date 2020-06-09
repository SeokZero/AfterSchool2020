using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_PrindOddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("정수를 입력하세요.");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
