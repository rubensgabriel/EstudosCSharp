using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.14;
        Console.WriteLine("Variável tipo double: " + salario);

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine("Variável tipo int: " + salarioInteiro);

        // O long é um tipo de variável de 64 bits
        long x = 200000000000000;
        Console.WriteLine("Variável tipo long: " + x);

        short y = 1500;
        Console.WriteLine("Variável tipo short: " + y);

        float altura = 1.62f;
        Console.WriteLine("Variável tipo float: " + altura);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
