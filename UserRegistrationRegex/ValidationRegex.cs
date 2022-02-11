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
        public void Checkmobilenum(string Mobilenum)
        {
            string mobilenumpattern = "^[1,9]{2}-[6-9]{1}[0-9]{9}";
            if (Regex.IsMatch(Mobilenum, mobilenumpattern))
                Console.WriteLine("Mobile number is valid");
            else
                Console.WriteLine("Invalid mobile number!!");
        }
        public void Checkpassward(string Passward)
        {
            // string passwardpattern = "^[A-Za-z0-9]{8,20}$"; 
            // string passwardpattern = "^(?=.*[A-Z])(?=.*[a-z]{8,}).*$";
            //  string passwardpattern = "^(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).{8,}"; 
            // string passwardpattern = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
            string passwardpattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
            if (Regex.IsMatch(Passward, passwardpattern))
                Console.WriteLine("Passward is valid");
            else
                Console.WriteLine("Invalid passward!!");
        }
        public static string sampleEmailPattern = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static void SampleEmail()
        {
            string[] sampleEmail ={"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc-100@abc.net","abc111@abc.com","abc+100@gmail.com",
                                   "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc","abc@.com.my","abc123@gmail.a","abc123@.com",
                                   "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@gmail.com.1a",
                                   "abc@gmail.com.aa.au","abc..2002@gmail.com"};

            Console.WriteLine("Validate Sample Email Id");
            Validate(sampleEmail, sampleEmailPattern);
        }
        public static void Validate(string[] arr, string pattern)
        {
            foreach (var item in arr)
            {
                if (Regex.IsMatch(item, pattern))
                    Console.WriteLine(item + " \t\t " + "Valid Email");
                else
                    Console.WriteLine(item + " \t\t " + "InValid Email");
            }
        }

    }

       
}


