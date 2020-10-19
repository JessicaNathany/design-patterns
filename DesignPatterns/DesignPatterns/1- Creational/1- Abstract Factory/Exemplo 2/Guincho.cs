using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_2
{
    public abstract class Guincho
    {
        public abstract void Socorrer(Veiculo veiculo);
        public Porte Porte { get; set; }
        protected Guincho(Porte porte)
        {
            Porte = Porte;
        }
    }

    // Produto concreto
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo carro pequeno - Modelo " + veiculo.Modelo);
        }
    }

    // Produto concreto
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Medio - Modelo " + veiculo.Modelo);
        }
    }

    // Produto Concreto
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Grande - Modelo " + veiculo.Modelo);
        }
    }

    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);
                case Porte.Medio:
                    return new GuinchoMedio(porte);
                case Porte.Grande:
                    return new GuinchoGrande(porte);
                default:
                    throw new ApplicationException("Porte de Guincho desconhecido.");
            }
        }
    }
}
