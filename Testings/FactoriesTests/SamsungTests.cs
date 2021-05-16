using FluentAssertions;
using NUnit.Framework;
using SmartphoneFactory.Factories;
using SmartphoneFactory.Interfaces;
using SmartphoneFactory.Smartphones;

namespace Testings.FactoriesTests
{
    public class SamsungTests
    {
        [Test]
        public void GetSmartphoneGalaxyS21Ultra_ShouldReturnCorrectPhone()
        {
            // Arrange
            IPhoneFactory phoneFactory = new Samsung();
            GalaxyS21Ultra expected = new GalaxyS21Ultra();

            // Act
            ISmartphone result = phoneFactory.GetSmartphone();

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}