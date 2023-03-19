using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Calculator
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolherSair = false;
            while(!escolherSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções:");
                Console.WriteLine("1 - Soma\n2 - Subtracao\n3 - Divisao\n4 - Multiplicacao\n5 - Potencia\n6 - Raiz\n7 - Sair");
                Console.Write($"#\nOpção selecionada <ENTER>: ");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                /*
                string opcaoTxt = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoTxt);
                Menu opcao = (Menu)opcaoInt;    
                */

                switch (opcao)
                {
                    case Menu.Soma:
                        Console.Clear();
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Console.Clear();
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Console.Clear();
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Console.Clear();
                        Multiplicação();
                        break;
                    case Menu.Potencia:
                        Console.Clear();
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Console.Clear();
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolherSair = true;
                        break;
                }


                Console.Clear();
            }
        }   

        static void Soma()
        {
            Console.WriteLine("Soma de dois números!");
            Console.WriteLine("#");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a + (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("#");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números!");
            Console.WriteLine("#");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a - (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("#");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números!");
            Console.WriteLine("#");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("#");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Multiplicação()
        {
            Console.WriteLine("Multiplicação de dois números!");
            Console.WriteLine("#");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a * (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("#");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de um número!");
            Console.WriteLine("#");
            Console.Write("Digite o número base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expoente);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("#");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um número!");
            Console.WriteLine("#");
            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("#");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
    }
}
