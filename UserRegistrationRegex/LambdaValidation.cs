using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationexRefAnn
{
    internal class LambdaValidation
    {
        //Method to Validate FirstName Using Lambda.
        public static void ValidateFirstName()
        {
            Console.WriteLine("Valid First Name");
            string pattern = "^[A-Z]{1}[a-z]{3,10}";
            List<string> firstName = new List<string>() { "Sourabh", "Karan", "Abhi", "Prafull" };
            Regex regex = new Regex(pattern);
            //Using Lambda expression validating FirstName with pattern.
            var list = firstName.Select(str => regex.Match(str).Value).ToList();
            foreach (var item in list)
            {
                //skip index having null.
                if (item != "")
                    Console.WriteLine(item);
            }
        }
        //Method to Validate LastName Using Lambda.
        public static void ValidateLastName()
        {
            Console.WriteLine("\nValid Last Name");
            string pattern = "^[A-Z]{1}[a-z]{3,10}";
            List<string> firstName = new List<string>() { "Powar", "Nulle", "Jangam", "Patil" };
            Regex regex = new Regex(pattern);
            //Using Lambda expression validating LastName with pattern.
            var list = firstName.Select(str => regex.Match(str).Value).ToList();
            foreach (var item in list)
            {
                //skip index having null.
                if (item != "")
                    Console.WriteLine(item);
            }
        }
        //Method to Validate Mobile Number Using Lambda.
        public static void ValidateMobileNumber()
        {
            Console.WriteLine("\nValid Mobile Number");
            string pattern = "^([9][1])[ ]*[6-9]{1}[0-9]{9}$";
            List<string> firstName = new List<string>() { "9546672135", "7846125349", "8745616478" };
            Regex regex = new Regex(pattern);
            //Using Lambda expression validating Mobile number with pattern.
            var list = firstName.Select(str => regex.Match(str).Value).ToList();
            foreach (var item in list)
            {
                //skip index having null.
                if (item != "")
                    Console.WriteLine(item);
            }
        }
        //Method to Validate Email Using Lambda.
        public static void ValidateEmail()
        {
            Console.WriteLine("\nValid Email");
            string pattern = "^[a-zA-z]{3}([.]*[a-zA-Z])+[@]([a-z]{3,})+([.][a-z]{2,3})*$";
            List<string> firstName = new List<string>() { "Sp@gmail.co.in", "kk@gmail.com", ".abhi@gmail.com", "pj@gmail.com" };
            Regex regex = new Regex(pattern);
            //Using Lambda expression validating Email with pattern.
            var list = firstName.Select(str => regex.Match(str).Value).ToList();
            foreach (var item in list)
            {
                //skip index having null.
                if (item != "")
                    Console.WriteLine(item);
            }
        }
    }
}
