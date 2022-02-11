using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }

                Console.ReadKey();
            }
        }

    }
}
