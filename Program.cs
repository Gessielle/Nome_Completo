using System;

namespace Nome_Completo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome" );
            sobrenome = Console.ReadLine();
            Console.Write("\n");

            Console.Write($"Nome Completo: {nome} {sobrenome}");
            Console.Write("\n");

            Console.WriteLine($"Nome de catálago: {sobrenome.ToUpper()}, {nome}");
            Console.Write("\n");

            Console.WriteLine("Pressione Enter para sair");
            Console.ReadKey();
            


        }
    }
}
