using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WfaPOO
{
    internal class Circunferencia
    {
        private double _base;
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }
        private double altura;
        public double Altura
        {
            get { return altura; }
            set { altura = value; }

        }
        public override double CalcularArea()
        {
            return (_base * altura);
        }

    }
}
