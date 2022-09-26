using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        const string Rock = "Rock";
        const string Paper = "Paper";
        const string Scissors = "Scissors";
        static void Main(string[] args)
        {
            int playerScore = 0;
                int computerScore = 0;
            start:
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.Write("Choose [r]ock [p]aper [s]cissors: ");
         string playerMove = Console.ReadLine();
         if (playerMove == "r" || playerMove == "rock")
         {
             playerMove = Rock;
         }
         else if (playerMove == "p" || playerMove == "paper")
         {
             playerMove = Paper;
         }
         else if (playerMove == "s" || playerMove == "scissors")
         {
             playerMove = Scissors;
         }
         else
         {
             Console.ForegroundColor = ConsoleColor.Cyan;
             Console.WriteLine("Invalid Input. Try Again...");
             return;
         }
         Random random = new Random();
         int computerRandomNumber = random.Next(1, 4);
         string computerMove = "";
         switch (computerRandomNumber)
         {
             case 1:
                 computerMove = Rock;
                 break;
             case 2:
                 computerMove = Paper;
                 break;
             case 3:
                 computerMove = Scissors;
                 break;
         }
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine($"The computer choose {computerMove}.");
         if ((playerMove == Rock && computerMove == Scissors) ||
             (playerMove == Paper && computerMove == Rock) ||
             (playerMove == Scissors && computerMove == Paper))
         {
             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("You win");
                playerScore++;
         }
         else if ((playerMove == Rock && computerMove == Paper) ||
             (playerMove == Paper && computerMove == Scissors) ||
             (playerMove == Scissors && computerMove == Rock))
         {
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("You lose");
                computerScore++;
         }
         else
         {
             Console.ForegroundColor = ConsoleColor.DarkYellow;
             Console.WriteLine("This game was draw.");
         }
            Console.WriteLine($"Player score: {playerScore} Computer score: {computerScore}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
         Console.WriteLine($"Type [yes] to Play Again or [no] to quit");
        check:
            string continuingTHegame = Console.ReadLine();
            if (continuingTHegame=="yes")
            {
                goto start;
            }
            else if(continuingTHegame=="no")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Thank you for playing!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Player score: {playerScore} Computer score: {computerScore}");
            }
            else
            {
                Console.WriteLine("Wrong answer!Yes or no");
                goto check;
            }
            }
        }
    }

