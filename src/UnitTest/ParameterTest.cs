using System;
using NUnit.Framework;
using CrowbarParameters;

//TODO: RSDN
namespace UnitTests
{
    /// <summary>
    /// Класс для тестирования параметров 
    /// </summary>
    [TestFixture]
    public class ParameterTest
    {
        [TestCase(TestName = "Позитивный сеттер параметра")]
        public void Parameter_SetCorrectValue()
        {
            var minimumParameterValue = 10;
            var maximumParameterValue = 50;
            var expected = new Parameter(
                minimumParameterValue,
                maximumParameterValue)
            { ParameterValue = 30 };

            var actual = 30;

            Assert.AreEqual(expected.ParameterValue, actual);
        }

        [Test(Description = "Позитивный геттер параметра")]
        public void Parameter_GetCorrectValue()
        {
            var minimumParameterValue = 10;
            var maximumParameterValue = 50;
            var expected = new Parameter(minimumParameterValue, maximumParameterValue);

            var testValue = 30;
            expected.ParameterValue = testValue;

            Assert.AreEqual(expected.ParameterValue, testValue);
        }

        [Test(Description = "Позитивное создание конструктора по умолчанию")]
        public void Parameter_CorrectConstructor()
        {
            var expected = new Parameter();

            Assert.True(expected.MinimumValue == -1);
            Assert.True(expected.MaximumValue == -1);
        }

        [TestCase(5, 10, 50, TestName =
            "Негативный тест установки значения, значение меньше, чем разрешено")]
        [TestCase(100, 0, 50, TestName =
            "Негативный тест установки значения, значение больше, чем разрешено")]
        [TestCase(50, -1, -1, TestName =
            "Негативный тест установки значения, значение не определено")]
        public void Parameter_SetUnCorrectValue(double value,
            double minimumValue, double maximumValue)
        {
            var testParameter = new Parameter(minimumValue, maximumValue);
            Assert.Throws<ArgumentException>(
                () =>
                {
                    testParameter.ParameterValue = value;
                },
                "Exception: argument out of range");
        }

        [TestCase(TestName = "Позитивный тест метода Equals")]
        public void Parameter_EqualsTest()
        {
            var parameter = new Parameter();
            var otherParameter = parameter;
            Assert.True(parameter.Equals(otherParameter));
        }
    }
}
