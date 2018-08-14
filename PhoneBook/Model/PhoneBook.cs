using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public abstract class PhoneBook
    {
        public string SurName { get; set; }
        public string Address { get; set; }
        public string TelNum { get; set; }
        public abstract void PrintInfo();
    }
}
