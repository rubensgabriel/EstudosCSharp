using System;

namespace meuPrimeirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pedido;
            double

            Console.WriteLine("====================================");
            Console.WriteLine("==  Bem vindo à nossa lanchonete  ==");
            Console.WriteLine("====================================");
            Console.WriteLine(" 100 - Cachorro Quente       R$1,20");
            Console.WriteLine(" 101 - Bauru Simples         R$1,30");
            Console.WriteLine(" 102 - Bauru com Ovo         R$1,50");
            Console.WriteLine(" 103 - Hamburguer            R$1,20");
            Console.WriteLine(" 104 - Cheeseburguer         R$1,70");
            Console.WriteLine(" 105 - Suco                  R$2,20");
            Console.WriteLine(" 106 - Refrigerante          R$1,00");
            Console.WriteLine("             S - SAIR              ");
            Console.WriteLine("====================================");
            Console.WriteLine("Favor informe seu pedido ");
            pedido = Console.ReadLine();
            switch(pedido)
            {
                case "100" :
                Console.WriteLine("Pedido nº 100 escolhido");
                Console.WriteLine("Favor informe a quantidade");
                break;
            }
        }
    }
}
