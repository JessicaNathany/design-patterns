using System;
using System.Collections.Generic;
using System.Text;
using ContaCorrente = DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1.ContaCorrente;

namespace DesignPatterns_1_Creational_1_Abstract_Factory.Exemplo_1
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            Console.WriteLine("Digite 1 para Conta Corrente ou 2 para Conta Investimento: ");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
               // a opção do usuário fará com que seja selecionado o tipo de criação de conta

            }
        }

    }
}
