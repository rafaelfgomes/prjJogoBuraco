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

        static void Main(string[] args)
        {

            gerarCartas();

            Console.ReadKey();

        }

        static void gerarCartas()
        {

            int cont = 0;
            
            for (int i = 1; i <= 2; i++)
            {

                for (int j = 1; j <= 4; j++)
                {

                    for (int k = 1; k <= 13; k++)
                    {

                        cartasDoJogo[cont] = String.Format("{0}{1:00}{2}", j, k, i);

                        Console.Write(cartasDoJogo[cont] + " ");
                        cont++;

                    }

                }

            }


        }

        static void distribuirCartas()
        {




        }

        static void organizarMaos()
        {



        }

        static void mostrarMaos()
        {

            

        }

        static bool cartaInedita(string carta)
        {

            return true;

        }

    }

}
