using System;
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
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(9)]
        [TestCase(16)]
        [TestCase(24)]
        [TestCase(81)]
        public void TrainMutants_WhenCalled_VerifyMutants(int mutantCounts)
        {
            // Arrange
            var instance = new SchoolOfMutants(new Log());

            // Act
            Action action = () => instance.TrainMutants(mutantCounts);

            // Assert
            action.ShouldNotThrow();
        }
    }
}
