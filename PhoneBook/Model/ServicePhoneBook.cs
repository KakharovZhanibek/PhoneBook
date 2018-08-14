using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public class ServicePhoneBook
    {
        public static List<Person> persons;
        public static List<Friend> friends;
        public static List<Organization> organizations;

        static ServicePhoneBook()
        {
            persons = new List<Person>();
            friends = new List<Friend>();
            organizations = new List<Organization>();
        }
        public void Create()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            Generator gen = new Generator();
            for (int i = 0; i < rnd.Next(20, 50); i++)
            {
                int x = rnd2.Next(1, 4);
                if (x == 1)
                {
                    string str= gen.GenerateDefault((Gender)rnd.Next(2))
                        .Replace("<center><b><font size=7>", "")
                        .Replace("</font></b></center>", "")
                        .Replace("\n", "")
                        .Substring(1);
                    char[] temp = str.ToCharArray();
                    char[] temp2=new char[] {'N','o','n','e' };
                  
                    int c = 0;
                    while (temp[c] != ' ')
                    {
                        c++;
                    }
                    
                    if (temp[c] == ' ')
                    {c++;
                        temp2 = new char[temp.Length - c];
                        for (int j = 0; j < temp2.Length; j++)
                        {
                            temp2[j] = temp[c];
                            c++;
                        }
                    }
                    str = new string(temp2);
                    Person person = new Person(str, "Address_" + rnd.Next(0, 100).ToString(), "8" + rnd.Next(700, 777).ToString() + rnd.Next(1000000, 9999999).ToString());
                    persons.Add(person);
                }
                if (x == 2)
                {
                    string str = gen.GenerateDefault((Gender)rnd.Next(2))
                        .Replace("<center><b><font size=7>", "")
                        .Replace("</font></b></center>", "")
                        .Replace("\n", "")
                        .Substring(1);
                    char[] temp = str.ToCharArray();
                    char[] temp2 = new char[] { 'N', 'o', 'n', 'e' };

                    int c = 0;
                    while (temp[c] != ' ')
                    {
                        c++;
                    }
                    if (temp[c] == ' ')
                    {
                        c++;
                        temp2 = new char[temp.Length - c];
                        for (int j = 0; j < temp2.Length; j++)
                        {
                            temp2[j] = temp[c];
                            c++;
                        }
                    }
                    str = new string(temp2);
                    DateTime db = new DateTime();
                    db = DateTime.Now.AddYears(rnd.Next(-25, -15));
                    db = DateTime.Now.AddMonths(rnd.Next(1,13));
                    db = DateTime.Now.AddDays(rnd.Next(1, 15));
                    Friend friend = new Friend(db);
                    friend.SurName = str;
                    friend.Address = "Address_" + rnd.Next(0, 100).ToString();
                    friend.TelNum = "8" + rnd.Next(700, 777).ToString() + rnd.Next(1000000, 9999999).ToString();
                    friends.Add(friend);
                }
                if (x == 3)
                {
                    string str = gen.GenerateDefault((Gender)rnd.Next(2))
                        .Replace("<center><b><font size=7>", "")
                        .Replace("</font></b></center>", "")
                        .Replace("\n", "")
                        .Substring(1);
                    Organization organization = new Organization("Organization_"+rnd.Next(0,100).ToString(),"8"+rnd.Next(100000000,999999999).ToString(),str);
                    organization.Address = "Address_" + rnd.Next(0, 100).ToString();
                    organization.TelNum = "8" + rnd.Next(700, 777).ToString() + rnd.Next(1000000, 9999999).ToString();

                    char[] temp = str.ToCharArray();
                    char[] temp2 = new char[] { 'N', 'o', 'n', 'e' };

                    int c = 0;
                    while (temp[c] != ' ')
                    {
                        c++;
                    }
                    if (temp[c] == ' ')
                    {
                        c++;
                        temp2 = new char[temp.Length - c];
                        for (int j = 0; j < temp2.Length; j++)
                        {
                            temp2[j] = temp[c];
                            c++;
                        }
                    }

                    str = new string(temp2);
                    organization.SurName = str;
                    organizations.Add(organization);
                }
            }
        }
        public  void PrintPhoneBook()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine("\nPersons");
            Console.WriteLine("_____________________");
            foreach (Person item in persons)
            {
                item.PrintInfo();
            }
            Console.WriteLine("_____________________");
            Console.WriteLine("\nFriends");
            Console.WriteLine("_____________________");
            foreach (Friend item in friends)
            {
                item.PrintInfo();
            }
            Console.WriteLine("_____________________");
            Console.WriteLine("\nOrganizations");
            Console.WriteLine("_____________________");
            foreach (Organization item in organizations)
            {
                item.PrintInfo();
            }
            Console.WriteLine("_____________________");
        }
        public  void FindBySName()
        {
            Console.WriteLine("Введите фамилию");
            string str = Console.ReadLine();
            foreach (PhoneBook item in persons.Where(w=>w.SurName==str))
            {
                item.PrintInfo();
            }
            foreach (PhoneBook item in friends.Where(w => w.SurName == str))
            {
                item.PrintInfo();
            }
            foreach (Organization item in organizations.Where(w=>w.SurName==str))
            {
                item.PrintInfo();
            }
        }
    }
}
