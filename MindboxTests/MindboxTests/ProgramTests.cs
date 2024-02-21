using Mindbox;

namespace MindboxTests
{
    using Xunit;

    public class ShapeLibraryTests
    {
        [Fact]
        public void CircleAreaCalculation()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.Equal(Math.PI * 25, area, 4);
        }

        [Fact]
        public void TriangleAreaCalculation()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, area, 4);
        }

        [Fact]
        public void RightAngledTriangleCheck()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }
    }
}