using System;

namespace Number_guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int guess = 0;
            string guessAnumber = "Try find a number from 1 to 100";
            int num = rand.Next(1, 100);
            Console.WriteLine(guessAnumber);

            int i = 0;
            while (guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > num)
                    {
                        Console.WriteLine("To big");
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Too small");
                    }
                }
                catch
                {
                    Console.WriteLine("Guess must be a number");
                    i--;
                }
                i++;
            }
            Console.WriteLine("Good job, " + i + " KURWA MAĆ");


        }
    }
}
