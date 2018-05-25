using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGround.Models
{
    public class CheckNumber
    {
        public static int startProcess = 0;                 //Variabeln som håller koll på om GuessingGame ska fortsätta med samma nummer, eller skapa ett nytt nummer.
        public static int failCounter = 0;                  //Variablen som håller koll på hur många gånger spelaren har gissat med GuessingGame.
        public static int HiddenNumber;                     //Variablen som håller det gömda numret på GuessingGame.

        public static string NumberCheck(double input)      //Metoden för att kolla tempen på använderan.
        {
            string Result;                                  //Resultat som kommer få ett värde beronde på värdet som användaren inputade.

            if (input >= 38)
            {
                Result = "You have a hot fever";            //Om användaren har en temp på 38 eller högre, så skriver sidan ut att användaren har en hög feber.
            }
            else if (input <= 36)
            {
                Result = "You have a cold fever";           //Om användaren har en temp på 36 eller lägre, så skriver sidan ut att användaren har en låg feber.
            }
            else
            {
                Result = "You don't have a fever";          //Om användaren har en annan temperatur, så skriver sidan ut att användaren inte har en feber.
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