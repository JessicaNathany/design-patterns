namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1
{
    /// <summary>
    /// Classe AbstractFactory
    /// </summary>
    public abstract class BancoFactory
    {
        public abstract ContaCorrente CriarContaCorrente(string cpf, string nome, string endereco);

        public abstract ContaInvestimento CriarContaInvetimento(string cpf, string nome, string endereco, double renda);
    }
}
