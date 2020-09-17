using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DiceGame
{
    class DiceWriter
    {
        public void WriteDice(int[] randInts)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 120; column++)
                {
                    switch (row)
                    {
                        case 0:
                        case 8:
                            if ((column + 1) % 6 == 0)
                                Console.Write(" ");
                            else
                                Console.Write("=");
                            break;
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                            Console.Write(' ');
                            break;
                        case 2:
                            switch (randInts[column / 6])
                            {
                                case 1:
                                    Console.Write("|   | ");
                                    break;
                                case 2:
                                case 3:
                                    Console.Write("|  o| ");
                                    break;
                                case 4:
                                case 5:
                                case 6:
                                    Console.Write("|o o| ");
                                    break;
                                default:
                                    break;
                            }
                            column += 5;
                            break;
                        case 4:
                            switch (randInts[column / 6])
                            {
                                case 1:
                                case 3:
                                case 5:
                                    Console.Write("| o | ");
                                    break;
                                case 2:
                                case 4:
                                    Console.Write("|   | ");
                                    break;
                                case 6:
                                    Console.Write("|o o| ");
                                    break;
                                default:
                                    break;
                            }
                            column += 5;
                            break;
                        case 6:
                            switch (randInts[column / 6])
                            {
                                case 1:
                                    Console.Write("|   | ");
                                    break;
                                case 2:
                                case 3:
                                    Console.Write("|o  | ");
                                    break;
                                case 4:
                                case 5:
                                case 6:
                                    Console.Write("|o o| ");
                                    break;
                                default:
                                    break;
                            }
                            column += 5;
                            break;
                        default:
                            break;
                    }
                    
                }
            }
        }
    }
}
