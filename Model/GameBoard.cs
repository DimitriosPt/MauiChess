using System;
using System.Collections.Generic;
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
            this.BoardLayout = new BoardTile[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.BoardLayout[i, j] = new BoardTile(i, j);
                }
            }
        }

        public BoardTile[,] BoardLayout { get; }
    }
}
