using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculatorLybrary
{
    // Вычисление площади треуголника по длине трех сторон (формула Герона).
    public class Triangle : IShape
    {
        private readonly double _sideA, _sideB, _sideC;

        // также выполняем проверку корректности значений и возможность существования треугольника.
        public Triangle(double sideA, double sideB, double sideC)
        {

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Стороны треугольника должны быть положительными числами");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Неравенство треугольника не выполняется");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        // определение является ли треугольник прямоугольным (теорема Пифагора).
        public bool IsRightAngled()
        {
            double[] sides = { _sideA, _sideB, _sideC };
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
