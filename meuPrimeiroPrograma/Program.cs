using System;

namespace meuPrimeirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string pedido;
            int quantidade;

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
                quantidade = Convert.ToInt32(Console.ReadLine());
                break;
            }
            */
            // Exemplo de Vetor
            const int cont = 5;
            string aux, resp;
            string[] nomes = new string[cont];
            
            for(int i = 0; i < cont; i++)
            {
                Console.WriteLine("Informe o " + (i+1) + "º nome:");
                nomes[i] = Console.ReadLine();
            }

            Console.Clear();
            for(int i = 0; i < cont; i++)
            {
                Console.WriteLine("Nome [" + i + "] = " + nomes[i]);
            }
            while (resp="sim")
            {
                Console.WriteLine("Digite o nome a ser pesquisado: ");
                resp = Console.ReadLine();
            }

            /*PESQUISA NO VISUALG
            enquanto (resp="sim") faca
            Escreval("Digite o nome a ser pesquisado: ")
            leia(pesq)

            i:=1
            acha:=falso

            enquanto ((i<=20) e (acha=falso)) faca
                se (pesq=nomes[i]) entao
                    acha:=verdadeiro

                senao
                    i:=i+1
                fimse

            fimenquanto


            se (acha=verdadeiro) entao
                Escreval(pesq, " foi localizado na posição ",i)
            senao
                Escreval(pesq, " não foi localizado")
            fimse

            Escreval("Deseja continuar?")
            leia(resp)

            fimenquanto
            */
            
            /* ORDENAÇÃO COM ERRO

            for(int i = 0; i < cont; i++)
            {
                for(int j = i+1; j < 20; j++)
                {
                    if (nomes[i] > nomes[j])
                    {
                        aux = nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = aux;
                    }
                }
            }
            */

            /* ORDENAÇÃO NO VISUALG 

           para i de 1 ate 19 faca
                para j de i+1 ate 20 faca
                se (nomes[i] > nomes[j]) entao
                    X <- nomes[i]
                    nomes[i] <- nomes[j]
                    nomes[j] <- X
                fimse
                fimpara
                fimpara */
        }
    }
}
