namespace Robot.DeuCerto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            char posicao, posicao2;
            int x = 0, y = 0, x1 = 0, y1 = 0;

            Console.WriteLine("--- Let's begin our exploration in Mars ---");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Digite a posição inicial do primeiro robô: \n Sendo dois dígitos e uma letra. \n Os dígitos são de 0 a 5. \n Cada letra representa um ponto cardeal: \n N - Norte.\n S - Sul. \n O - Oeste. \n L - Leste. \n");
            Console.WriteLine("Digite o valor do primeiro dígito: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo dígito: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a letra: ");
            posicao = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nDigite a posição inicial do segundo robô: \n Sendo dois dígitos e uma letra. \n Os dígitos são de 0 a 5. \n Cada letra representa um ponto cardeal: \n N - Norte.\n S - Sul. \n O - Oeste. \n L - Leste. \n");
            Console.WriteLine("Digite o valor do primeiro dígito: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo dígito: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a letra: ");
            posicao2 = Convert.ToChar(Console.ReadLine());


            Console.Clear();
            Console.WriteLine("A posição do primeiro robô é de " + x + y + posicao);
            Console.WriteLine("A posição do segundo robô é de " + x1 + y1 + posicao2);
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

            for (int i = 0; i < Convert.ToInt32(coordenada.Length); i++)
            {
                if (coordenada[i] == 'E' && posicao == 'O')
                {
                    posicao = 'S';
                }
                else if (coordenada[i] == 'D' && posicao == 'O')
                {
                    posicao = 'N';
                }
                else if (coordenada[i] == 'E' && posicao == 'N')
                {
                    posicao = 'O';
                }
                else if (coordenada[i] == 'D' && posicao == 'N')
                {
                    posicao = 'L';
                }
                else if (coordenada[i] == 'D' && posicao == 'L')
                {
                    posicao = 'S';
                }
                else if (coordenada[i] == 'E' && posicao == 'L')
                {
                    posicao = 'N';
                }
                else if (coordenada[i] == 'E' && posicao == 'S')
                {
                    posicao = 'L';
                }
                else if (coordenada[i] == 'D' && posicao == 'S')
                {
                    posicao = 'O';
                }
                if (coordenada[i] == 'M' && posicao == 'O')
                {
                    x--;
                }
                else if (coordenada[i] == 'M' && posicao == 'N')
                {
                    y++;
                }
                else if (coordenada[i] == 'M' && posicao == 'L')
                {
                    x++;
                }
                else if (coordenada[i] == 'M' && posicao == 'S')
                {
                    y--;
                }

            }
            for (int j = 0; j < Convert.ToInt32(coordenada3.Length); j++)
            {
                if (coordenada3[j] == 'E' && posicao2 == 'O')
                {
                    posicao2 = 'S';
                }
                else if (coordenada3[j] == 'D' && posicao2 == 'O')
                {
                    posicao2 = 'N';
                }
                else if (coordenada3[j] == 'E' && posicao2 == 'N')
                {
                    posicao2 = 'O';
                }
                else if (coordenada3[j] == 'D' && posicao2 == 'N')
                {
                    posicao2 = 'L';

                }
                else if (coordenada3[j] == 'D' && posicao2 == 'L')
                {
                    posicao2 = 'S';
                }
                else if (coordenada3[j] == 'E' && posicao2 == 'L')
                {
                    posicao2 = 'N';
                }
                else if (coordenada3[j] == 'E' && posicao2 == 'S')
                {
                    posicao2 = 'L';
                }
                else if (coordenada3[j] == 'D' && posicao2 == 'S')
                {
                    posicao2 = 'O';
                }
                if (coordenada3[j] == 'M' && posicao2 == 'O')
                {
                    x1--;
                }
                else if (coordenada3[j] == 'M' && posicao2 == 'N')
                {
                    y1++;
                }
                else if (coordenada3[j] == 'M' && posicao2 == 'L')
                {
                    x1++;
                }
                else if (coordenada3[j] == 'M' && posicao2 == 'S')
                {
                    y1--;
                }
            }

            Console.WriteLine("O primeiro robô está na posição " + x + y + posicao);
            Console.ReadLine();
            Console.WriteLine("O segundo robô está na posição " + x1 + y1 + posicao2);
            Console.ReadLine();
        }
    }
}