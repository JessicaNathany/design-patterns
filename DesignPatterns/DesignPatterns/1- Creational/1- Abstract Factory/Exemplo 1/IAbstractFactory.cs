using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1
{
    /// <summary>
    /// Classe fábrica abstrata declara um conjunto de métodos que retorna 
    /// diferentes produtos abstratos
    /// </summary>
    public interface IAbstractFactory
    {
        public void CriarCarroceria();

        public void CriarPintura();

        public void CriarMotor();

        public void CriarRodas();
    }
}
