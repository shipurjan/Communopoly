using Library.Spaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public class Board
    {
        private string backgroundColor;
        public const int Size = 40;
        public ObservableCollection<Space> Spaces { get; set; }

        public Board()
        {
            MakeBoard();
        }
        private void MakeBoard()
        {
            Random rnd = new Random();
            int siberiaStart = rnd.Next(0, 8) * 5 + 1;

            Spaces = new ObservableCollection<Space>();

            for (int pos = 0; pos < Size; pos++)
                Spaces.Add(pos switch
                {
                    5 or 15 or 25 or 35 
                        => new(pos, "Station"),
                    7 or 13 
                        => new(pos, "Chance"),
                    0 
                        => new(pos, "Start"),
                    10 
                        => new(pos, "Reeducation"),
                    20 
                        => new(pos, "Katorga"),
                    30 
                        => new(pos, "Redistribution"),
                    _ 
                        => new(pos, (siberiaStart <= pos && pos <= siberiaStart + 3) ? "Siberia" : "Republic"),
                });
        }
    }
}