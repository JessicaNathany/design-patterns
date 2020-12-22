namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1
{
    /// <summary>
    /// Classe AbstractFactory
    /// </summary>
    public abstract class BankFactory
    {
        public abstract CurrenteAccount CreateContaCorrente(string cpf, string nome, string endereco);

        public abstract InvestimentAccount CreateContaInvetimento(string cpf, string nome, string endereco, double renda);
    }
}
