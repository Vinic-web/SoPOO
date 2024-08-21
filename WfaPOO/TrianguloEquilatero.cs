using System;

namespace WfaPOO
{
    public class TrianguloEquilatero : Triangulo
    {
        private int _base;
        public int _Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public override double CalcularArea()
        {
            return ((Math.Sqrt(3)/ 4) * Math.Pow(_base, 2));
        }

        public override double CalcularPerimetro()
        {
            return 3 * _Base;
        }
    }
}
