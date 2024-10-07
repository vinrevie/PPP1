using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATS ats1 = new ATS(710, 250, "ул. Политехническая, д. 27");
            ats1.ShowInfo();
            Console.ReadKey();
        }
    }
}
//Здание – Отопительная система. 