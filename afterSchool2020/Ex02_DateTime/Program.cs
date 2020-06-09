using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime;
            dateTime = new DateTime(2020, 6, 9, 5, 30, 25);
            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime.Hour.ToString());

            dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime.Hour.ToString());

            if (dateTime.Hour < 12)
            {
                Console.WriteLine("현재 오전 " + dateTime.Hour.ToString() + "시 입니다.");
            }
            else
            {
                Console.WriteLine("현재 오후 " + dateTime.Hour.ToString() + "시 입니다.");
            }
        }
    }
}
