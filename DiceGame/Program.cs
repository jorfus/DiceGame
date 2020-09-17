using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceWriter diceWrite = new DiceWriter();
            Random rand = new Random();
            int[] randInts = new int[20];
            
            while (true)
            {
                for (int i = 0; i < randInts.Length; i++)
                {
                    int randInt = rand.Next(1, 7);
                    randInts[i] = randInt;
                }

                diceWrite.WriteDice(randInts);

                foreach (int randInt in randInts)
                    Console.Write($"{randInt} ");

                Console.ReadKey();
            }
        }
    }
}
