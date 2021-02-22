using System;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] highScores = {"LENA 100000", "MICKE 23004", "MARTIN 2000"};
            int result = 0;

            for (int i = 0; i < highScores.Length; i++)
            {
                string scoreMessage = highScores[i].Replace(" ", " har ");
                Console.WriteLine(scoreMessage + " poäng.");
            }

            for (int i = 0; i < highScores.Length; i++)
            {
                string[] splitted = highScores[i].Split(' ');

                for (int j = 0; j < splitted.Length; j++)
                {
                   if (j % 2 == 1)
                   {
                        result += int.Parse(splitted[j]);
                   }
                }
            }
            Console.WriteLine("Medelvärdet av poängen är " + result/highScores.Length);

            Console.ReadLine();
        }
    }
}
