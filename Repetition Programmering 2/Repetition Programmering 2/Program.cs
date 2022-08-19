using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Programmering_2
{
    class Program
    {
        //Variables
        static private int UserInput_Number;
        static private float UserInput_DecimalNumber;
        static private string UserInput_Word;

        static void Main(string[] args)
        {
            #region Assignment 1

            //Heltal
            Console.Write("Please enter a number without decimals into the console");
            Console.WriteLine();
            string numberUserInput = Console.ReadLine();
            int.TryParse(numberUserInput, out UserInput_Number);

            if (!int.TryParse(numberUserInput, out UserInput_Number))
            {
                Console.WriteLine("Sorry, do better. PLEASE!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Great! Let's move on to the decimal number. Press a button");
                Console.ReadKey();
                Console.Clear();
            }

            //Decimaltal
            Console.Write("Now, go ahead and enter a decimal in the console");
            Console.WriteLine();
            string decimalNumberUserInput = Console.ReadLine();
            float.TryParse(decimalNumberUserInput, out UserInput_DecimalNumber);

            if (!float.TryParse(decimalNumberUserInput, out UserInput_DecimalNumber))
            {
                Console.WriteLine("Step up your game, just step up!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Congrats on entering a float in the console! Press to continue to " +
                    "enter a word into the console");
                Console.ReadKey();
                Console.Clear();
            }

            //Word

            Console.Write("Please enter a random word!");
            string wordUserInput = Console.ReadLine();
            Console.WriteLine();

            //Results
            Console.Clear();

            //Result 1
            Console.Write("Result 1");
            Console.WriteLine(UserInput_Number / UserInput_DecimalNumber);

            //Result 2
            Console.WriteLine("Result 2");
            Console.WriteLine(UserInput_DecimalNumber / UserInput_Number);

            //Result 3
            Console.WriteLine("Result 3");
            Console.WriteLine(wordUserInput.ToUpper());

            //Result 4
            Console.WriteLine("Result 4");
            Console.WriteLine(wordUserInput.ToLower());

            //Result 5
            Console.Write("Result 5");
            if (wordUserInput.Contains("apple"))
            {
                Console.WriteLine("The word contains the term apple");
            }
            else
            {
                Console.WriteLine("The word doesn't contain the term apple");
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to move on to the next assignment");
            Console.ReadKey();
            #endregion


            //Assignment 2 

        }
    }
}