using FluentAssertions;
using NUnit.Framework;
using SmartphoneFactory.Factories;
using SmartphoneFactory.Interfaces;
using SmartphoneFactory.Smartphones;

namespace Testings.FactoriesTests
{
    public class HuaweiTests
    {
        [Test]
        public void GetSmartphoneP30Pro_ShouldReturnCorrectPhone()
        {
            // Arrange
            IPhoneFactory phoneFactory = new Huawei();
            P30Pro expected = new P30Pro();

            // Act
            ISmartphone result = phoneFactory.GetSmartphone();

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}