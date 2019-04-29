using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class Game
  {
    static void Main()
    {

      string inputPlayer;
      string inputCPU;
      int randomInt;

      bool playAgain = true;

      while(playAgain)
      {

        int playerScore = 0;
        int scoreCPU = 0;

        while(playerScore < 3 && scoreCPU < 3)
        {

          Console.WriteLine("Choose between ROCK, PAPER and SCISSORS: ");
          inputPlayer = Console.ReadLine();
          Console.WriteLine("--------------");
          inputPlayer = inputPlayer.ToUpper();

          Random random = new Random();
          randomInt = random.Next(1,4);

          switch (randomInt)
          {
            case 1:

            inputCPU = "ROCK";

            Console.WriteLine("Computer chose ROCK");
            if (inputPlayer == "ROCK")
            {
              Console.WriteLine("DRAW!");
            }
            else if (inputPlayer == "PAPER")
            {
              Console.WriteLine("PLAYER WINS!");
              playerScore++;
            }
            else if (inputPlayer == "SCISSORS")
            {
              Console.WriteLine("DUN DUN DUN.. Computer scores..");
              scoreCPU++;
            }
            break;

            case 2:

            inputCPU = "PAPER";

            Console.WriteLine("Computer chose PAPER");
            if (inputPlayer == "PAPER")
            {
              Console.WriteLine("DRAW!");
            }
            else if (inputPlayer == "ROCK")
            {
              Console.WriteLine("DUN DUN DUN.. Computer scores..");
              scoreCPU++;
            }
            else if (inputPlayer == "SCISSORS")
            {
              Console.WriteLine("PLAYER WINS!!!");
              playerScore++;
            }
            break;

            case 3:

            inputCPU = "SCISSORS";

            Console.WriteLine("Computer chose SCISSORS");
            if (inputPlayer == "SCISSORS")
            {
              Console.WriteLine("DRAW!");
            }
            else if (inputPlayer == "ROCK")
            {
              Console.WriteLine("PLAYER WINS!!!");
              playerScore++;
            }
            else if (inputPlayer == "PAPER")
            {
              Console.WriteLine("DUN DUN DUN.. Computer scores..");
              scoreCPU++;
            }
            break;

          //Not working
          default:

            Console.WriteLine("Invalid entry!");
            break;
          }

          Console.WriteLine("Player Score: \t{0}\tComputer:\t{1}", playerScore, scoreCPU);

        }

        if (playerScore == 3)
        {
          Console.WriteLine("AYYYYY YOU WON PLAYA!");
        }
        else if (scoreCPU == 3)
        {
          Console.WriteLine("COMPUTER WON..next time fam");
        }
        else
        {

        }

        Console.WriteLine("Do you want to play again? [Y]es [N]o");
        string loop = Console.ReadLine().ToUpper();
        if (loop == "Y")
        {
          playAgain = true;
          Console.Clear();
        }
        else if (loop == "N")
        {
          playAgain = false;
          Console.WriteLine("Bye bye!");
        }
        else
        {

        }
      }

    }
  }
}
