namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Definition of Symbols String
            string[] Symbols = {"_", "_", "_", "_", "_", "_", "_", "_", "_" };
            
            //Just welcome the user with general information
            UserInterface.WelcomeUser();
            
            //explains the positions to the user
            UserInterface.PrintEmptyGrid(Symbols);
            
            //shows how the current grid looks
            UserInterface.PrintCurrentGrid(Symbols);
            
            //Ask for location of the first users Symbol
            UserInterface.IntroduceUserSymbol(Symbols);
        }
    }
}