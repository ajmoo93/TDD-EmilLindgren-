using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationEngine
{
    public class EmailValidator
    {
        
        static void Main(string[] args)
        {
           
        }
        private string Email = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public bool ValidateEmailAddress(string address)
        {

            if (string.IsNullOrEmpty(address))
            {
                return false;
            }
            var Match = Regex.IsMatch(address, Email);
            return Match;
        }


    }
        
    }
