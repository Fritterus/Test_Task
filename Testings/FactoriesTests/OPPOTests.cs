using FluentAssertions;
using NUnit.Framework;
using SmartphoneFactory.Factories;
using SmartphoneFactory.Interfaces;
using SmartphoneFactory.Smartphones;

namespace Testings.FactoriesTests
{
    public class OPPOTests
    {
        [Test]
        public void GetSmartphoneFindX3Pro_ShouldReturnCorrectPhone()
        {
            // Arrange
            IPhoneFactory phoneFactory = new OPPO();
            FindX3Pro expected = new FindX3Pro();

            // Act
            ISmartphone result = phoneFactory.GetSmartphone();

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}