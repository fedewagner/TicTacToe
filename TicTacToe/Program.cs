namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int DIMENSION = 3;
            
            /*// Definition of Symbols String
            string[] gridSymbols = {"_", "_", "_", "_", "_", "_", "_", "_", "_" };*/

            //Define and Fill Empty grid
            string[,] gridCharacters = Logic.FillEmptyGrid(DIMENSION);
            
            //define locations
            List<int> availablePositions = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            //Just welcome the user with general information
            UserInterface.WelcomeUser();
            
            //explains the positions to the user
            UserInterface.ExplainTheRulesToUser(DIMENSION, availablePositions);
            
            //shows how the current grid looks
            UserInterface.PrintCurrentGrid(DIMENSION, gridCharacters);
            
            //Ask for location of the first users Symbol
            UserInterface.IntroduceUserSymbol(DIMENSION, gridCharacters, availablePositions);
            
            //Pick one for the AI
            Logic.PickAvailablePositionForAi(gridCharacters, availablePositions);
            
            //shows how the current grid looks
            UserInterface.PrintCurrentGrid(DIMENSION, gridCharacters);
            
            //Checking Horizontals
            
            bool isThereAWinner;
            isThereAWinner = Logic.CheckingAllHorizontalLines(gridCharacters);
            Console.WriteLine($"Is there already a Horizontal winner? {isThereAWinner}");
        }
    }
}