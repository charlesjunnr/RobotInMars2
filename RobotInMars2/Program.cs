namespace Robot.DeuCerto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaração de variáveis
            char direcao, direcao2;
            int posicaoX = 0, posicaoY = 0, posicaoYdois = 0, posicaoXdois = 0;

            Console.WriteLine("--- Let's begin our exploration in Mars ---");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Digite a posição inicial do primeiro robô: \n Sendo dois dígitos e uma letra. \n Os dígitos são de 0 a 5. \n Cada letra representa um ponto cardeal: \n N - Norte.\n S - Sul. \n O - Oeste. \n L - Leste. \n");
            Console.WriteLine("Digite o valor do primeiro dígito: ");
            posicaoX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo dígito: ");
            posicaoY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a letra: ");
            direcao = Convert.ToChar(Console.ReadLine());
            #endregion
            #region Coleta de dados iniciais dos robôs
            Console.WriteLine("\nDigite a posição inicial do segundo robô: \n Sendo dois dígitos e uma letra. \n Os dígitos são de 0 a 5. \n Cada letra representa um ponto cardeal: \n N - Norte.\n S - Sul. \n O - Oeste. \n L - Leste. \n");
            Console.WriteLine("Digite o valor do primeiro dígito: ");
            posicaoYdois = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo dígito: ");
            posicaoXdois = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a letra: ");
            direcao2 = Convert.ToChar(Console.ReadLine());


            Console.Clear();
            Console.WriteLine("A posição do primeiro robô é de " + posicaoX + posicaoY + direcao);
            Console.WriteLine("A posição do segundo robô é de " + posicaoYdois + posicaoXdois + direcao2);
            #endregion
            #region Coleta de comandos dos robôs
            Console.WriteLine("Agora vamos digitar os comandos de exploração do nosso primeiro robô.");
            Console.WriteLine("Sendo eles: \n");
            Console.WriteLine("Caso deseje mudar a direção do robô:\n M - Mover. \n E - Virar 90º à esquerda. \n D - Virar 90º à direita.\n F - Se deseja finalizar a expedição. ");

            string coordenada1 = Console.ReadLine()!;

            char[] coordenada = coordenada1.ToCharArray();

            Console.WriteLine("Agora vamos digitar os comandos de exploração do nosso segundo robô.");
            Console.WriteLine("Sendo eles: \n");
            Console.WriteLine("Caso deseje mudar a direção do robô:\n M - Mover. \n E - Virar 90º à esquerda. \n D - Virar 90º à direita.\n F - Se deseja finalizar a expedição. ");

            string coordenada2 = Console.ReadLine()!;

            char[] coordenada3 = coordenada2.ToCharArray();
            #endregion
            #region Laço de repetição dos comandos do primeiro robô
            for (int i = 0; i < Convert.ToInt32(coordenada.Length); i++)
            {
                if (coordenada[i] == 'E' && direcao == 'O')
                {
                    direcao = 'S';
                }
                else if (coordenada[i] == 'D' && direcao == 'O')
                {
                    direcao = 'N';
                }
                else if (coordenada[i] == 'E' && direcao == 'N')
                {
                    direcao = 'O';
                }
                else if (coordenada[i] == 'D' && direcao == 'N')
                {
                    direcao = 'L';
                }
                else if (coordenada[i] == 'D' && direcao == 'L')
                {
                    direcao = 'S';
                }
                else if (coordenada[i] == 'E' && direcao == 'L')
                {
                    direcao = 'N';
                }
                else if (coordenada[i] == 'E' && direcao == 'S')
                {
                    direcao = 'L';
                }
                else if (coordenada[i] == 'D' && direcao == 'S')
                {
                    direcao = 'O';
                }
                if (coordenada[i] == 'M' && direcao == 'O')
                {
                    posicaoX--;
                }
                else if (coordenada[i] == 'M' && direcao == 'N')
                {
                    posicaoY++;
                }
                else if (coordenada[i] == 'M' && direcao == 'L')
                {
                    posicaoX++;
                }
                else if (coordenada[i] == 'M' && direcao == 'S')
                {
                    posicaoY--;
                }
                #endregion
            #region Laço de repetição do segundo robô
            }
            for (int j = 0; j < Convert.ToInt32(coordenada3.Length); j++)
            {
                if (coordenada3[j] == 'E' && direcao2 == 'O')
                {
                    direcao2 = 'S';
                }
                else if (coordenada3[j] == 'D' && direcao2 == 'O')
                {
                    direcao2 = 'N';
                }
                else if (coordenada3[j] == 'E' && direcao2 == 'N')
                {
                    direcao2 = 'O';
                }
                else if (coordenada3[j] == 'D' && direcao2 == 'N')
                {
                    direcao2 = 'L';

                }
                else if (coordenada3[j] == 'D' && direcao2 == 'L')
                {
                    direcao2 = 'S';
                }
                else if (coordenada3[j] == 'E' && direcao2 == 'L')
                {
                    direcao2 = 'N';
                }
                else if (coordenada3[j] == 'E' && direcao2 == 'S')
                {
                    direcao2 = 'L';
                }
                else if (coordenada3[j] == 'D' && direcao2 == 'S')
                {
                    direcao2 = 'O';
                }
                if (coordenada3[j] == 'M' && direcao2 == 'O')
                {
                    posicaoYdois--;
                }
                else if (coordenada3[j] == 'M' && direcao2 == 'N')
                {
                    posicaoXdois++;
                }
                else if (coordenada3[j] == 'M' && direcao2 == 'L')
                {
                    posicaoYdois++;
                }
                else if (coordenada3[j] == 'M' && direcao2 == 'S')
                {
                    posicaoXdois--;
                }
            }
            #endregion
            #region Posição final dos robôs
            Console.WriteLine("O primeiro robô está na posição " + posicaoX + posicaoY + direcao);
            Console.ReadLine();
            Console.WriteLine("O segundo robô está na posição " + posicaoYdois + posicaoXdois + direcao2);
            Console.ReadLine();
            #endregion
        }
    }
}