using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playerHighscore
{
    class Program
    {
        static string highscorePlayer;
        static int highscore;

        static void Main(string[] args)
        {
            int score;
            string playerName;

            // Insert the actual Highscore;
            Console.WriteLine("Highscore:");
            highscore = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Highscore Name:");
            highscorePlayer = Console.ReadLine();

            // Insert your personal Score;
            Console.WriteLine("Please, enter your score:");
            score = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter your name:");
            playerName = Console.ReadLine();

            checkHighscore(score, playerName);
            Console.Read();

        }

        static void checkHighscore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscorePlayer = playerName;
                highscore = score;

                Console.WriteLine("New highscore is " + highscore + ".");
                Console.WriteLine("New highscore holder is " + highscorePlayer + ".");
            } else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer + ".");
            }

        }
    }
}
