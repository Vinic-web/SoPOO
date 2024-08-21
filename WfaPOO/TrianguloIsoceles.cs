using System;

namespace WfaPOO
{
    public class TrianguloIsoceles : Triangulo
    {
        private int _base;

        public int _Base
        {
            get { return _base; }
            set { _base = value; }
        }

        private int altura;

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public override double CalcularArea()
        {
            return (_base * altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            double hipotenusa = System.Math.Sqrt(System.Math.Pow(_base, 2) + System.Math.Pow(altura, 2));
            return (_base + (hipotenusa * 2));
        }
    }
}
