using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using UserRegistrationexRefAnn;

namespace UserRegistrationRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user Registration");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Program number to get executed \n1. Validate first name \n2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter First name :");
                        string fname = Console.ReadLine();
                        ValidationRegex Checkpattern = new ValidationRegex();
                        Checkpattern.Checkfirstname(fname);
                        break;
                    case 2:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter Last name :");
                        string lname = Console.ReadLine();
                        ValidationRegex lnamepattern = new ValidationRegex();
                        lnamepattern.Checklastname(lname);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email id :");
                        string email = Console.ReadLine();
                        ValidationRegex emailpattern = new ValidationRegex();
                        emailpattern.Checkemail(email);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile No. :");
                        string mobilenum = Console.ReadLine();
                        ValidationRegex mobilenumpattern = new ValidationRegex();
                        mobilenumpattern.Checkmobilenum(mobilenum);
                        break;
                    case 5:
                        Console.WriteLine("Enter Passward :");
                        string passward = Console.ReadLine();
                        ValidationRegex passwardruleone = new ValidationRegex();
                        passwardruleone.Checkpassward(passward);
                        break;
                    case 6:
                        ValidationRegex.SampleEmail();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }


                Console.ReadKey();
            }


        }
        //Method to perform LambdaValidation
        public static void LambdaValidate()
        {
            LambdaValidation.ValidateFirstName();
            LambdaValidation.ValidateLastName();
            LambdaValidation.ValidateMobileNumber();
            LambdaValidation.ValidateEmail();
        }

    }
}
