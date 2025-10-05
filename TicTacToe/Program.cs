namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Just welcome the user with general information
            UserInterface.WelcomeUser();
            
            //explains the positions to the user
            UserInterface.PrintEmptyGrid();
            
            //shows how the current grid looks
            UserInterface.PrintCurrentGrid();
        }
    }
}