using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Library
{
    public abstract class Space : PropertyChangedBase
    {
        private string color = "Red";
        public virtual string Color { get { return color; } }

        private string name;
        public virtual string Name { get; set; }

        private int position;
        public int Position { get; set; }

        private string columnIndex;
        public string ColumnIndex { get; set; }

        private string rowIndex;
        public string RowIndex { get; set; }

        public void SetIndices(int position) {
            ColumnIndex = position switch
            {
                >= 20 and <= 30 => "1",
                19 or 31 => "2",
                18 or 32 => "3",
                17 or 33 => "4",
                16 or 34 => "5",
                15 or 35 => "7",
                14 or 36 => "9",
                13 or 37 => "10",
                12 or 38 => "11",
                11 or 39 => "12",
                >= 0 and <= 10 => "13",
                _ => "0"
            };
            RowIndex = position switch
            {
                >= 10 and <= 20 => "1",
                9 or 21 => "2",
                8 or 22 => "3",
                7 or 23 => "4",
                6 or 24 => "5",
                5 or 25 => "7",
                4 or 26 => "9",
                3 or 27 => "10",
                2 or 28 => "11",
                1 or 29 => "12",
                0 or (>= 30 and <= 39) => "13",
                _ => "0"
            };
        }
    }
}
