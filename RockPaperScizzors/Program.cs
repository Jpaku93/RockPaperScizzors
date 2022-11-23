using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;
            
            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;
                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Choose ROCK PAPER SCISSORS:");
                    inputPlayer = Console.ReadLine();
                    // change inputplayer to upper case
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);


                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("CPU: " + inputCPU);
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("YOU WIN");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("YOU LOSE");
                                scoreCPU++;
                            }

                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("CPU: " + inputCPU);
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("YOU LOSE");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("YOU WIN");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("CPU: " + inputCPU);
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("YOU WIN");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("YOU LOSE");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW");
                            }
                            break;
                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }
                    // write the scores
                    Console.WriteLine("\n\nScores: \tPLAYER:\t{0}\tCPU: \t{1}", scorePlayer, scoreCPU);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("YOU WIN");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("YOU LOSE");
                }
                // ask to play again
                Console.WriteLine("Play again? (Y/N)");
                string loop = Console.ReadLine();
                // convert 
                loop = loop.ToUpper();
                if (loop == "Y")
                {
                    Console.Clear();
                    playAgain = true;
                }
                else if (loop == "N")
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing!");
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }
    }
}