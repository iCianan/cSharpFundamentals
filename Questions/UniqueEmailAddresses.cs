using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class UniqueEmailAddresses
    {
        public static int NumberOfUniqueEmails(string[] emailAddresses)
        {
            // create a results string array
            var results = new HashSet<string>();
            // create an seperator array
            var seperator = new HashSet<char>() { '.', '+', '@'};
            // loop through email array
            for (int i = 0; i < emailAddresses.Length; i++)
            {   
                //create stringbuilder
                StringBuilder sb = new StringBuilder();
                // loop through the email string
                for (int j = 0; j < emailAddresses[i].Length; j++)
                {
              
                    // if char isnt in seperator set add to stringbuilder
                    if (!seperator.Contains(emailAddresses[i][j]))
                    {
                        sb.Append(emailAddresses[i][j]);
                    }
                    // if a plus sign is found find the @ index and retrive the string starting from it to the end of string
                    //add string to sb and add sb to results array and get out of loop

                    if (emailAddresses[i][j] == '+' || emailAddresses[i][j] == '@')
                    {
                        var index = emailAddresses[i].LastIndexOf('@');
                        var domain = emailAddresses[i].Substring(index);
                        sb.Append(domain);
                        results.Add(sb.ToString());
                        break;
                    }
                    

                }
                
            }

            return results.Count;
        }
        
    }
}
