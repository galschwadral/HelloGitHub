using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeWPF
{
    class Player
    {
        public Player(string name) { Name = name; }

        int thisTurnClick;

        private int score = 0;
        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;
            }
        }
        private Boolean win = false;
        public Boolean Win
        {
            get
            {
                return this.win;
            }
            set
            {
                this.win = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        private char symbol;
        public char Symbol
        {
            get
            {
                return this.symbol;
            }
            set
            {
                this.symbol = value;
            }
        }
    }
}
