namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Definition of Symbols String
            string[] gridSymbols = {"_", "_", "_", "_", "_", "_", "_", "_", "_" };
            List<int> availablePositions = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            
            //Just welcome the user with general information
            UserInterface.WelcomeUser();
            
            //explains the positions to the user
            UserInterface.ExplainTheRulesToUser(gridSymbols, availablePositions);
            
            //shows how the current grid looks
            UserInterface.PrintCurrentGrid(gridSymbols);
            
            //Ask for location of the first users Symbol
            UserInterface.IntroduceUserSymbol(gridSymbols, availablePositions);
            
            //Pick one for the AI
            gridSymbols = Logic.pickAvailablePositionForAI(gridSymbols, availablePositions);
            
            //shows how the current grid looks
            UserInterface.PrintCurrentGrid(gridSymbols);
            
        }
    }
}