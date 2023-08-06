using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Programs.UniqueEmail
{
    public class UniqueEmailAddress
    {
        //Given a list of email addresses, return the number of unique email addresses after applying specific email rules
        //(e.g., ignoring dots and everything after the plus sign).

        public static int CountUniqueEmails(List<string> emails)
        {
            HashSet<string> uniqueEmails = new HashSet<string>();

            foreach (string email in emails)
            {
                string transformedEmail = TransformEmail(email);
                uniqueEmails.Add(transformedEmail);
            }

            return uniqueEmails.Count;
        }

        public static string TransformEmail(string email)
        {
            int atIndex = email.IndexOf('@');
            string localPart = email.Substring(0, atIndex);
            string domainPart = email.Substring(atIndex);

            // Remove dots in the local part
            localPart = localPart.Replace(".", "");

            // Remove everything after the plus sign (if present) in the local part
            int plusIndex = localPart.IndexOf('+');
            if (plusIndex != -1)
            {
                localPart = localPart.Substring(0, plusIndex);
            }

            return localPart + domainPart;
        }

        public static void Main()
        {
            List<string> emails = new List<string>
        {
            "test.email+alex@leetcode.com",
            "test.e.mail+bob.cathy@leetcode.com",
            "testemail+david@lee.tcode.com",
            "abcd.efgh@leetcode.com"
        };

            int uniqueCount = CountUniqueEmails(emails);
            Console.WriteLine("Number of unique email addresses: " + uniqueCount);
        }
    }
}
