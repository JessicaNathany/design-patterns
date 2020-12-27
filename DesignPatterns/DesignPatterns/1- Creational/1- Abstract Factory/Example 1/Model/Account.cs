namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1
{
    public class Account
    {
        public string Name  { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
        public TypeAccount TypeAccount { get; set; }
    }
    public enum TypeAccount
    {
        CurrentAccount = 1,
        Savings = 2
    }
}
