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


    public static bool CheckingLines(string[,] gridCharacters)
    {
        bool isHorizontalWinner = CheckingAllHorizontalLines(gridCharacters);
        bool isVerticalWinner = CheckingAllVerticalLines(gridCharacters);
        bool isMainDiagonalWinner = CheckingDiagagonals(gridCharacters);
        
        if (isHorizontalWinner || isVerticalWinner || isMainDiagonalWinner)
        {
            return true;
        }
        return false;
    }


    public static bool CheckingAllHorizontalLines(string[,] charactersGrid)
    {
        int rows = charactersGrid.GetLength(0);
        int columns = charactersGrid.GetLength(1);
        bool anyRowWinning = false;
        for (int row = 0; row < rows; row++)
        {
            string first = charactersGrid[row, 0];
            bool rowWinning = true;
            for (int column = 1; column < columns; column++)
            {
                //case with no completed line (equals "_") => break with no winner
                if (first == "_")
                {
                    rowWinning = false;
                    break;
                }
                
                //case with completed line => checks the logic
                if (charactersGrid[row, column] != first)
                {
                    rowWinning = false;
                    break;
                }
            }

            if (rowWinning)
            {
                anyRowWinning = true;
            }
        }

        if (anyRowWinning)
        {
           return (true);
        }

        return false; //no column winning
    }


    //check all Vertical Lines
    public static bool CheckingAllVerticalLines(string[,] charactersGrid)
    {
        int rows = charactersGrid.GetLength(0);
        int columns = charactersGrid.GetLength(1);
        bool anyColumnWinning = false;

        for (int column = 0; column < columns; column++)
        {
            string first = charactersGrid[0, column];
            bool columnWinning = true;
            for (int row = 1; row < rows; row++)
            {
                //case with no completed line (equals "_") => break with no winner
                if (first == "_")
                {
                    columnWinning = false;
                    break;
                }
                
                //case with completed line => checks the logic
                if (charactersGrid[row, column] != first)
                {
                    columnWinning = false;
                    break; //this row doesn't win
                }
            }

            if (columnWinning)
            {
                anyColumnWinning = true;
            }
        }

        if (anyColumnWinning)
        {
            return true; //a column is winning
        }
        return false; //no column winning
    }

    public static bool CheckingDiagagonals(string[,] charactersGrid)
    {
        int rows = charactersGrid.GetLength(0);
        int columns = charactersGrid.GetLength(1);
        bool isDiagonal1AWinner = true;
        bool isDiagonal2AWinner = true;
        bool isAnyDiagonalLineWinning = false;
        string firstElementDiagonal1 = charactersGrid[0, 0];
        for (int row = 1, col = 1; row < rows && col < columns; row++, col++)
        {
            
            //case with no completed line (equals "_") => break with no winner
            if (firstElementDiagonal1 == "_")
            {
                isDiagonal1AWinner = false;
                break;
            }
                
            //case with completed line => checks the logic
            if (charactersGrid[row, col] != firstElementDiagonal1)
            {
                isDiagonal1AWinner = false;
                break;
            }
        }

        int lastRow = charactersGrid.GetLength(0) - 1;
        string firstElementDiagonal2 = charactersGrid[lastRow, 0];
        for (int row = lastRow - 1, col = 1; row >= 0 && col < columns; row--, col++)
        {
            
            //case with no completed line (equals "_") => break with no winner
            if (firstElementDiagonal2 == "_")
            {
                isDiagonal2AWinner = false;
                break;
            }
                
            //case with completed line => checks the logic
            if (charactersGrid[row, col] != firstElementDiagonal2)
            {
                isDiagonal2AWinner = false;
                break;
            }
        }

        if (isDiagonal1AWinner)
        {
            isAnyDiagonalLineWinning = true;
        }

        if (isDiagonal2AWinner)
        {
            isAnyDiagonalLineWinning = true;
        }

        return isAnyDiagonalLineWinning;
    }
}
