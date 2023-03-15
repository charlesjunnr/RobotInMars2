namespace Desenho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicaoX = 1, posicaoY = 1;
            int rows = 8;
            int cols = 8;
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                   board[i, j] = 'X';
                    posicaoX = i;
                    posicaoY = j;
                    board[i, j] = 'R';
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(board[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}