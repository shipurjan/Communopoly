using Library;
using Library.Spaces;
using Library.Republics;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Controls;

namespace Communopoly.ViewModels
{
    public class BoardViewModel : PropertyChangedBase
    {
        private PlayerViewModel playerView1;
        public BoardViewModel()
        {
            Communopoly = new Game();
            PlayerModel1 = new PlayerViewModel(Communopoly.Board, PlayerColor.red);
            PlayerModel1.Player.Position = 5;
        }
        public Game Communopoly { get; set; }
        public PlayerViewModel PlayerModel1 { get; set; }
    }
}
