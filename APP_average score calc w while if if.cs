using System;

namespace Challenge_Loops1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string individualScore = "0";
            int scoreCount = 0;
            int totalScore = 0;
            int individualScoreIntoInt = 0;

            while (individualScore != "-1")
            {
                Console.WriteLine($"Last number was {individualScoreIntoInt}");
                Console.WriteLine("Please enter the next score");
                Console.WriteLine($"Current amount of entries: {scoreCount}");
                Console.WriteLine("Enter '-1' when you're ready to calculaate the average");

                individualScore = Console.ReadLine();

                if (individualScore.Equals("-1"))
                {
                    Console.WriteLine("--------------------------------------------");
                    double averageScore = (double)totalScore / (double)scoreCount;
                    Console.WriteLine($"The average total score is {averageScore}");

                    if (int.TryParse(individualScore, out individualScoreIntoInt) && individualScoreIntoInt > 0 && individualScoreIntoInt < 21)
                    {
                        totalScore += individualScoreIntoInt;
                        //longer way: totalScore = individualScoreIntoInt + totalScore;
                    }
                    else if (individualScoreIntoInt < 0 || individualScoreIntoInt < 20)
                    {
                        Console.WriteLine("Enter a score > 0 and < 21");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Please only enter numbers");
                    }

                }

                scoreCount++; // adding the individualscore entered to the count. writing it here so that it's only
                //added to the count if it meets the requirements

            }
        }
    }
}
