using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome the user and start the program
            Console.WriteLine("Welcome to the dice program");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Rolling dice");

            //create a new dice object and roll
            Dice newRun = new Dice();
            newRun.Roll();

            //display the result of the rolls
            Console.WriteLine("Die 1 rolled a {0}", newRun.Die1);
            Console.WriteLine("Die 2 rolled a {0}", newRun.Die2);




        }
    }
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

