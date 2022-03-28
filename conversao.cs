using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = null;
            int idade = 0;
            double salario = 0;

            //Solicitando o nome da pessoa
            Console.WriteLine("Digite seu nome: ");

            //Adicionando o nome na variavel
            nome = Console.ReadLine();

            //Solicitando a idade da pessoa
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            //Solicitando a idade da pessoa
            Console.WriteLine("Digite seu salário: ");
            salario = double.Parse(Console.ReadLine());


            Console.WriteLine($"Seu nome é: {nome}\n Sua idade é: {idade}\n Seu salário é: {salario}");
        }
    }
}
