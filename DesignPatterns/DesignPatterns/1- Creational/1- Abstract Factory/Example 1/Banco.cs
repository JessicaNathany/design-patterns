using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1
{
    public class Banco
    {
        private readonly ContaCorrente _contaCorrente;
        private readonly ContaInvestimento _contaInvestimento;

        public Banco(BancoFactory factory, ContaCorrente contaCorrente, ContaInvestimento contaInvestimento)
        {
            _contaCorrente = factory.CriarContaCorrente(contaCorrente.Nome, contaCorrente.CPF, contaCorrente.Endereco);
            _contaInvestimento = factory.CriarContaInvetimento(contaCorrente.Nome, contaCorrente.CPF, contaCorrente.Endereco, contaInvestimento.Renda);
        }

       
    }
}
