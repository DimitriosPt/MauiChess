namespace MauiChess.Model
{
    using System.Drawing;
    /// <summary>
    /// A class representing a tile of the board.
    /// </summary>
    public class BoardTile : IEquatable<BoardTile>
    {
        /// <summary>
        /// Creates a grid tile based on the desired color and ID.
        /// </summary>
        /// <param name="tileColor"></param>
        /// <param name="id"></param>
        public BoardTile(Color tileColor, string id)
        {
            this.TileColor = tileColor;
            this.ID = id;
        }

        /// <summary>
        /// Creates a grid tile based on indecies, presumably from a grid.
        /// </summary>
        /// <param name="rowIndex">The 0 based row index.</param>
        /// <param name="colIndex">The 0 based column index.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public BoardTile(int rowIndex, int colIndex)
        {
            if (rowIndex < 0 || colIndex < 0) throw new ArgumentOutOfRangeException(nameof(rowIndex), "Index of grid cell must be positive");
            if (rowIndex > 8 || colIndex > 8) throw new ArgumentOutOfRangeException(nameof(colIndex), "Index of grid cell must be less than 8");

            // 0,0 is black, and begins alternating to white. Therefore we can use the summation of the index to determine if it is the same as 0,0.
            this.TileColor = rowIndex + colIndex % 2 == 0 ? Color.Black : Color.White;

            char colIndexAsLetter = (char)(65 + colIndex);

            // Board cells are 1 based not 0.
            this.ID = $"{colIndexAsLetter}{rowIndex + 1}";
        }

        /// <summary>
        /// The color of the tile.
        /// </summary>
        public Color TileColor { get; }

        /// <summary>
        /// The compound row/col identifier of the cell.
        /// </summary>
        public string ID { get; }

        /// <inheritdoc/>
        public bool Equals(BoardTile other)
        {
            return this.TileColor == other.TileColor
                && this.ID == other.ID;
        }
    }
}