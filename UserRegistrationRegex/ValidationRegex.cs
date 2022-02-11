using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistrationRegex
{
    internal class ValidationRegex
    {
        public void Checkfirstname(string firstname)
        {
            string Firstnamepattern = "^[A-Z][a-z]{3,10}$";
            if (Regex.IsMatch(firstname, Firstnamepattern))
                Console.WriteLine("First Name is valid");
            else
                Console.WriteLine("Invalid name!!");
        }
        public void Checklastname(string Lastname)
        {
            string lastnamepattern = "^[A-Z][a-z]{3,10}$";
            if (Regex.IsMatch(Lastname, lastnamepattern))
                Console.WriteLine("Last Name is valid");
            else
                Console.WriteLine("Invalid name!!");
        }
        public void Checkemail(string Emailid)
        {
            string emailpattern = "^[a-z][a-zA-Z0-9._-]{3,20}@[a-z]{3,10}.(com)$";
            if (Regex.IsMatch(Emailid, emailpattern))
                Console.WriteLine("Email id is valid");
            else
                Console.WriteLine("Invalid name!!");
        }

    }
}


