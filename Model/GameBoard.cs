using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A class representing the chess game board.
/// </summary>
namespace MauiChess.Model
{
    public class GameBoard
    {
        public GameBoard()
        {
            this.BoardLayout = new ObservableCollection<ObservableCollection<BoardTile>>();

            for (int i = 0; i < 8; i++)
            {
                ObservableCollection<BoardTile> columnOfTiles = new ObservableCollection<BoardTile>();

                for (int j = 0; j < 8; j++)
                {
                    columnOfTiles.Add(new BoardTile(i,j));
                }

                BoardLayout.Add(columnOfTiles);
            }
        }

        public ObservableCollection<ObservableCollection<BoardTile>> BoardLayout { get; }
    }
}
