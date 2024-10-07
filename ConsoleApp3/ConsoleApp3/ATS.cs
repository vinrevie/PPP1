using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ATS
    {
        private string adress;
        private int numberOfAbonents;
        private int price;
        public string Adress {  get { return adress; } set { adress = value; } }
        public int NumberOfAbonents { get { return numberOfAbonents; } set { numberOfAbonents = value; } }
        public int Price {  set { price = value; } }
        public int Total()
        {
           return numberOfAbonents * price;
        }
        public void ShowInfo()
        {
            Console.WriteLine("АТС по адресу: "+adress+ " содержит "+numberOfAbonents + " абонентов, всего сумма за всех абонентов= "+ Total());
        }
        public ATS(int num, int price, string adress)
        {
            numberOfAbonents = num;
            this.price = price;
            this.adress =adress;
        }

    }
}
