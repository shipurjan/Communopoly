using Library;
using Library.Spaces;
using Library.Republics;
using System.Collections.ObjectModel;
using System;


class LibraryTest
{
    static void Main()
    {
        // Display the number of command line arguments.
        Board board01 = new();
        for (int i = 0; i < Board.Size; i++)
        {
            Console.WriteLine($"{board01.Spaces[i]} {board01.Spaces[i].RowIndex} {board01.Spaces[i].ColumnIndex}");
        }
    }
}