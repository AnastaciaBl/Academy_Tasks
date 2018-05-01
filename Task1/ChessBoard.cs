namespace Task1
{
    enum SquareColor
    {
        White,
        Black
    };

    class ChessBoard
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        private int[,] board;

        public ChessBoard(int height, int width)
        {
            Height = height;
            Width = width;
            board = createBoard();
        }

        public override string ToString()
        {
            string strBoard = string.Empty;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (board[i, j] == (int)SquareColor.White)
                        strBoard += " ";
                    else strBoard += "*";
                }
                strBoard += "\n";
            }
            return strBoard;
        }

        private int[,] createBoard()
        {
            int[,] board = new int[Height, Width];
            int firstSymbolInLine = (int)SquareColor.Black;
            for (int i=0;i<Height;i++)
            {
                int temp = firstSymbolInLine;
                for (int j=0;j<Width;j++)
                {
                    board[i, j] = temp;
                    temp = changeColorOfSquare(temp);
                }
                firstSymbolInLine = changeColorOfSquare(firstSymbolInLine);
            }
            return board;
        }

        private int changeColorOfSquare(int temp)
        {
            if (temp == (int)SquareColor.Black)
                return (int)SquareColor.White;
            else
                return (int)SquareColor.Black;
        }
    }
}
