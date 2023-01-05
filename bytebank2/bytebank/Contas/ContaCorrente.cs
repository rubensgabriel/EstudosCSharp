﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bytebank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas {get; private set;}
        private int numero_agencia;
        public int Numero_Agencia
        {
            get {return this.numero_agencia;}
            private set {
                if (value > 0)
                {
                    this.numero_agencia = value;
                } 
                }
        }
        // private string conta;
        public string Conta {get; set;}
        private double saldo; //é possível declarar um valor para a variavel diretamente daqui
        public Cliente Titular {get; set;}

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_Agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }

        public void ExibirDadosDaConta()
        {
            //Console.WriteLine("Titular: " + titular);
            //Console.WriteLine("Conta: " + conta);
            //Console.WriteLine("Número da agência: " + numero_agencia);
            //Console.WriteLine("Saldo: " + saldo);
        }
    }

}

