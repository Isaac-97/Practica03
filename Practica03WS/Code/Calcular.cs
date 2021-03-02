using System;

namespace Practica03WS.Code
{
    public class Calcular
    {

        public double CalcularAreaCuadrado(int _lado)
        {
            var result = _lado * _lado;
            return result;
        }

        public double CalcularAreaTriangulo(int _base, int _altura)
        {
            var result = (_base * _altura) / 2;
            return result;
        }

        public double CalcularAreaCirculo(int _r)
        {
            var result = Math.PI * Math.Pow(_r, 2);
            return result;
        }

    }
}