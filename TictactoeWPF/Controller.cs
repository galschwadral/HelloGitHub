using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace TictactoeWPF
{
    class Controller
    {
        public int playerChoice;

        public string winOutput = "";

        public string color;

        Boolean endGame = false;

        Player player1 = new Player("1");
        Player player2 = new Player("2");
        Game game = new Game();

        public string TextBtnUpdate()
        {
            return game.Turn.Symbol.ToString();
        }  

        public Controller()
        {
            game.Turn = player1;
            player1.Symbol = 'x';
            player2.Symbol = 'o';
        }

        public int GiveViewScore(int oneOrTwo)
        {
            if (oneOrTwo == 1)
            {
                return player1.Score;
            }
            else if (oneOrTwo == 2)
            {
                return player2.Score;
            }
            else return 0;
        }

        public void TurnLogic()
        {
            game.Input(playerChoice, game, game.Turn);
            
            game.CheckForWin(game.Turn);

            if(game.Turn.Win == true)
            {
                endGame = true;
            }
            else if(game.Turn == player1)
            {
                game.Turn = player2;
            }
            else
            {
                game.Turn = player1;
            }
        }

        public void ClickAction(Button b1, Button b2, int choice, Grid grid)
        {
            playerChoice = choice;
            b1.Content = TextBtnUpdate();
            b1.IsEnabled = false;
            if (game.Turn == player1)
            {
                color = "#FFFF4343";
            }
            else
            {
                color = "#FF1810D3";
            }
            var bc = new BrushConverter();
            b1.Foreground = (Brush)bc.ConvertFrom(color);
            TurnLogic();
            if (endGame == true)
            {
                foreach (Button btn in grid.Children)
                {
                    btn.IsEnabled = false;
                }
                if (game.Turn.Win == true)
                {
                    winOutput = "Player " + game.Turn.Name + " won the game!";
                }
                b2.IsEnabled = true;
            }
        }
        public void Replay(Button b2, Grid grid)
        {
            string[,] tempWinComb = { { "1", "2", "3" }, { "1", "4", "7" }, { "1", "5", "9" }, { "2", "5", "8" }, { "4", "5", "6" }, { "7", "5", "3" }, { "7", "8", "9" }, { "3", "6", "9" } };
            game.WinComb = tempWinComb;
            foreach (Button btn in grid.Children)
            {
                btn.Content = "";
                btn.IsEnabled = true;
            }
            b2.IsEnabled = false;
            game.Turn.Win = false;
            game.Turn = player1;
            endGame = false;

        }
    }
}
