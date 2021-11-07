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
        public BoardViewModel()
        {
            Communopoly = new Board();
        }
        public Board Communopoly { get; set; }
    }
}
