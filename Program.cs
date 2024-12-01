using System;


namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;
            int playerPoints = 0;
            int computerPoints = 0;
            int rounds = 0;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {

                    Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine().ToUpper();
                }
                

                switch (random.Next(1,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player chose: " + player);
                Console.WriteLine("Computer chose: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Draw");
                            rounds++;
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Lose");
                            computerPoints++;
                            rounds++;
                        }
                        else
                        {
                            Console.WriteLine("Win");
                            playerPoints++;
                            rounds++;
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Win");
                            playerPoints++;
                            rounds++;
                        }
                        else if(computer == "PAPER")
                        {
                            Console.WriteLine("Draw");
                            rounds++;
                        }
                        else
                        {
                            Console.WriteLine("Lose");
                            computerPoints++;
                            rounds++;
                            
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "Rock")
                        {
                            Console.WriteLine("Lose");
                            computerPoints++;
                            rounds++;
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Win");
                            playerPoints++;
                            rounds++;
                        }
                        else
                        {
                            Console.WriteLine("Draw");
                            rounds++;
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again? (y/n)");
                answer = Console.ReadLine().ToUpper();

                if (answer == "Y" || answer == "YES")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                } 
            }
            Console.WriteLine("Thanks for playing");
            Console.WriteLine($"You have played {rounds} round(s). The Computer has {computerPoints} point(s) and the player has {playerPoints} point(s)");   
        }
    }
}
