using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePhoneBook SPB = new ServicePhoneBook();
            SPB.Create();
            while(true)
            {
                Console.WriteLine("1: Вывести информацию\n2: Поиск по фамилии\n3: Выход\n");
                int x = Int32.Parse(Console.ReadLine());
                if(x==1)
                {
                    Console.Clear();
                    SPB.PrintPhoneBook();
                    Console.WriteLine("\n\nPress any key...");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (x ==2)
                {
                    Console.Clear();
                    SPB.FindBySName();
                    Console.WriteLine("\n\nPress any key...");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (x == 3)
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
