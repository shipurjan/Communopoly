using Library;
using Library.Spaces;
using Library.Republics;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Threading;

namespace Communopoly.ViewModels
{
    public class PlayerViewModel : PropertyChangedBase
    {
        public PlayerViewModel(Board board, Library.PlayerColor playerColor) {
            Player = new Player(board, playerColor);
        }
        public Player Player { get; set; }
    }
}
