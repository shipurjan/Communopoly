using Library;
using Library.Spaces;
using Library.Republics;
using System.Collections.ObjectModel;
using System;


class LibraryTest
{
    public static Board Communopoly { get; set; }
    public static void Main()
    {
        Communopoly = new Board();
        for (int i = 0; i < Board.Size; i++) {
            Console.WriteLine($"{Communopoly.Spaces[i]} {Communopoly.Spaces[i].Color} {Communopoly.Spaces[i].Position} {Communopoly.Spaces[i].ColumnIndex} {Communopoly.Spaces[i].RowIndex}");
        }
    }
}