using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        private static string[,] ttt = new string[,]
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" }
            };

        static void Main(string[] args)
        {
            string[,] clone = new string[,]
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" }
            };
            string input;
            bool exit = true, isValid;
            int player = 1;

            do
            {
                Console.Clear();
                DrawBoard(clone);
                if (CheckWinner(clone, "X") == 1)
                {
                    Console.WriteLine("Congradulation! Player 1 wins!");
                    Console.WriteLine("Press any key to play again.");
                    Console.ReadKey();
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            clone[i, j] = ttt[i, j];
                    Console.Clear();
                    DrawBoard(clone);
                    player = 1;
                }
                else if (CheckWinner(clone, "O") == 1)
                {
                    Console.WriteLine("Congradulation! Player 2 wins!");
                    Console.WriteLine("Press any key to play again.");
                    Console.ReadKey();
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            clone[i, j] = ttt[i, j];
                    Console.Clear();
                    DrawBoard(clone);
                    player = 1;
                }
                else if (CheckWinner(clone, "X") == 2)
                {
                    Console.WriteLine("It's a tie! No winners!");
                    Console.WriteLine("Press any key to play again.");
                    Console.ReadKey();
                    clone = ttt;
                    Console.Clear();
                    DrawBoard(clone);
                    player = 1;
                }
                if(player % 2 == 1)
                    Console.Write("Player 1: Choose your field! ");
                else
                    Console.Write("Player 2: Choose your field! ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        isValid = CheckBoard(clone, 0, 0);
                        if (isValid)
                        {
                            if (player % 2 == 1)
                                clone[0, 0] = "X";
                            else
                                clone[0, 0] = "O";
                        }
                        else
                            player--;
                        break;
                    case "2":
                        isValid = CheckBoard(clone, 0, 1);
                        if (isValid)
                        {
                            if (player % 2 == 1)
                                clone[0, 1] = "X";
                            else
                                clone[0, 1] = "O";
                        }
                        else
                            player--;
                        break;
                    case "3":
                        isValid = CheckBoard(clone, 0, 2);
                        if (isValid)
                        {
                            if (player % 2 == 1)
                                clone[0, 2] = "X";
                            else
                                clone[0, 2] = "O";
                        }
                        else
                            player--;
                        break;
                    case "4":
                        isValid = CheckBoard(clone, 1, 0);
                        if (isValid)
                        {
                            if (player % 2 == 1)
                                clone[1, 0] = "X";
                            else
                                clone[1, 0] = "O";
                        }
                        else
                            player--;
                        break;
                    case "5":
                        isValid = CheckBoard(clone, 1, 1);
                        if (isValid)
                        {
                            if (player % 2 == 1)
                                clone[1, 1] = "X";
                            else
                                clone[1, 1] = "O";
                        }
                        else
                            player--;
                        break;
                    case "6":
                        isValid = CheckBoard(clone, 1, 2);
                        if (isValid)
                        {
                            if (player % 2 == 1)
                                clone[1, 2] = "X";
                            else
                                clone[1, 2] = "O";
                        }
                        else
                            player--;
                        break;
                    case "7":
                        isValid = CheckBoard(clone, 2, 0);
                        if (isValid)
                        {
                            if (player % 2 == 1)
                                clone[2, 0] = "X";
                            else
                                clone[2, 0] = "O";
                        }
                        else
                            player--;
                        break;
                    case "8":
                        isValid = CheckBoard(clone, 2, 1);
                        if (isValid)
                        {
                            if (player % 2 == 1)
                                clone[2, 1] = "X";
                            else
                                clone[2, 1] = "O";
                        }
                        else
                            player--;
                        break;
                    case "9":
                        isValid = CheckBoard(clone, 2, 2);
                        if (isValid)
                        {
                            if (player % 2 == 1)
                                clone[2, 2] = "X";
                            else
                                clone[2, 2] = "O";
                        }
                        else
                            player--;
                        break;
                    //input is invalid
                    default:
                        Console.WriteLine("Invalid field! Press any key to continue... ");
                        Console.ReadKey();
                        player--;
                        break;
                }
                player++;
            } while (exit);

            Console.ReadKey();
        }

        public static bool CheckBoard(string[,] clone, int x, int y)
        {

            if (clone[x, y] == "O" || clone[x, y] == "X")
            {
                Console.WriteLine("This field has already been taken! Press any key to continue... ");
                Console.ReadKey();
                return false;
            }
            else
                return true;
        }

        public static int CheckWinner(string[,] clone, string s)
        {
            if ((clone[0,0] == s && clone[0,1] == s && clone[0,2] == s) 
                || (clone[1, 0] == s && clone[1, 1] == s && clone[1, 2] == s)
                || (clone[2, 0] == s && clone[2, 1] == s && clone[2, 2] == s)
                || (clone[0, 0] == s && clone[1, 0] == s && clone[2, 0] == s)
                || (clone[0, 1] == s && clone[1, 1] == s && clone[2, 1] == s)
                || (clone[0, 2] == s && clone[1, 2] == s && clone[2, 2] == s)
                || (clone[0, 0] == s && clone[1, 1] == s && clone[2, 2] == s)
                || (clone[0, 2] == s && clone[1, 1] == s && clone[2, 0] == s))
                return 1;
            else if (clone[0, 0] != "1" && clone[0, 1] != "2" && clone[0, 2] != "3" &&
                clone[1, 0] != "4" && clone[1, 1] != "5" && clone[1, 2] != "6" &&
                clone[2, 0] != "7" && clone[2, 1] != "8" && clone[2, 2] != "9")
                return 2;
            else
                return 3;
        }

        public static void DrawBoard(string[,] clone)
        {
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
