using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Arrays
    {
        public string[] Days { get; set; } 
        public string[] Months { get; set; } 
        public Arrays()
        {
            Days = new string[] {
                "Monday",
                "Tuesday",
                "Wenesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            Months = new string[] {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "June",
                "July",
                "Aug",
                "Sept",
                "Oct",
                "Nov",
                "Dec"
            };

        }
        public void ListDaysInOrder()
        {
            foreach (string day in Days)
            {
                Console.WriteLine(day);
            }
        }
        public void ReplaceAllDaysWithMonths()
        {

            for (int i = 0; i< Days.Length; i++)
            {
     
                Days[i] = Months[i];
                Console.WriteLine(Days[i]);
            }
        }

    }
}
