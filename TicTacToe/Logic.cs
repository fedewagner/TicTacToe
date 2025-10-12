namespace TicTacToe;

public class Logic
{
    public static string[] PickAvailablePositionForAi(string[] gridSymbols, List<int> availablePositions)
    {
        Random rand = new Random();
        int index = rand.Next(availablePositions.Count);
        int randomPosition = availablePositions[index];
        availablePositions.RemoveAt(index);
        gridSymbols[index] = "X";
        
        return gridSymbols;
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

        return (false); //no horizontal winning
    }
}