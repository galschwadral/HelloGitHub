using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeWPF
{
    class Game
    {
        Boolean isGameComplete = false;
        public Boolean IsGameComplete
        {
            get
            {
                return this.isGameComplete;
            }
            set
            {
                this.isGameComplete = value;
            }
        }

        Player turn;
        public Player Turn
        {
            get
            {
                return this.turn;
            }
            set
            {
                this.turn = value;
            }
        }

        string[,] winComb = { { "1", "2", "3" }, { "1", "4", "7" }, { "1", "5", "9" }, { "2", "5", "8" }, { "4", "5", "6" }, { "7", "5", "3" }, { "7", "8", "9" }, { "3", "6", "9" } };
        public string[,] WinComb
        {
            get
            {
                return this.winComb;
            }
            set
            {
                this.winComb = value;
            }
        }
        public void CheckForWin(Player p)
        {
            for (int row = 0; row < winComb.GetLength(0); row++)
            {
                if (winComb[row, 2] == winComb[row, 1] && winComb[row, 2] == winComb[row, 0])
                {
                    p.Win = true;
                    p.Score += 1;
                    break;
                }
            }
            
        }

        public void Input(int input, Game g, Player p)
        {
            for (int row = 0; row < g.WinComb.GetLength(0); row++)
            {
                for (int col = 0; col < g.WinComb.GetLength(1); col++)
                {
                    string tempStr = g.WinComb[row, col];
                    if(tempStr != "x" && tempStr != "o")
                    {
                        int temp = Int32.Parse(tempStr);
                        if (temp == input)
                        {
                            g.WinComb[row, col] = char.ToString(p.Symbol);
                        }
                    }  
                }
            }
        }
    }
}
