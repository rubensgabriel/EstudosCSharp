using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
  public class ContaCorrente
  {
    public string titular;
    public string conta;
    public string agencia;
    public double saldo;
  }

  public void Depositar(double valor)
  {
    this.saldo += valor;
  }

  public void Sacar(double valor)
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
}
