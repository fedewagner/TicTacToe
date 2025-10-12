namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int DIMENSION = 3;
            
            // Definition of Symbols String
            string[] gridSymbols = {"_", "_", "_", "_", "_", "_", "_", "_", "_" };
            string[,] gridCharacters = new string[DIMENSION, DIMENSION];
            
            List<int> availablePositions = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            
            //Just welcome the user with general information
            UserInterface.WelcomeUser();
            
            //explains the positions to the user
            UserInterface.ExplainTheRulesToUser(DIMENSION, gridSymbols, availablePositions);
            
            //shows how the current grid looks
            UserInterface.PrintCurrentGrid(DIMENSION, gridSymbols);
            
            //Ask for location of the first users Symbol
            UserInterface.IntroduceUserSymbol(DIMENSION, gridSymbols, availablePositions);
            
            //Pick one for the AI
            gridSymbols = Logic.PickAvailablePositionForAi(gridSymbols, availablePositions);
            
            //shows how the current grid looks
            UserInterface.PrintCurrentGrid(DIMENSION, gridSymbols);
            
            //Checking Horizontals

            bool isThereAWinner = false;
            
            isThereAWinner = Logic.CheckingAllHorizontalLines(gridCharacters);
            Console.WriteLine($"Is there already a Horizontal winner? {isThereAWinner}");

        }
    }
}