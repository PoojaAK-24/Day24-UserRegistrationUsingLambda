using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    class UserRegistrationValidation
    {

        public void validateFirstName()
        {
            string[] Regex_Array = new string[6];

            //first name 
            Regex_Array[0] = "^[A-Z][A-Za-z]{2,}$";
            //last name
            Regex_Array[1] = "^[A-Z][A-Za-z]{2,}$";
            //email id
            Regex_Array[2] = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            // Phone no
            Regex_Array[3] = "^[1-9]{2}[ ][0-9]{10}$";
            //password
            Regex_Array[4] = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$";
            //sample email id
            Regex_Array[5] = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";  

            string[] User_Input_Array = new string[6];

            Console.WriteLine("1] Enter First Name :");
            User_Input_Array[0] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("2] Enter Last Name :");
            User_Input_Array[1] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("3] Enter the Email Id : ");
            User_Input_Array[2] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("4] Enter the Phone No : ");
            User_Input_Array[3] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("5] Enter the Password : ");
            User_Input_Array[4] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("6] Enter the Sample Email Id : ");
            User_Input_Array[5] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Entered input is Valid or Not T/F : ");
            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {

                Func<string, bool> nameValidater = User_Input_Array => Regex.IsMatch(User_Input_Array, Regex_Array[i]);
                bool result = nameValidater(User_Input_Array[i]);
                Console.WriteLine((i + 1) + "] " + result);

            }
        }
    }
}

