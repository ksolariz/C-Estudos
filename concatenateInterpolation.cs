using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "Kauê ";
            string sobrenome = "Soares Ferreira";
            string nomeCompleto = nome + sobrenome;
            //interpolacao + concatenando strings
            Console.WriteLine($"Olá, {nomeCompleto}");
            Console.WriteLine("Aprendendo a concatenar strings!");
        }
    }
}
