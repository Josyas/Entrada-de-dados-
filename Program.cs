using System;
using System.Globalization;

namespace Exercicio_Entrada_de_dados {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo: ");
            string completename = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sau casa? ");
            int totrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade, altura(mesma linha): ");
            string[] v = Console.ReadLine().Split(' ');
            string forname = v[0];
            string age = v[1];
            string height = v[2];
            


            Console.WriteLine(completename);
            Console.WriteLine(totrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(forname);
            Console.WriteLine(age);
            Console.WriteLine(height);

        }
    }
}
