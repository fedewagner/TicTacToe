namespace TicTacToe;

public class Logic
{
    public static string[] pickAvailablePositionForAI(string[] gridSymbols, List<int> availablePositions)
    {
        Random rand = new Random();
        int index = rand.Next(availablePositions.Count);
        int randomPosition = availablePositions[index];
        availablePositions.RemoveAt(index);
        gridSymbols[index] = "X";
        
        return gridSymbols;
        }
}