using Xunit;

namespace DemoUnitTestLibrary.Test
{
    public class CalculusTests
    {
        [Fact]
        public void SumarExpectedReturn()
        {
            // Arrange
            // Calculus calculus = new();
            double expected = 10;

            // Act
            double actual = Calculus.Sumar(5,5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RestarExpectedReturn()
        {
            // Arrange
            //Calculus calculus = new();
            double expected = 0;

            // Act
            double actual = Calculus.Restar(5, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        // InlineData @params > a, b, expected
        [InlineData(5,5,25)]
        [InlineData(5, 0, 0)]
        [InlineData(5, -5, -25)]
        public void MultiplicarExpectedReturn(double a, double b, double expected)
        {
            // Arrange
            //Calculus calculus = new();

            // Act
            double actual = Calculus.Multiplicar(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        // InlineData @params > a, b, expected
        [InlineData(5, 5, 1)]
        [InlineData(5, 0, 0)]
        [InlineData(10, -2, -5)]
        public void DividirExpectedReturn(double a, double b, double expected)
        {
            // Arrange
            //Calculus calculus = new();

            // Act
            double actual = Calculus.Dividir(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
