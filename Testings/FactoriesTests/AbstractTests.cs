using FluentAssertions;
using NUnit.Framework;
using SmartphoneFactory.Factories;
using SmartphoneFactory.Interfaces;
using SmartphoneFactory.Smartphones;

namespace Testings.FactoriesTests
{
    public class AbstractTests
    {
        [TestCaseSource(nameof(TestCases))]
        public void GetSmartphone_WhenAllCorrect_ShouldReturnAbstractPhone(
                        string name,
                        int weight,
                        double screentSize,
                        string cpu,
                        int ram,
                        int storage,
                        int battery,
                        int camera)
        {
            // Arrange
            IPhoneFactory phoneFactory = new Abstract(name, weight, screentSize, cpu, ram, storage, battery, camera);
            AbstractPhone expected = new AbstractPhone(name, weight, screentSize, cpu, ram, storage, battery, camera);

            // Act
            ISmartphone result = phoneFactory.GetSmartphone();

            // Assert
            result.Should().BeEquivalentTo(expected);
        }


        static object[] TestCases =
        {
            new object[] { "iPhone 12 Pro Max", 228, 6.7, "A14 Bionic", 6, 128, 3687, 12 },
            new object[] { "OnePlus Nord N10 5G", 190, 6.49, "Snapdragon 690", 6, 128, 4300, 64 },
            new object[] { "iPhone 12 Pro Max", 143, 5.8, "Snapdragon 730G", 6, 128, 3140, 12 }
        };
    }
}