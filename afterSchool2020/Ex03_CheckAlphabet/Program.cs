using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_CheckAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter a character :");
            c = Convert.ToChar(Console.ReadLine());

            if (c >= 'A' && c <= 'z')
            {
                Console.WriteLine(c + "는 알파벳 입니다.");
            }
            else
            {
                Console.WriteLine(c + "는 알파벳이 아닙니다.");
            }
        }
    }
}
