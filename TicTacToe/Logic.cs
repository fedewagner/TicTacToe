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


    public static bool CheckingWinners(string[,] gridCharacters)
    {
        bool isHorizontalWinner = CheckingAllHorizontalLines(gridCharacters);
        bool isVerticalWinner = CheckingAllVerticalLines(gridCharacters);
        bool isMainDiagonalWinner = CheckingMainDiagonal(gridCharacters);
        bool isAntiDiagonalWinner = CheckingAntiDiagonal(gridCharacters);
        
        if (isHorizontalWinner || isVerticalWinner || isMainDiagonalWinner || isAntiDiagonalWinner)
        {
            return true;
        }
        return false;
    }


    private static bool CheckingAllHorizontalLines(string[,] charactersGrid)
    {
        int rows = charactersGrid.GetLength(0);
        bool anyRowWinning = false;
        for (int row = 0; row < rows; row++)
        {
            if (
                IsWinningLine(charactersGrid[row, 0], charactersGrid[row, 1], charactersGrid[row, 2]))
            {
                anyRowWinning = true;
            }
        }

        return anyRowWinning;
    }

    private static bool CheckingAllVerticalLines(string[,] charactersGrid)
    {
        int cols = charactersGrid.GetLength(1);
        bool anyColWinning = false;
        for (int col = 0; col < cols; col++)
        {
            if (
                IsWinningLine(charactersGrid[0, col], charactersGrid[1, col], charactersGrid[2, col]))
            {
                anyColWinning = true;
            }
        }

        return anyColWinning;
    }

    private static bool CheckingMainDiagonal(string[,] charactersGrid)
    {
        bool mainDiagonalWinning = IsWinningLine(charactersGrid[0, 0], charactersGrid[1, 1], charactersGrid[2, 2]);
        return mainDiagonalWinning;
    }
    
    private static bool CheckingAntiDiagonal(string[,] charactersGrid)
    {
        bool antiDiagonalWinning = IsWinningLine(charactersGrid[2, 0], charactersGrid[1, 1], charactersGrid[0, 2]);
        return antiDiagonalWinning;
    }

    private static bool IsWinningLine(string a, string b, string c)
    {
        return a == b && b == c && a != "_";
    }
}