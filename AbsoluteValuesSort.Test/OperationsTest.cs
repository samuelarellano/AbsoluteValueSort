using Xunit;
using FluentAssertions;
using AutoFixture;
using AutoFixture.Xunit2;
using AbsoluteValueSort.Utils;

namespace AbsoluteValueSort.Tests
{
    public class OperationsTests
    {
        private readonly IOperations _operations;

        public OperationsTests()
        {
            _operations = new Operations();
        }

        [Fact]
        public void AbsSort_ReturnsSortedArray_WithPositiveAndNegativeNumbers()
        {
            // Arrange
            int[] input = { 2, -7, -2, -2, 0 };
            int[] expected = { 0, -2, -2, 2, -7 };

            // Act
            int[] result = _operations.AbsSort(input);

            // Assert
            result.Should().Equal(expected);
        }

        [Fact]
        public void AbsSort_ReturnsEmptyArray_WhenInputIsEmpty()
        {
            // Arrange
            int[] input = { };

            // Act
            int[] result = _operations.AbsSort(input);

            // Assert
            result.Should().BeEmpty();
        }

        [Fact]
        public void AbsSort_ReturnsSameArray_WhenInputHasOneElement()
        {
            // Arrange
            int[] input = { 5 };

            // Act
            int[] result = _operations.AbsSort(input);

            // Assert
            result.Should().Equal(input);
        }

        [Theory, AutoData]
        public void AbsSort_ShouldHandleRandomData(int[] input)
        {
            // Act
            int[] result = _operations.AbsSort(input);

            // Assert
            for (int i = 0; i < result.Length - 1; i++)
            {
                int absCurrent = Math.Abs(result[i]);
                int absNext = Math.Abs(result[i + 1]);

                absCurrent.Should().BeLessOrEqualTo(absNext);

                if (absCurrent == absNext)
                {
                    result[i].Should().BeLessOrEqualTo(result[i + 1]);
                }
            }
        }


        [Theory, AutoData]
        public void AbsSort_ShouldHandleRandomData_WithCustomRules(int[] input)
        {
            // Act
            int[] result = _operations.AbsSort(input);

            // Assert
            for (int i = 0; i < result.Length - 1; i++)
            {
                int absCurrent = Math.Abs(result[i]);
                int absNext = Math.Abs(result[i + 1]);

                absCurrent.Should().BeLessOrEqualTo(absNext);

                if (absCurrent == absNext)
                {
                    result[i].Should().BeLessOrEqualTo(result[i + 1]);
                }
            }
        }
    }
}
