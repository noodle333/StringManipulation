using System;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] highScores = {"LENA 100000", "MICKE 23004", "MARTIN 2000"};
            int result = 0;
            int userPoint = 0;

            Console.WriteLine("Skriv in ett användarnamn.");
            string userName = Console.ReadLine().ToUpper();
            while (userPoint <= 0)
            {
                Console.WriteLine("Hej, " + userName + ". Skriv in ett positivt tal som representerar dina poäng.");
                int.TryParse(Console.ReadLine(), out userPoint);
                if(userPoint <= 0)
                {
                    Console.WriteLine("Inkorrekt input, skriv in ett positivt tal.");
                }
            }

            for (int i = 0; i < highScores.Length; i++)
            {
                if (highScores[i] == "MARTIN 2000")
                {
                    userName = userName + " " + userPoint;
                    highScores[i] = userName;
                }
            }
            
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
