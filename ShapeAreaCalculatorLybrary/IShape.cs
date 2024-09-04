using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculatorLybrary
{
    // определение базового контракта с методом вычисления площади фигуры 
    public interface IShape
    {
        public double CalculateArea();
    }
}