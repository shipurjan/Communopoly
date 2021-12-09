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
			public int Starting_Currency = 100; // Zaczynamy grę z x ilością kartek
			public Card[] Cards = new Card[10];
			public int index = 0;
			
				public class Card
					{
						public int[] image;
						public string name;
						public int price = 0; //if user needs to pay.
						public int outofJail = 0; //0 if not, 1 if out of jail card
						public int gotoJail = 0; // =1 if its a go to jail card
					}
					
				public int drawCard()
					{
						Random rand = new Random(); 
						int index = rand.Next(0, 9); 
						return index;
					}
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
