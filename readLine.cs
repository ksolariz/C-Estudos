using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nomePessoa = null;
            Console.WriteLine("Digite o nome da pessoa:");

            //Lê oque foi digitado e armazena na var
            nomePessoa = Console.ReadLine();
            Console.WriteLine(nomePessoa);
        }
    }
}
