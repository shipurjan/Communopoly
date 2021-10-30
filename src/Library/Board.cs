using Library.Spaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Board
    {
        private string backgroundColor;
        public static int boardSize = 40;
        public List<Space> Spaces { get; set; }

        public Board()
        {
            MakeBoard();
        }
        private void MakeBoard()
        {
            Spaces = new List<Space>();
            for (int i = 0;i < boardSize; i++)
            {
                Spaces.Add(new Space(i));
                Console.WriteLine(Spaces.Last().GetType());
            }
        }
    }
}
