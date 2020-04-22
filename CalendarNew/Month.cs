using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    public class Month
    {

        public string ReturnDate(int day, int year)
        {
            int monthNumber = ReturnNumberOfMonth(day, year);
            string monthStr = ReturnMonth(monthNumber);
            int dayOfMonth = ReturnDay(monthNumber, day, year);
            return dayOfMonth + " " + monthStr;
        }

        public int ReturnNumberOfMonth(int day, int year)
        {
            //31, 59, 90, 120, 151, 180, 211, 242,273, 304, 334, 365
            //31, 28, 31, 30, 31, 30, 31, 31, 30, 31 ,30, 31

            Dictionary<int, int> months = new Dictionary<int, int>
            {
                { 1, 31},
                { 2, 59},
                { 3, 90},
                { 4, 120},
                { 5, 151},
                { 6, 180},
                { 7, 211},
                { 8, 242},
                { 9, 273},
                { 10, 304},
                { 11, 334},
                { 12, 365}
            };

            if (LeapYear(year))
            {
                for (int i = 2; i < 13; i++)
                {
                    months[i]++;
                }
            }

            for (int i = 1; i < 13; i++)
            {
                if (day <= months[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public string ReturnMonth(int numberOfMonth)
        {
            Dictionary<int, string> month = new Dictionary<int, string>();
            month.Add(1, "January");
            month.Add(2, "February");
            month.Add(3, "March");
            month.Add(4, "April");
            month.Add(5, "May");
            month.Add(6, "June");
            month.Add(7, "July");
            month.Add(8, "August");
            month.Add(9, "September");
            month.Add(10, "October");
            month.Add(11, "November");
            month.Add(12, "December");

            return month[numberOfMonth];
        }

        public int ReturnDay(int monthNumber, int day, int year)
        {
            Dictionary<int, int> months = new Dictionary<int, int>
            {
                { 1, 31},
                { 2, 59},
                { 3, 90},
                { 4, 120},
                { 5, 151},
                { 6, 180},
                { 7, 211},
                { 8, 242},
                { 9, 273},
                { 10, 304},
                { 11, 334},
                { 12, 365}
            };

            if (LeapYear(year))
            {
                for (int i = 2; i < 13; i++)
                {
                    months[i]++;
                }
            }

            return (monthNumber != 1) ? day - months[monthNumber - 1] : day;
        }

        private bool LeapYear(int year)
        {
            if (year % 4 != 0) return false;
            else
            if (year % 100 == 0 && year % 400 != 0) return false;
            else return true;
        }
    }
}
