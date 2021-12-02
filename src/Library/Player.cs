using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Player : PropertyChangedBase
    {
        private Board board;
        private bool isTheirTurn;
        private PlayerColor playerColor;
        public PlayerColor PlayerColor {get; set;}
        public Player(Board board, PlayerColor playerColor)
        {
            this.board = board;
            this.playerColor = playerColor;
        }
        public class Kartka_Currency()
        {
            int Starting_Currency = 100; // Zaczynamy grę z x ilością kartek
			
        }
    
    }

    public enum PlayerColor
    {
        red,
        green,
        blue,
        yellow
    }
}
