using bytebank;

ContaCorrente conta5 = new ContaCorrente(283,"1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

// ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
// conta4.SetSaldo(500);
// conta4.Titular = new Cliente();

// Console.WriteLine(conta4.GetSaldo());
// Console.WriteLine(conta4.Numero_agencia);


// ========= Utilizando propriedades e métodos =========

// ContaCorrente conta3 = new ContaCorrente();
// conta3.Numero_Agencia = 18;
// conta3.Conta = "1011-H";
// conta3.SetSaldo(200);

// Console.WriteLine(conta3.GetSaldo());
// Console.WriteLine(conta3.Numero_Agencia);
// Console.WriteLine(conta3.Conta);


// ========= CRIAÇÃO DE CONTA E CLIENTE =========

// Cliente cliente = new Cliente();
// cliente.nome ="Rubens Rodrigues";
// cliente.Cpf="12321114521";
// cliente.profissao = "Analista";

// ContaCorrente conta = new ContaCorrente();
// conta.titular = cliente;
// conta.conta = "1020-X";
// conta.numero_agencia = 15;
// conta.saldo = 100;

// ContaCorrente conta2 = new ContaCorrente();
// conta2.titular = new Cliente();
// conta2.titular.nome = "José Souza";
// conta2.titular.profissao = "Tester";
// conta2.titular.Cpf = "987654321";
// conta2.conta = "9999-X";
// conta2.numero_agencia = 18;
// conta2.saldo = 500;

// Console.WriteLine(conta2.titular.nome);

// Console.WriteLine("Titular: " + conta.titular.nome);
// Console.WriteLine("CPF: " + conta.titular.Cpf);
// Console.WriteLine("Profissão: " + conta.titular.profissao);
// Console.WriteLine("Nº Conta: " + conta.conta);
// Console.WriteLine("Saldo: " + conta.saldo);
// Console.WriteLine("Nº Agência: " + conta.numero_agencia);


// ===== Transferencia entre a conta do Gabriel e da Júlia =====

// ContaCorrente contaDoGabriel = new ContaCorrente();
// contaDoGabriel.titular = "Gabriel Souza";
// contaDoGabriel.numero_agencia = 13;
// contaDoGabriel.conta = "2030-X";
// contaDoGabriel.saldo = 300;

// Console.WriteLine("Saldo da conta do Gabriel = " + contaDoGabriel.saldo);

// ContaCorrente contaDaJulia = new ContaCorrente();
// contaDaJulia.titular = "Julia Gomes";
// contaDaJulia.numero_agencia = 11;
// contaDaJulia.conta = "1123-X";
// contaDaJulia.saldo = 420;

// Console.WriteLine("Saldo da conta da Júlia = " + contaDaJulia.saldo);

// Console.WriteLine("Informe o valor que deseja transferir para a conta da Júlia");
// double transferencia = Convert.ToDouble(Console.ReadLine());

// contaDoGabriel.Transferir(transferencia, contaDaJulia);

// contaDoGabriel.ExibirDadosDaConta();
// contaDaJulia.ExibirDadosDaConta();

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

/* DESAFIO 2 - Cadastro de pessoa em sistema médico

namespace sistema_medico
{
    public void Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        public double peso;
    }
}

Console.WriteLine(pessoa.nome);
Console.WriteLine(pessoa.idade);
Console.WriteLine(pessoa.altura);
Console.WriteLine(pessoa.peso);

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