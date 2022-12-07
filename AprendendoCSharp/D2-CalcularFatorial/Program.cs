using System;
class Programa
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            int num = i;

            for (int j = (num - 1); j >= 1; j--)
            {
                num *= j;
            }
            //mostra o resultado
            Console.WriteLine("Fatorial de " + i + " = " + num);
        }
    }
}
/*
using System;

class Programa
{
    static void Main(String args[])
    {
        int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }
    }
}
*/
