using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatchingDemo
{
    class Pattern
    {
        //aaaaaa, sdfg45// pincode -> 6digi , 234 678   345654 [ ]
        //string Regex_Pincode="^[1-9][0-9]{2}[ ]?[0-9]{3}$";
        // string Regex_Pincode = "^[a-z0-9A-Z]+[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}$";
        //string Regex_Pincode = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        // string Regex_Pincode = " ^[0-9]{0,}[a-zA-Z]{3,}[a-zA-Z0-9]*$";
        // string Regex_Pincode = "^[1-9][0-9]{5}$";

        //=================++++++++++++++++++++========================++++++++++++++++++++++++++++========================++++++++++++++++


        // string Regex_Pincode = "^[1-9]{1}[0-9]{5}$";
        // string Regex_Name = "^[A-Z]{1}[a-z]{2,}[ ]{1}[A-Z]{1}[a-z]{2,}$";
        //string Regex_Phone = "^[1-9]{2}[ ][1-9]{1}[0-9]{9}$"
        // string Regex_Email = "^[a-z0-9A-Z]+([.#@_][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";
        //string Regex_Email = "^[a-z0-9A-Z]+([.#@_][a-zA-Z0-9]+)?[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";
        string Regex_Email = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@!#]*)[a-zA-Z0-9@!#*]{8,}";

        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
    }
}


