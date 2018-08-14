using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public class Person:PhoneBook
    {

        public Person(string SurName,string Address,string TelNum)
        {
            this.SurName = SurName;
            this.Address = Address;
            this.TelNum = TelNum;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("___________________________");
            Console.WriteLine("Фамилия: " + SurName);
            Console.WriteLine("Адрес: " + Address);
            Console.WriteLine("Номер телефона: " + TelNum);
            Console.WriteLine("___________________________");
        }
    }
}
