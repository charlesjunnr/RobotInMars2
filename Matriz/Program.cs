namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas = 5;
            int colunas = 5;
            int[,] matriz2 = new int[linhas, colunas];

            for(int i = 0; i < linhas; i++)
            {
                
                for (int j = 0; j < colunas; j++)
            {
                    matriz2[i, j] = 0;
            }
           }
           
        }
    }
}