namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //grid dimension. TICTACTOE = 3X3
            const int DIMENSION = 3;
            
            //Define and Fill Empty grid
            string[,] gridCharacters = Logic.FillEmptyGrid(DIMENSION);
            
            //define locations
            List<int> availablePositions = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            //Just welcome the user with general information
            UserInterface.WelcomeUser();
            
            //explains the positions to the user
            UserInterface.ExplainTheRulesToUser();
            
            //Print empty grid with the positions
            UserInterface.PrintEmptyGrid(DIMENSION, availablePositions);
            
            //shows how the current grid looks with the positions
            UserInterface.PrintCurrentGrid(DIMENSION, gridCharacters);
            
            bool isThereAWinner = false;
            while (availablePositions.Count > 0 && !isThereAWinner)
            {
                
                //Ask for location of the first users Symbol
                UserInterface.IntroduceUserSymbol(DIMENSION, gridCharacters, availablePositions);

                //checking if User won
                isThereAWinner = UserInterface.CheckingWinners(gridCharacters);

                if (isThereAWinner)
                {
                    UserInterface.InformWinners();
                    break;
                }
                
                //in case all Positions where taken and no winner yet => break because of tie game
                if (availablePositions.Count == 0)
                {
                    break;
                }
                
                //Pick one for the AI
                Logic.PickAvailablePositionForAi(gridCharacters, availablePositions);

                //shows how the current grid looks
                UserInterface.PrintCurrentGrid(DIMENSION, gridCharacters);
                
                //checking if AI won
                isThereAWinner = UserInterface.CheckingWinners(gridCharacters);

                if (isThereAWinner)
                {
                    UserInterface.InformWinners();
                    break;
                }
            }

            if (availablePositions.Count == 0)
            {
                UserInterface.InformTie();
            }
            
        }
    }
}