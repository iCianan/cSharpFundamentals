using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class Search
    {
        public string[] usernames = new[] { "john", "jeff" };
        public string[] states = new[]
        {
            "Alaska",
            "Alabama",
            "Arkansas",
            "American Samoa",
            "Arizona",
            "California",
            "Colorado",
            "Connecticut",
            "District of Columbia",
            "Delaware",
            "Florida",
            "Georgia",
            "Guam",
            "Hawaii",
            "Iowa",
            "Idaho",
            "Illinois",
            "Indiana",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Massachusetts",
            "Maryland",
            "Maine",
            "Michigan",
            "Minnesota",
            "Missouri",
            "Mississippi",
            "Montana",
            "North Carolina",
            "North Dakota",
            "Nebraska",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "Nevada",
            "New York",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Puerto Rico",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Virginia",
            "Virgin Islands",
            "Vermont",
            "Washington",
            "Wisconsin",
            "West Virginia",
            "Wyoming"
        };

        public bool IsUserNameTaken(string username)
        {
            return usernames.Contains<string>(username);
        }
        public bool IsStateValid(string username)
        {
            
            return states.Contains<string>(username);
        }
        public int BinarySearch(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;
            int mid = ((right + left) / 2);

            while (left <= right)
            {
                if (array[mid] == value)
                {
                    return mid;
                }
                else if (array[mid] > value)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;

                }
                mid = ((right + left) / 2);
            }
            return -1;
        }
    }
}
