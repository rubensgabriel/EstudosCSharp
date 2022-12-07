using System;
class Programa
{
    static void Main(string[] args)
    {
        string nome;
        int idade;

        Console.WriteLine("Informe seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Informe sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Olá, {nome} sua idade é {idade}");
        Console.ReadKey(true);
    }
}
