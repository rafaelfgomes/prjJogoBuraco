using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjBuraco
{
    class Program
    {

        static string[] cartasDoJogo = new string[104];
        static string[,] cartasDaMao = new string[11, 4];
        static Random rnd = new Random();
        static bool flag = true;
        static int qtdSorteio = 0;

        static void Main(string[] args)
        {

            Console.Write("#############################################\n");
            Console.Write("#           PROJETO JOGO BURACO             #\n");
            Console.Write("#############################################\n");
            Console.WriteLine();

            Console.Write("Iniciando o jogo....\n\n");

            System.Threading.Thread.Sleep(3000);

            Console.Write("Criando as cartas do baralho...\n\n");

            System.Threading.Thread.Sleep(3000);

            gerarCartas();

            Console.WriteLine();

            Console.Write("Distribuindo as cartas...\n\n");

            System.Threading.Thread.Sleep(3000);

            distribuirCartas();

            Console.WriteLine();

            Console.Write("Cartas distribuidas...\n\n");

            System.Threading.Thread.Sleep(3000);

            mostrarMaos();

            Console.WriteLine();

            Console.Write("Pronto!!! O jogo já pode iniciar...");

            Console.ReadKey();

        }

        static void gerarCartas()
        {

            int cont = 0, idx1 = 0, idx2 = 0;

            Console.Write("Cartas do baralho:");
            Console.Write("\n\n");
            
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 4; j++)
                {

                    for (int k = 0; k < 13; k++)
                    {

                        cartasDoJogo[cont] = String.Format("{0}{1:00}{2}", j + 1, k + 1, i + 1);                        
                        cont++;
                    }

                }

            }

            idx1 = 0;
            idx2 = 0;

            for (int m = 0; m < 13; m++)
            {

                Console.Write("\t");

                for (int n = 0; n < 8; n++)
                {

                    Console.Write("{0}\t", cartasDoJogo[idx2]);

                    idx2 += 13;

                }

                Console.WriteLine();

                idx1++;
                idx2 = 0;
                idx2 = idx1 + idx2;

            }

        }

        static void distribuirCartas()
        {

            int index = 0;

            for (int i = 0; i < 11; i++)
            {

                for (int j = 0; j < 4; j++)
                {

                    index = rnd.Next(0, 104);

                    if ((i == 0) && (j == 0))
                    {

                        cartasDaMao[i, j] = cartasDoJogo[index];
                        cartasDoJogo[index] = "";

                    }
                    else
                    {

                        if (cartaInedita(cartasDoJogo[index]))
                        {

                            cartasDaMao[i, j] = cartasDoJogo[index];
                            cartasDoJogo[index] = "";

                        }
                        else
                        {

                            do
                            {

                                index = rnd.Next(0, 104);

                                if (cartaInedita(cartasDoJogo[index]))
                                {

                                    cartasDaMao[i, j] = cartasDoJogo[index];
                                    cartasDoJogo[index] = "";
                                    flag = false;

                                }
                                else
                                {

                                    flag = true;

                                }

                            } while (flag);


                        }

                    }

                    Console.Write("Distribuicao: {0} - Jogador: {1} - Carta: {2}", i + 1, j + 1, cartasDaMao[i, j]);
                    Console.WriteLine();

                }

            }

            Console.WriteLine();
            Console.Write("Qtde de sorteios realizados: {0}", qtdSorteio);
            Console.WriteLine();

        }

        static void organizarMaos()
        {

            for (int i = 0; i < 11; i++)
            {

                for (int j = 0; j < 4; j++)
                {

                    Console.Write("{0}\t", cartasDaMao[i, j]);

                }

                Console.WriteLine();

            }

        }

        static void mostrarMaos()
        {

            Console.Write("Jog: 1\tJog:2\tJog: 3\tJog: 4\n\n");

            organizarMaos();

        }

        static bool cartaInedita(string carta)
        {

            qtdSorteio++;

            if (carta == "")
            {

                return false;

            }
            else
            {

                return true;

            }

        }

    }

}
