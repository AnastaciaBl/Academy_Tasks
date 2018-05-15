using System.Text;
using CheckUserInput;

namespace Task1
{
    enum SquareColor
    {
        White,
        Black
    };

    class ChessBoard
    {
        private int height, width;
        public int Height
        {
            get { return height; }
            private set
            {
                if (CheckIntegerNumbers.IsNaturalNumber(value)) height = value;
                else throw new System.ArgumentException("Height should be a natural number.");
            }
        }
        public int Width
        {
            get { return width; }
            private set
            {
                if (CheckIntegerNumbers.IsNaturalNumber(value)) width = value;
                else throw new System.ArgumentException("Width should be a natural number.");
            }
        }
        private SquareColor[,] board;
        private string strRepresentation { get; set; }

        public ChessBoard(int _height, int _width)
        {
            Height = _height;
            Width = _width;
            board = createBoard();
            strRepresentation = getStringRepresentation();
        }

        public override string ToString()
        {
            return strRepresentation;
        }

        private SquareColor[,] createBoard()
        {
            SquareColor[,] board = new SquareColor[Height, Width];
            SquareColor firstSymbolInLine = SquareColor.Black;
            for (int i=0;i<Height;i++)
            {
                SquareColor temp = firstSymbolInLine;
                for (int j=0;j<Width;j++)
                {
                    board[i, j] = temp;
                    temp = changeColorOfSquare(temp);
                }
                firstSymbolInLine = changeColorOfSquare(firstSymbolInLine);
            }
            return board;
        }

        private SquareColor changeColorOfSquare(SquareColor temp)
        {
            if (temp == SquareColor.Black)
                return SquareColor.White;
            else
                return SquareColor.Black;
        }

        private string getStringRepresentation()
        {
            StringBuilder strBoard = new StringBuilder();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (board[i, j] == SquareColor.White)
                        strBoard.Append(' ');
                    else strBoard.Append('*');
                }
                strBoard.AppendLine();
            }
            return strBoard.ToString();
        }
    }
}
