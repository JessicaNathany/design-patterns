using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1
{
    public class CarroClassicoFactory : IAbstractFactory
    {
        public void CriarCarroceria()
        {
            throw new NotImplementedException();
        }

        public void CriarMotor()
        {
            throw new NotImplementedException();
        }

        public void CriarPintura()
        {
            throw new NotImplementedException();
        }

        public void CriarRodas()
        {
            throw new NotImplementedException();
        }
    }
}
