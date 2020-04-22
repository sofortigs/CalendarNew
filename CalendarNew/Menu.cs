using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    public class Menu
    {
        public void InputDay()
        {
            Console.WriteLine("Input day of year");
        }

        public void InputYear()
        {
            Console.WriteLine("Input year");
        }

        public int ReadDay()
        {
            int day = Convert.ToInt32(Console.ReadLine());
            if (day < 1 || day > 366)
                throw new IndexOutOfRangeException("You entered invalid value");
            else return day;
        }

        public int ReadYear()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
