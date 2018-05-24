using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGround.Models
{
    public class CheckNumber
    {
        public static int startProcess = 0;
        public static int HiddenNumber;
        
        public static string NumberCheck(double input)
        {
            string Result;
      

            if (input >= 38)
            {
                Result = "You have a hot fever";
            }
            else if (input <= 36)
            {
                Result = "You have a cold fever";
            }
            else
            {
                Result = "You don't have a fever";
            }
            return Result;
        }
        public static string CheckRndNumber(int guess)
        {
            string guessResult = "";
            startProcess++;

            if (startProcess == 1)
            {
                Random random = new Random();
                HiddenNumber = random.Next(1, 100);
            }
            if (guess == HiddenNumber)
            {
                guessResult = "You got it right!";
                startProcess = 0;
            }
            if(guess < HiddenNumber && guess >= 0)
            {
                guessResult = "Too low.";
            }
            if(guess > HiddenNumber && guess <= 100)
            {
                guessResult = "Too High.";
            }
            if(guess <= 0 || guess >= 100)
            {
                guessResult = "Invalid value, try again";
            }
            return guessResult;
        }
    
    }
}