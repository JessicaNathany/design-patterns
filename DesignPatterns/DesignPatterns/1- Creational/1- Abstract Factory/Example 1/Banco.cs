using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1
{
    public class Banco
    {
        private readonly CurrenteAccount _contaCorrente;
        private readonly InvestimentAccount _contaInvestimento;

        public Banco(BankFactory factory, CurrenteAccount contaCorrente, InvestimentAccount contaInvestimento)
        {
            _contaCorrente = factory.CriarContaCorrente(contaCorrente.Nome, contaCorrente.CPF, contaCorrente.Endereco);
            _contaInvestimento = factory.CriarContaInvetimento(contaCorrente.Nome, contaCorrente.CPF, contaCorrente.Endereco, contaInvestimento.Renda);
        }

       
    }
}
