using Xunit;

namespace DemoUnitTestLibrary.Test
{
    public class CalculusTests
    {
        [Fact]
        public void CalculuSumarExpectedReturn()
        {
            // Arrange
            Calculus calculus = new();
            double expected = 10;

            // Act
            double actual = calculus.Sumar(5,5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculuRestarExpectedReturn()
        {
            // Arrange
            Calculus calculus = new();
            double expected = 0;

            // Act
            double actual = calculus.Restar(5, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
