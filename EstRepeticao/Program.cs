using System;

namespace EstRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface();
            Console.Write("\n");
            int opcao = int.Parse(Console.ReadLine());

            int alc = 0;
            int gas = 0;
            int die = 0;

            

            while (opcao != 4) {
                opcao = Validacao(opcao);

                if (opcao == 1) {
                    alc += 1;
                } else if(opcao == 2) {
                    gas += 1;
                } else if(opcao == 3) {
                    die += 1;
                }

                Console.Write("Escolha outra opção ou digite 4 para sair: ");
                opcao = int.Parse(Console.ReadLine());
                opcao = Validacao(opcao);
            }

            Console.WriteLine("\n-----SCORE TOTAL DA PESQUISA-----");
            Console.WriteLine($"#Alcool: {alc}");
            Console.WriteLine($"#Gasolina: {gas}");
            Console.WriteLine($"#Diesel: {die}");
        }

        static void Interface()
        {
            Console.WriteLine("-----TIPOS DE COMBUSTIVEIS-----");
            Console.WriteLine("escolha a opção de sua preferência\n");
            Console.WriteLine("1. Alcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. fim");
        }

        static int Validacao(int num)
        {
            while (num < 1 || num > 4) {
                Console.Write("Opção invalida! Digite novamente: ");
                num = int.Parse(Console.ReadLine());
            }
            return num;
        }
    }
}
