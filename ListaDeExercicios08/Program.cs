using System;
using System.Globalization;

namespace ListaDeExercicios08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aluguéis
            
            Alugueis[] quartos = new Alugueis[10];

            Console.Write("Quantos aluguéis vão ser registrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                quartos[quarto] = new Alugueis(nome, email);
            }
            Console.WriteLine("\nAluguéis:");
            for (int i = 0; i < quartos.Length; i++ )
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i}: {quartos[i]}");
                }
            }
        }
    }
}