using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Dice
    {
        private int die1;
        private int die2;

        public int Die1
        {
            get { return die1; }
            set { die1 = value; }
        }


        public int Die2
        {
            get { return die2; }
            set { die2 = value; }
        }

        public void Roll()
        {
            //get a random number object we can the use to determine the die face
            Random rand1 = new Random();
            Die1 = rand1.Next(1, 6);
            Die2 = rand1.Next(1, 6);
        }
    }
}

