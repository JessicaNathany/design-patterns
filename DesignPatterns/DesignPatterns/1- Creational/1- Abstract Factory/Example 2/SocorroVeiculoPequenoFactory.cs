namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_2
{
    public class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
