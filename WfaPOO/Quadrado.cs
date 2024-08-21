﻿namespace WfaPOO
{
    public class Quadrado : FormaGeometrica
    {
        private int _base;

        public int _Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public override double CalcularArea()
        {
            // return lado * lado;
            return System.Math.Pow(_base, 2);
        }

        public override double CalcularPerimetro()
        {
            return _base * 4;
        }
    }
}
