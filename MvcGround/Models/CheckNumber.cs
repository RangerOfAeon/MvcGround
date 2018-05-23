using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGround.Models
{
    public class CheckNumber
    {
        public static string NumberCheck(double input)
        {
            string Result;

            if(input >= 38)
            {
                Result = "You have a hot fever";
            }
            else if(input <= 36)
            {
                Result = "You have a cold fever";
            }
            else
            {
                Result = "You don't have a fever";
            }
            return Result;
        }
    }
}