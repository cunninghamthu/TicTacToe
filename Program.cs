using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        private static readonly char[,] ttt = new char[,]
            {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' }
            };

        private static char[,] clone = new char[,]
            {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' }
            };

        private static int player = 1;


        static void Main(string[] args)
        {
            
            string input;

            do
            {
                DrawBoard();
                CheckWinner('X', 1);
                CheckWinner('O', 2);
                
                if (player % 2 == 1)
                    Console.Write("Player 1: Choose your field! ");
                else
                    Console.Write("Player 2: Choose your field! ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1": CheckBoard(0, 0); break;
                    case "2": CheckBoard(0, 1); break;
                    case "3": CheckBoard(0, 2); break;
                    case "4": CheckBoard(1, 0); break;
                    case "5": CheckBoard(1, 1); break;
                    case "6": CheckBoard(1, 2); break;
                    case "7": CheckBoard(2, 0); break;
                    case "8": CheckBoard(2, 1); break;
                    case "9": CheckBoard(2, 2); break;
                    //input is invalid
                    default:
                        Console.WriteLine("Invalid field! Press any key to continue... ");
                        Console.ReadKey();
                        break;
                }
            } while (true);
        }

        public static void CheckBoard(int x, int y)
        {
            if (clone[x, y] == 'O' || clone[x, y] == 'X')
            {
                Console.WriteLine("This field has already been taken! Press any key to continue... ");
                Console.ReadKey();
            }
            else
            {
                if (player % 2 == 1)
                    clone[x, y] = 'X';
                else
                    clone[x, y] = 'O';
                player++;
            }
        }

        public static void CheckWinner(char s, int p)
        {
            if ((clone[0, 0] == s && clone[0, 1] == s && clone[0, 2] == s)
                || (clone[1, 0] == s && clone[1, 1] == s && clone[1, 2] == s)
                || (clone[2, 0] == s && clone[2, 1] == s && clone[2, 2] == s)
                || (clone[0, 0] == s && clone[1, 0] == s && clone[2, 0] == s)
                || (clone[0, 1] == s && clone[1, 1] == s && clone[2, 1] == s)
                || (clone[0, 2] == s && clone[1, 2] == s && clone[2, 2] == s)
                || (clone[0, 0] == s && clone[1, 1] == s && clone[2, 2] == s)
                || (clone[0, 2] == s && clone[1, 1] == s && clone[2, 0] == s))
            {
                Console.WriteLine("Congradulation! Player {0} wins!", p);
                Console.WriteLine("Press any key to play again.");
                Console.ReadKey();
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        clone[i, j] = ttt[i, j];
                DrawBoard();
                player = 1;
            }
            else if (clone[0, 0] != '1' && clone[0, 1] != '2' && clone[0, 2] != '3' &&
                clone[1, 0] != '4' && clone[1, 1] != '5' && clone[1, 2] != '6' &&
                clone[2, 0] != '7' && clone[2, 1] != '8' && clone[2, 2] != '9')
            {
                Console.WriteLine("It's a tie! No winners!");
                Console.WriteLine("Press any key to play again.");
                Console.ReadKey();
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        clone[i, j] = ttt[i, j];
                DrawBoard();
                player = 1;
            }
        }

        public static void DrawBoard(char[,] clone)
        {
            Console.Clear();
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", clone[0, 0], clone[0, 1], clone[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", clone[1, 0], clone[1, 1], clone[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", clone[2, 0], clone[2, 1], clone[2, 2]);
            Console.WriteLine("     |     |");
        }
    }
}
