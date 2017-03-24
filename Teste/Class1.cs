using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Class1
    {
            public static void morte()
            {

                int minimo = 9999;
                int[] posicoes = new int[4] { 1, 6, 9, 14 };
                int bomba = 8;
                int menorindice = -1;

                for (int i = 0; i < posicoes.Length; i++)
                {
                    int distancia = Math.Abs(bomba - posicoes[i]);
                    if (distancia < minimo)
                    {
                        minimo = distancia;
                        menorindice = i;
                    }
                }

                if (menorindice >= 0)
                {
                    Console.WriteLine("o mais proxima a {0} é {1}", bomba, posicoes[minimo]);
                }
                else
                {
                    Console.WriteLine("Nao achei o mais proximo a {0}", bomba);
                }

                Console.ReadKey();
            }

            public static void buscabinaria()
            {
                int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                int alvo = 5;
                //int indice = -1;
                int inicioarray = 0;
                int finalarray = 10;

                while (inicioarray <= finalarray)
                {
                    int meio = (inicioarray + finalarray) / 2;

                    if (alvo != numeros[meio] && alvo > numeros[meio])
                    {
                        inicioarray = meio;
                    }
                    else if (alvo != numeros[meio] && alvo < numeros[meio])
                    {
                        finalarray = meio;
                    }
                    else
                    {
                        Console.WriteLine("Voce achou o numero");
                        break;
                    }
                    Console.ReadKey();
                }
            }
        }
    }