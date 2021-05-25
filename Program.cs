using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("O que deseja fazer?\n");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Divisao\n4-Multiplicação\n5-Sair");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Selecione uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {
            Console.Clear();
            Console.Write("Digite um valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"a soma dos valores é: { v1 + v2 }");
            Console.WriteLine("\n\nPressione qualquer tecla pra voltar ao menu...");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"A subtracao é: {v1 - v2}");
            Console.WriteLine("\n\nPressione qualquer tecla pra voltar ao menu...");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());


            if (v2 <= 0)
            {
                Console.WriteLine("Divisão não pode ser feita com 0, tente novamente!");
                Console.ReadKey();
                Divisao();
            }
            else
            {
                Console.WriteLine($"A divisão é: {v1 / v2}");
                Console.WriteLine("\n\nPressione qualquer tecla pra voltar ao menu...");
                Console.ReadKey();
                Menu();
            }
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"A multiplicacao é: {v1 * v2}");
            Console.WriteLine("\n\nPressione qualquer tecla pra voltar ao menu...");
            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            Environment.Exit(1);
        }
    }
}
