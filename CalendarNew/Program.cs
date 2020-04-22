using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            Month month = new Month();
            while (true)
            {
                menu.InputYear();
                int year = menu.ReadYear();
                menu.InputDay();
                int day = menu.ReadDay();
                Console.WriteLine(month.ReturnDate(day, year));
            }
            
        }
    }
}