namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int DIMENSION = 3;
            
            //Define and Fill Empty grid
            string[,] gridCharacters = Logic.FillEmptyGrid(DIMENSION);
            
            //define locations
            List<int> availablePositions = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            //Just welcome the user with general information
            UserInterface.WelcomeUser();
            
            //explains the positions to the user
            UserInterface.ExplainTheRulesToUser(DIMENSION, availablePositions);
            
            //shows how the current grid looks with the positions
            UserInterface.PrintCurrentGrid(DIMENSION, gridCharacters);
            
            while (availablePositions.Count > 0)
            {
            
                //Ask for location of the first users Symbol
                UserInterface.IntroduceUserSymbol(DIMENSION, gridCharacters, availablePositions);
                
                bool isThereAWinner = false;
                
                //checking if User won
                isThereAWinner = UserInterface.CheckingWinners(gridCharacters);

                if (isThereAWinner)
                {break;}
                
                //MISSING METHOD TO HANDLE CASE IF THERE IS A TIE!
                
                //Pick one for the AI
                Logic.PickAvailablePositionForAi(gridCharacters, availablePositions);

                //shows how the current grid looks
                UserInterface.PrintCurrentGrid(DIMENSION, gridCharacters);
                
                //checking if AI won
                UserInterface.CheckingWinners(gridCharacters);
                
                if (isThereAWinner)
                {break;}
            }
            
        }
    }
}