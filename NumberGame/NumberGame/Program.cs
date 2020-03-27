using System;

namespace NumberGame
{
    class Program
    {
        public static int selectedNumber = 0;
        public static Random random = new Random();
        public static bool gameOver = false;
        static void Main(string[] args)
        {
            selectedNumber = random.Next(1, 101);
            int userNumber = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 100");
                userNumber = Convert.ToInt32(Console.ReadLine());
                guessNumber(userNumber);
            }
            while (gameOver == false);
        }
        public static void guessNumber(int userNumber)
        {
            int playAgain = 0;

            if (userNumber < selectedNumber)
                Console.WriteLine("Too low");
            else if (userNumber > selectedNumber)
                Console.WriteLine("Too high");
            else
            {
                Console.WriteLine("You win! Press 1 to play again or 2 to quit");
                playAgain = Convert.ToInt32(Console.ReadLine());

                while (playAgain != 1 && playAgain != 2)
                {
                    Console.WriteLine("Please selected 1 to play again or 2 to quit");
                    playAgain = Convert.ToInt32(Console.ReadLine());
                }
                if (playAgain.Equals(2))
                    gameOver = true;
                else
                    selectedNumber = random.Next(1, 101);
            }
        }
    }
}
