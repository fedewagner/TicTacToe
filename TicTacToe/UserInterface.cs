namespace TicTacToe;

public class UserInterface
{
    public static void WelcomeUser()
    {
        Console.WriteLine("Welcome to TicTacToe!");
        Console.WriteLine("You have to place your Symbol 'O' and play against AI which will be using 'X'");
        Console.WriteLine("The first who makes 3 in a line, wins!");
    }

    public static void ExplainTheRulesToUser()
    {
        //Print the upper border (one extra at the beginning and one at the end)
        Console.WriteLine("To place your Symbol 'O', indicate the position from 1 to 9:");
        
    }

    public static void PrintEmptyGrid(int dimension, List<int> availablePositions)
    {
        int i = 0;

        Console.Write("+");
        for (int column = 0; column < dimension; column++)
        {
            Console.Write("--+--");
        }

        Console.Write("+");
        Console.WriteLine();

        // int item = 0;

        //fill the array
        for (int row = 0; row < dimension; row++)
        {
            //print first Character each row
            Console.Write("|");
            for (int col = 0; col < dimension; col++)
            {
                if (col % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Format the number to 2 digits
                string cell = availablePositions[i].ToString("D2");

                Console.Write("  " + cell + "  ");
                Console.ForegroundColor = ConsoleColor.Gray;
                i++;
            }

            //print last Character each row
            Console.Write("|");
            Console.WriteLine();
        }

        //Print the bottom border(one extra at the beginning and one at the end)
        Console.Write("+");
        for (int column = 0; column < dimension; column++)
        {
            Console.Write("--+--");
        }

        Console.WriteLine("+");
    }
    
    
    public static void PrintCurrentGrid(int dimension, string[,] gridCharacters)
    {
        //Print the upper border (one extra at the beginning and one at the end)
        Console.WriteLine("The current grid looks like:");

        int i = 0;

        Console.Write("+");
        for (int column = 0; column < dimension; column++)
        {
            Console.Write("--+--");
        }

        Console.Write("+");
        Console.WriteLine();

        // int item = 0;

        //fill the array
        for (int row = 0; row < dimension; row++)
        {
            //print first Character each row
            Console.Write("|");
            for (int col = 0; col < dimension; col++)
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
                Console.Write("  " + gridCharacters[row,col] + "  ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //print last Character each row
            Console.Write("|");
            Console.WriteLine();
        }

        //Print the bottom border(one extra at the beginning and one at the end)
        Console.Write("+");
        for (int column = 0; column < dimension; column++)
        {
            Console.Write("--+--");
        }

        Console.WriteLine("+");
    }

    public static void IntroduceUserSymbol(int dimension, string[,] gridCharacters,  List<int> availablePositions)
    {
        int selectionPosition;
        bool validSelection;
        
        do
        {
            Console.WriteLine($"Enter a position (1 to {dimension * dimension}) for your next 'O':");
            string? input = Console.ReadLine(); // read full line

            validSelection = int.TryParse(input, out selectionPosition) 
                             && availablePositions.Contains(selectionPosition);

        } while (!validSelection);
        
        availablePositions.Remove(selectionPosition);
        
        //conversion formulas from positions to grid
        int row = (selectionPosition - 1) / dimension;   // 0-based row
        int col = (selectionPosition - 1) % dimension;   // 0-based column
        
        gridCharacters[row, col] = "O";
        Console.WriteLine("You selected your next position: ");
        PrintCurrentGrid(dimension, gridCharacters);
    }

    public static bool CheckingWinners(string[,] gridCharacters)
    {
        bool isThereAWinner;
        
        //Checking winners
        isThereAWinner = Logic.CheckingLines(gridCharacters);
        return isThereAWinner;
    }

    public static void InformTie()
    {
        Console.WriteLine("There is a Tie! Try again later!");
    }

    public static void InformWinners()
    {
        Console.WriteLine($"There is a winner!");    
    }

}