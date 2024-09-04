using ShapeAreaCalculatorLybrary;

namespace ShapeAreaCalculatorLybraryTest
{
        public class CircleTests
        {

            [Test]
            public void ChekingCalculateArea()
            {
                Assert.That(new Circle(5).CalculateArea(), Is.EqualTo(78.53981633974483));
            }

            [Test]
            public void ChekingExceptionForNegativeRadius()
            {
                 Assert.That(() => new Circle(-5), Throws.ArgumentException);
        }



    }
}