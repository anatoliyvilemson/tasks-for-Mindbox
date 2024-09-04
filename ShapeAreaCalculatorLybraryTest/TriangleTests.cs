using ShapeAreaCalculatorLybrary;

namespace ShapeAreaCalculatorLybraryTest
{
    public class TriangleTests
    {
       
        [Test]
        public void ChekingCalculateArea()
        {

            Assert.That(new Triangle(3, 5, 6).CalculateArea(), Is.EqualTo(7.483314773547883));
        }

        [Test]
        public void ChekingExceptionForNegativeSide()
        {
            Assert.That(() => new Triangle(-1, 2, 3), Throws.ArgumentException);
        }

        [Test]
        public void ChekingIsRightAngled()
        {
            Assert.That(new Triangle(3, 4, 5).IsRightAngled(), Is.True); 
        }

    }
}