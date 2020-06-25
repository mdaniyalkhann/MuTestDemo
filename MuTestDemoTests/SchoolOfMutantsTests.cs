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
        private const int MutantCounts = 1;

        [Test]
        public void TrainMutants_WhenCalled_VerifyMutants()
        {
            // Arrange
            var instance = new SchoolOfMutants(new Log());

            // Act
            Action action = () => instance.TrainMutants(MutantCounts);

            // Assert
            action.ShouldNotThrow();
        }
    }
}
