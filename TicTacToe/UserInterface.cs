namespace TicTacToe;

public class UserInterface
{
    public static void WelcomeUser()
    {
        Console.WriteLine("Welcome to TicTacToe!");
        Console.WriteLine("You have to place your Symbol 'O' and play against AI which will be using 'X'");
        Console.WriteLine("The first who makes 3 in a line, wins!");
    }

    public static void PrintingEmptyGrid()
    {
        //Print the upper border (one extra at the beginning and one at the end)
        Console.WriteLine("To place your Symbol 'O', indicate the position from 1 to 9:");

        const int DIMENSION = 3;
        int[] Positions = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        int i = 0;

        Console.Write("+");
        for (int column = 0; column < DIMENSION; column++)
        {
            Console.Write("--+--");
        }

        Console.Write("+");
        Console.WriteLine();

        // int item = 0;

        //fill the array
        for (int row = 0; row < DIMENSION; row++)
        {
            //print first Character each row
            Console.Write("|");
            for (int col = 0; col < DIMENSION; col++)
            {
                if (col % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                //Print the output
                Console.Write("  " + Positions[i] + "  ");
                i++;
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //print last Character each row
            Console.Write("|");
            Console.WriteLine();
        }

        //Print the bottom border(one extra at the beginning and one at the end)
        Console.Write("+");
        for (int column = 0; column < DIMENSION; column++)
        {
            Console.Write("--+--");
        }

        Console.WriteLine("+");
    }
    
}