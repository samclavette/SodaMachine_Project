﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class UserInterface
    {
        public static string ChooseSodaCan()
        {
            string userInput = "";

            while (!userInput.Equals("cola") && !userInput.Equals("orange soda") && !userInput.Equals("root beer"))
            {
                Console.WriteLine("Please choose a soda:\ncola\norange soda\nroot beer");
                userInput = Console.ReadLine();     
            }
            return userInput;

        }

        public static string ChooseCoinPayment()
        {
            string userInput = "";

            while (!userInput.Equals("quarter") && !userInput.Equals("dime") && !userInput.Equals("nickel") && !userInput.Equals("penny"))
            {
                Console.WriteLine("Please choose coin to enter:\nquarter\ndime\nnickel\npenny");
                userInput = Console.ReadLine();
            }

            return userInput;
        } 

        
    }
}
