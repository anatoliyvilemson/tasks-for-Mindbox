using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculatorLybrary
// Вычисление площади круга по радиусу. 
{
    public class Circle : IShape
    {
        private readonly double _radius;
        
        // также выполняем проверку корректности значений
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус круга должен быть положительным числом");

            _radius = radius;
        }

        public double CalculateArea() => Math.PI * Math.Pow(_radius, 2);
    }
}
