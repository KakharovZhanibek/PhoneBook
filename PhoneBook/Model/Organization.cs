using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public class Organization:PhoneBook
    {
        public string Name { get; set; }
        public string Fax { get; set; }
        public string FIO { get; set; }

        public Organization(string Name, string Fax,string FIO)
        {
            this.Name = Name;
            this.Fax = Fax;
            this.FIO = FIO;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("___________________________");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Адрес: " + Address);
            Console.WriteLine("Номер телефона: " + TelNum);
            Console.WriteLine("Факс: " + Fax);
            Console.WriteLine("Контактное лицо: " + FIO);
            Console.WriteLine("___________________________");
        }
    }
}
