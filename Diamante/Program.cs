using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace DesafioDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tamDiamante = 0;
            tamDiamante = definirTamanho();
            while (deveSerImpar(tamDiamante) == false)
            {
                Console.WriteLine("O número digitado é inválido. Tente novamente.");
                tamDiamante = definirTamanho();
            }

            char[,] diamante = new char[tamDiamante, tamDiamante];
            int meio = tamDiamante / 2;
            firtsHalfDiamond(tamDiamante, meio);
            secondHalfDiamond(tamDiamante, meio);
        }

        static bool deveSerImpar(int tamDiamante)
        {
            bool impar = tamDiamante % 2 != 0;
            return impar;
        }

        static int definirTamanho()
        {
            Console.WriteLine("Digite um número ímpar: ");
            int tamDiamante = Convert.ToInt32(Console.ReadLine());
            return tamDiamante;
        }

        static void firtsHalfDiamond(int tamDiamante, int meio)
        {

            for (int i = 0; i <= meio; i++)
            {
                for (int j = 0; j < tamDiamante; j++)
                {
                    if (j >= meio - i && j <= meio + i)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void secondHalfDiamond(int tamDiamante, int meio)
        {
            for (int i = meio - 1; i >= 0; i--)
            {
                for (int j = 0; j < tamDiamante; j++)
                {
                    if (j >= meio - i && j <= meio + i)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

}