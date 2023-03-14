namespace Robot.DeuCerto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                char posicao;
                int x = 0, y = 0;

                Console.Clear();
                Console.WriteLine("--- Let's begin our exploration in Mars ---");
                Console.WriteLine("Digite a posição inicial do nosso robô: \n Sendo dois dígitos e uma letra. \n Os dígitos são de 0 a 5. \n Cada letra representa um ponto cardea: \n N - Norte.\n S - Sul. \n O - Oeste. \n L - Leste. \n");
                Console.WriteLine("Digite o valor do primeiro dígito: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor do segundo dígito: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a letra: ");
                posicao = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Agora vamos digitar os comandos de exploração do nosso robô.");
                Console.WriteLine("Sendo eles: \n");
                Console.WriteLine("Caso deseje mudar a direção do robô:\n M - Mover. \n E - Virar 90º à esquerda. \n D - Virar 90º à direita.\n F - Se deseja finalizar a expedição. ");
                string coordenada1 = Console.ReadLine();

                char[] coordenada = coordenada1.ToCharArray();

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
                        x = x - 1;
                    }
                    else if (coordenada[i] == 'M' && posicao == 'N')
                    {
                        y = y + 1;
                    }
                    else if (coordenada[i] == 'M' && posicao == 'L')
                    {
                        x = x + 1;
                    }
                    else if (coordenada[i] == 'M' && posicao == 'S')
                    {
                        y = y - 1;
                    }

                }

                Console.WriteLine("O robô está na posição " + posicao + x + y);
                Console.ReadLine();
                Console.ReadLine();


                Console.WriteLine("Deseja continuar? Digite S ou N ");
                char ehContinuar = Convert.ToChar(Console.ReadLine());

                if (ehContinuar == 'S')
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            } while (continuar == true);
        }
    }
}