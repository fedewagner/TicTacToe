namespace TicTacToe;

public class Logic
{

    public static string[,] FillEmptyGrid(int dimension)
    {
        string[,] gridCharacters = new string[dimension, dimension];

        //fill the array
        for (int row = 0; row < dimension; row++)
        {
            //print first Character each row
            Console.Write("|");
            for (int col = 0; col < dimension; col++)
            {
                gridCharacters[row, col] = "_";
            }
        }

        return gridCharacters;
    }

    public static void PickAvailablePositionForAi(string[,] gridSymbols, List<int> availablePositions)
    {
        Random rand = new Random();
        int index = rand.Next(availablePositions.Count);
        int randomPosition = availablePositions[index];
        availablePositions.RemoveAt(index);

        //conversion formulas from positions to grid
        int row = (randomPosition - 1) / 3; // 0-based row
        int col = (randomPosition - 1) % 3; // 0-based column

        gridSymbols[row, col] = "X";
    }


    public static bool CheckingAllHorizontalLines(string[,] charactersGrid)
    {
        int rows = charactersGrid.GetLength(0);
        bool anyRowWinning = false;
        for (int row = 0; row < rows; row++)
        {
            if (
                IsWinningLine(charactersGrid[row, 0], charactersGrid[row, 1], charactersGrid[row, 2]))
            {
                anyRowWinning = true;
            };
        }
        return anyRowWinning;
    }

    private static bool IsWinningLine(string a, string b, string c)
    {
        return a == b && b == c && a != "_";
    }
}