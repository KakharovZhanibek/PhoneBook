using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public class Friend:PhoneBook
    {
        public DateTime DB { get; set; }
        public Friend(DateTime DB)
        {
            this.DB = DB;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("___________________________");
            Console.WriteLine("Фамилия: " + SurName);
            Console.WriteLine("Номер телефона: " + TelNum);
            Console.WriteLine("Дата рождения: " + DB);
            Console.WriteLine("___________________________");
        }
    }
}
