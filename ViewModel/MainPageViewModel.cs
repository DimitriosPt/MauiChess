namespace MauiChess.ViewModel
{
    using MauiChess.Model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _title = string.Empty;

        public MainPageViewModel()
        {
            this.BoardLayout = new GameBoard();
            this.Title = "TempTitle";

            this.TempList = new List<string>() { "aaa", "aaaaaa", "aaaaa" };
        }

        public GameBoard BoardLayout { get; }

        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                if (this._title != value)
                {
                    this._title = value;
                    this.OnPropertyChanged(nameof(this.Title));
                }
            }
        }

        public List<string> TempList { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
