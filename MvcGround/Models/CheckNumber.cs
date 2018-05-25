using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGround.Models
{
    public class CheckNumber
    {
        public static int startProcess = 0;
        public static int failCounter = 0;
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
        public static string CheckRndNumber(int guess)              //Metoden för att skapa ett gömt nummer, och jämför spelares nummer och det gömda nummret.
        {
            string guessResult = "";                                //Variabeln som skriver ut resultatet, och variabeln som bestämmer om spelet ska börja om.
            startProcess++;

            if (startProcess == 1)                                  //När spelaren skriver in ett nummer, så skapar metoden ett gömt nummer emellan 1 och 100
            {                                                       //och det nummret är kvar tills man har klarat spelet, då skapas ett nytt hemligt nummer.
                Random random = new Random();
                HiddenNumber = random.Next(1, 101);
            }
            if (guess == HiddenNumber)                              //Om spelaren gissar rätt, så står det "You got it right!" och räknaren som håller koll på hur
            {                                                       //många gånger spelarens har försökt start om, och om spelaren skriver in ett nytt nummer,
                guessResult = "You got it right!";                  //så startar spelet på nytt
                startProcess = 0;
                failCounter = 0;
            }
            if (guess < HiddenNumber && guess >= 0)                  //Om spelaren gissar för lågt, så står det "Too low", och räknaren som håller koll på hur många 
            {                                                       //gånger spelaren har försökt ökar med 1.
                guessResult = "Too low.";
                failCounter++;
            }
            if (guess > HiddenNumber && guess <= 100)                //Om spelaren gissar för högt, så står det "Too high", och räknaren som håller koll på hur många 
            {                                                       //gånger spelaren har försökt ökar med 1.
                    guessResult = "Too High.";
                    failCounter++;
            }
            if (guess <= 0 || guess >= 100)                          //Om spelaren skriver ett ogiltigt nummer, så står det "Invalid value, try again".
            {
            guessResult = "Invalid value, try again";
            }
            return guessResult;
            }

        
    }
}