using System.Diagnostics.CodeAnalysis;
using MuTestDemo;
using NUnit.Framework;
using Shouldly;

namespace MuTestDemoTests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SchoolOfMutantsTests
    {
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 4)]
        [TestCase(4, 4)]
        [TestCase(9, 5)]
        [TestCase(16, 10)]
        [TestCase(24, 14)]
        [TestCase(81, 82)]
        public void TrainMutants_WhenCalled_VerifyMutants(int mutantCounts, int expected)
        {
            // Arrange
            var instance = new SchoolOfMutants(new Log());

            // Act
            var result = instance.TrainMutants(mutantCounts);

            // Assert
            result.ShouldBe(expected);
        }
    }
}
