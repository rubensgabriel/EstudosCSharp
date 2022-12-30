using bytebank;

ContaCorrente contaDoGabriel = new ContaCorrente();
contaDoGabriel.titular = "Gabriel Souza";
contaDoGabriel.numero_agencia = 13;
contaDoGabriel.conta = "2030-X";
contaDoGabriel.saldo = 300;

Console.WriteLine("Saldo da conta do Gabriel = " + contaDoGabriel.saldo);

ContaCorrente contaDaJulia = new ContaCorrente();
contaDaJulia.titular = "Julia Gomes";
contaDaJulia.numero_agencia = 11;
contaDaJulia.conta = "1123-X";
contaDaJulia.saldo = 420;

Console.WriteLine("Saldo da conta da Júlia = " + contaDaJulia.saldo);

Console.WriteLine("Informe o valor que deseja transferir para a conta da Júlia");
double transferencia = Convert.ToDouble(Console.ReadLine());

contaDoGabriel.Transferir(transferencia, contaDaJulia);
Console.WriteLine("Saldo do Gabriel = " + contaDoGabriel.saldo);
Console.WriteLine("Saldo da Júlia = " + contaDaJulia.saldo);

/* DESAFIO 1 - Criar uma classe para cadastrar os dados de Estoque dos produtos do Supermercado Menor Preço
namespace menor_preco
{
    public class EstoqueProdutos
    {
        public string nome;
        public string fabricante;
        public string codigo_barras;
        public double valor_unit;
        public double valor_compra;
        public int quantidade; 
    }
}
*/

/* SAQUE e DEPÓSITO na conta do Gabriel

Console.WriteLine("Saldo da conta do Gabriel = " + contaDoGabriel.saldo);

Console.WriteLine("Informe o valor que deseja depositar na conta do Gabriel");
double deposito = Convert.ToDouble(Console.ReadLine());

contaDoGabriel.Depositar(deposito);

Console.WriteLine("Informe o valor que deseja sacar");
double saque = Convert.ToDouble(Console.ReadLine());

if (contaDoGabriel.Sacar(saque) == true)
{
    Console.WriteLine("Saldo da conta do André pós saque = " + contaDoGabriel.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque");
}

Console.WriteLine("Saldo da conta do Gabriel pós atividade = " + contaDoGabriel.saldo);
*/