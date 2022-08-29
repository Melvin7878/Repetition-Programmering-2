using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Programmering_2
{
    class Program
    {
        ////Argument 1 variables
        static private int UserInput_Number;
        static private float UserInput_DecimalNumber;

        ////Assignment 2 variables
        static int playerCash = 1000;

        static void Main(string[] args)
        {
            Console.Write("Menu:");
            Console.WriteLine();
            Console.WriteLine("Enter either the number 1 or 2 to enter the repsective game");
            string userGameChoiceInput = Console.ReadLine();
            int userGameChoiceNumber;

            if (int.TryParse(userGameChoiceInput, out userGameChoiceNumber) && userGameChoiceNumber == 1)
            {
                Console.Clear();
                #region Assignment 1
                Console.Write("Welcome to the first assignment (game)!");
                Console.WriteLine();
                Console.WriteLine("Press to enter the assignment");
                Console.ReadKey();
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
                Console.WriteLine();
                string wordUserInput = Console.ReadLine();
                Console.WriteLine();

                ////Results
                Console.Clear();

                //Result 1
                Console.Write("Result 1:");
                Console.WriteLine();
                Console.WriteLine(UserInput_Number / UserInput_DecimalNumber);

                //Result 2
                Console.WriteLine();
                Console.WriteLine("Result 2");
                Console.WriteLine(UserInput_DecimalNumber / UserInput_Number);

                //Result 3
                Console.WriteLine();
                Console.WriteLine("Result 3");
                Console.WriteLine(wordUserInput.ToUpper());

                //Result 4
                Console.WriteLine();
                Console.WriteLine("Result 4");
                Console.WriteLine(wordUserInput.ToLower());

                //Result 5
                Console.WriteLine();
                Console.Write("Result 5");
                Console.WriteLine();

                if (wordUserInput.Contains("apple"))
                {
                    Console.Write("The word contains the term apple");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The word doesn't contain the term apple");
                }

                //Proceedings to the next assignemnt
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press a button to continue to the next assignment");
                Console.ReadKey();
                Console.Clear();
                #endregion
            }

            if (int.TryParse(userGameChoiceInput, out userGameChoiceNumber) && userGameChoiceNumber == 2)
            {
                Console.Clear();
                #region Assignment 2
                bool roulette = true;


                Console.Write("Welcome to the casino!, press to enter the casino");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();

                //Conditions
                //player has a certain amount of start cash
                //upon win the player will recieve double their stakes.
                //the player shall have the choice to leave a game at any time.
                //when the playerCash is empty, close the game.
                //player can close game whenever they want

                ////Choose game
                Console.Write("Now it's up to you to choose what game YOU want to play!" +
                    "" +
                    "Please enter the name on one of the possible games availabe: \n Roulette, Cards and Pairs");
                Console.WriteLine();

                string casinoChoice = Console.ReadLine();
                string rouletteChoice = "Roulette";
                string cardsChoice = "Cards";
                string pairChoice = "Pair";

                //Exit
                //if (casinoChoice == (char) 27)                          // CHECK THIS!!!!!!!!!!!!!!!!!!
                //{

                //}

                ////Games

                //Roulette
                if (casinoChoice == rouletteChoice)
                {
                    Roulette();
                }
            }


            //Cards

            //Pair


            Console.ReadKey();
            #endregion
        }

        static public void Roulette()
        {
            Console.Clear();
            Console.Write("Welcome to roulette! Place your bets, then please enter a number between 0 and 100 at first, then a color" +
                "between red and black. Press a button to move on");
            Console.ReadKey();
            Console.Clear();

            //Position the player cash
            Console.SetCursorPosition(90, 90);
            playerCash = playerCash;
            Console.WriteLine();

            //Place bets
            Console.SetCursorPosition(0, 0);
            string placingBet = Console.ReadLine();
            int playerBet;

            if (int.TryParse(placingBet, out playerBet) && playerBet <= playerCash)
            {
                playerCash = playerCash - playerBet;
            }
            else if (!int.TryParse(placingBet, out playerBet) && playerBet <= playerCash)
            {
                Console.WriteLine("Come on!, Retry");
                Console.ReadKey();
                return;
            }

            //Generate the random number and thereby the color
            Random randomRouletteNumber = new Random();
            int rouletteNumber = randomRouletteNumber.Next(0, 101);
            string rouletteColor;

            bool isRed = false;
            bool isBlack = false;
            if (rouletteNumber % 2 == 0)
            {
                isRed = true;
                rouletteColor = "red";
            }
            else
            {
                isBlack = true;
                rouletteColor = "black";
            }


            //Guess number 
            Console.Write("Guess the number mate, or press n to move on to guess the color");
            Console.WriteLine();
            string userRouletteNumberGuess = Console.ReadLine();
            int userRouletteNumber;

            if (int.TryParse(userRouletteNumberGuess, out userRouletteNumber) && userRouletteNumber == rouletteNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number, now guess the color");

                //Add gain in cash
                playerCash = playerBet * 2;

                //Exit
                Console.WriteLine("Press a button to go back to the menu!");
                Console.ReadKey();
                return;
            }
            else if (int.TryParse(userRouletteNumberGuess, out userRouletteNumber) && userRouletteNumber != rouletteNumber)
            {
                Console.WriteLine("I know it's hard to get a number right. Take pride in that you actually could input a number" +
                    "dear kindered.");
            }
            else if (userRouletteNumberGuess.ToLower() == "n")
            {
                Console.WriteLine("Move on to the color guessing by oressing a key once");
                Console.ReadKey();
            }



            //Guess the color
            Console.WriteLine();
            Console.WriteLine("Guess the color oi oi");

            string userRouletteColorGuess = Console.ReadLine();

            if (isRed && userRouletteColorGuess.ToLower() == "red")
            {
                Console.WriteLine("You guessed it! The color was: " + rouletteColor + "| The number was: " + rouletteNumber);

                //Add gain in cash
                playerCash = playerBet * 2;

                //Exit
                Console.WriteLine();
                Console.WriteLine("Press to go back to the menu!");
                Console.ReadKey();
                return;
            }
            else if (isBlack && userRouletteColorGuess.ToLower() == "black")
            {
                Console.WriteLine("You guessed the color right! The color was: " + rouletteColor + "| The number was: " + rouletteNumber);

                //Add gain in cash
                playerCash = playerBet * 2;
                
                //Exit
                Console.WriteLine("Press to go back to the casino menu!");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("The color was: " + rouletteColor + "| The number was: " + rouletteNumber);
            }
        }
    }
}