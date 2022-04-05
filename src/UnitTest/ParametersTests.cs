using System.Reflection;
using NUnit.Framework;
using CrowbarParameters;
using System;

namespace UnitTests
{
    /// <summary>
    /// Класс для тестирования параметров 
    /// </summary>
    [TestFixture]
    public class ParametersTest
    {
        [TestCase(TestName = "Позитивный тест установки значений параметров по умолчанию")]
        public void Parameters_SetDefaultValue()
        {
            //Set
            var expected = new Parameters();
            expected.SetDefaultParameters();

            //Act
            var actual = SetDefaultValues();

            //Assert
            foreach (PropertyInfo expectedProperty in
                expected.GetType().GetProperties())
            {
                var propertyName = expectedProperty.Name;

                var actualValue = actual.GetType().
                    GetProperty(propertyName).GetValue(actual);
                var expectedValue = expectedProperty.GetValue(expected);
                Assert.AreEqual(expectedValue, actualValue);
            }
        }

        [TestCase(15, ParameterType.Diameter,
            TestName = "Позитивный тест геттера параметра Diameter")]
        [TestCase(35, ParameterType.DrummerСorner,
            TestName = "Позитивный тест геттера параметра DrummerСorner")]
        [TestCase(500, ParameterType.MainBodyLength,
            TestName = "Позитивный тест геттера параметра MainBodyLength")]
        [TestCase(6, ParameterType.WorkingAreaLength,
            TestName = "Позитивный тест геттера параметра WorkingAreaLength")]
        [TestCase(3, ParameterType.WorkingAreaWidth,
            TestName = "Позитивный тест геттера параметра WorkingAreaWidth")]
        [TestCase(10, ParameterType.WorkingPartHeight,
            TestName = "Позитивный тест геттера параметра WorkingPartHeight")]
        public void Parameters_GetCorrectValue(double testParameterValue,
             ParameterType parameterType)
        {

            var actual = SetDefaultValues();

            actual.SetParameterValueByType(testParameterValue, parameterType);
            var actualPropertyObject = GetPropertyValue(actual, parameterType);

            Assert.AreEqual(testParameterValue, actualPropertyObject);
        }
           
        [TestCase(10, 0,  TestName = "Негативный тест метода SetParameterValueByType")]
        public void Parameters_GetUnCorrectValue(double testParameterValue,
            ParameterType parameterType)
        {

            var actual = SetDefaultValues();

            Assert.Throws<ArgumentException>(
                () =>
                {
                    actual.SetParameterValueByType(testParameterValue, parameterType);
                },
                "Exception: argument out of range");
        }
    

        [TestCase(15, ParameterType.Diameter,
            TestName = "Позитивный тест сеттера параметра Diameter")]
        [TestCase(35, ParameterType.DrummerСorner,
            TestName = "Позитивный тест сеттера параметра DrummerСorner")]
        [TestCase(500, ParameterType.MainBodyLength,
            TestName = "Позитивный тест сеттера параметра MainBodyLength")]
        [TestCase(6, ParameterType.WorkingAreaLength,
            TestName = "Позитивный тест сеттера параметра WorkingAreaLength")]
        [TestCase(3, ParameterType.WorkingAreaWidth,
            TestName = "Позитивный тест сеттера параметра WorkingAreaWidth")]
        [TestCase(10, ParameterType.WorkingPartHeight,
            TestName = "Позитивный тест сеттера параметра WorkingPartHeight")]
        public void Parameters_SetCorrectParameters(dynamic value,
            ParameterType parameterType)
        {
            var testParameters = SetDefaultValues();

            var testValue = value;

            testParameters.SetParameterValueByType(testValue, parameterType);

            var actualValue = GetPropertyValue(testParameters, parameterType);
            Assert.AreEqual(actualValue, testValue);
        }

        [TestCase(15, ParameterType.Diameter,
            TestName = "Позитивный тест метода " +
            "SetParameterValueByType для параметра Diameter")]
        [TestCase(35, ParameterType.DrummerСorner,
            TestName = "Позитивный тест метода " +
            "SetParameterValueByType для параметра DrummerСorner")]
        [TestCase(500, ParameterType.MainBodyLength,
            TestName = "Позитивный тест метода " +
            "SetParameterValueByType для параметра MainBodyLength")]
        [TestCase(6, ParameterType.WorkingAreaLength,
            TestName = "Позитивный тест метода " +
            "SetParameterValueByType для параметра WorkingAreaLength")]
        [TestCase(3, ParameterType.WorkingAreaWidth,
            TestName = "Позитивный тест метода " +
            "SetParameterValueByType для параметра WorkingAreaWidth")]
        [TestCase(10, ParameterType.WorkingPartHeight,
            TestName = "Позитивный тест метода " +
            "SetParameterValueByType для параметра WorkingPartHeight")]
        public void Parameters_GetCorrectParametersByType(dynamic value,
            ParameterType parameterType)
        {
            var testParameters = SetDefaultValues();

            var testValue = value;

            var actualValue = testParameters.GetParameterValueByType(parameterType);

            Assert.AreEqual(actualValue, testValue);
        }

        [TestCase(7, TestName = "Негатиынй тест метода GetParameterValueByType")]
        public void Parameters_GetUnCorrectParametersByType(ParameterType parameterType)
        {

            var testParameters = new Parameters();

            Assert.Throws<ArgumentException>(
                () =>
                {
                    testParameters.GetParameterValueByType(parameterType);
                });
        }


        [TestCase(ParameterType.Diameter,
            Parameters.MIN_DIAMETER,
            TestName = "Позитивный тест геттера " +
            "минимального значения для параметра Diameter")]
        [TestCase(ParameterType.DrummerСorner,
            Parameters.MIN_DRUMMER_CORNER,
            TestName = "Позитивный тест геттера " +
            "минимального значения для параметра DrummerСorner")]
        [TestCase(ParameterType.MainBodyLength,
            Parameters.MIN_MAIN_BODY_LENGTH,
            TestName = "Позитивный тест геттера " +
            "минимального значения для параметра MainBodyLength")]
        [TestCase(ParameterType.WorkingAreaLength,
            Parameters.MIN_WORKING_AREA_LENGTH,
            TestName = "Позитивный тест геттера " +
            "минимального значения для параметра WorkingAreaLength")]
        [TestCase(ParameterType.WorkingAreaWidth,
            Parameters.MIN_WORKING_AREA_WIDTH,
            TestName = "Позитивный тест геттера " +
            "минимального значения для параметра WorkingAreaWidth")]
        [TestCase(ParameterType.WorkingPartHeight,
            Parameters.MIN_WORKING_PART_HEIGHT,
            TestName = "Позитивный тест геттера " +
            "минимального значения для параметра WorkingPartHeight")]       
        public void Parameters_GetCorrectMinimumValues(ParameterType parameterType,
            double minValue)
        {
            var testParameters = new Parameters();
            double expectedMinimumValue = -1;
            double actualMinimumValue = 0;
            expectedMinimumValue = minValue;
            actualMinimumValue = testParameters.GetMinimumValue(parameterType);

            Assert.AreEqual(expectedMinimumValue, actualMinimumValue);
        }


        [TestCase(7, TestName = "Негативный тест для метода GetMinimumValue")]
        public void Parameters_GetUnCorrectMinimumValues(ParameterType parameterType)
        {

            var testParameters = new Parameters();
          
            Assert.Throws<ArgumentException>(
                () =>
                {
                    testParameters.GetMinimumValue(parameterType);
                });
        }

        [TestCase(ParameterType.Diameter,
            Parameters.MAX_DIAMETER,
            TestName = "Позитивный тест геттера " +
            "максимального значения для параметра Diameter")]
        [TestCase(ParameterType.DrummerСorner,
             Parameters.MAX_DRUMMER_CORNER,
            TestName = "Позитивный тест геттера " +
             "максимального значения для параметра DrummerСorner")]
        [TestCase(ParameterType.MainBodyLength,
             Parameters.MAX_MAIN_BODY_LENGTH,
             TestName = "Позитивный тест геттера " +
             "максимального значения для параметра MainBodyLength")]
        [TestCase(ParameterType.WorkingAreaLength,
            Parameters.MAX_WORKING_AREA_LENGTH,
            TestName = "Позитивный тест геттера " +
            "максимального значения для параметра WorkingAreaLength")]
        [TestCase(ParameterType.WorkingAreaWidth,
            Parameters.MAX_WORKING_AREA_WIDTH,
            TestName = "Позитивный тест геттера " +
            "максимального значения для параметра WorkingAreaWidth")]
        [TestCase(ParameterType.WorkingPartHeight,
            Parameters.MAX_WORKING_PART_HEIGHT,
            TestName = "Позитивный тест геттера " +
            "максимального значения для параметра WorkingPartHeight")]
        public void Parameters_GetCorrectMaximumValues(ParameterType parameterType,
            double maxValue)
        {
            var testParameters = new Parameters();
            double expectedMaximumValue = -1;
            double actualMaximumValue = 0;
            expectedMaximumValue = maxValue;
            actualMaximumValue = testParameters.GetMaximumValue(parameterType);

            Assert.AreEqual(expectedMaximumValue, actualMaximumValue);
        }

        [TestCase(7, TestName = "Негативный тест метода GetMaximumValue")]
        public void Parameters_GetUnCorrectMaximumValue(ParameterType parameterType)
        {

            var testParameters = new Parameters();

            Assert.Throws<ArgumentException>(
                () =>
                {
                    testParameters.GetMaximumValue(parameterType);
                });
        }

        /// <summary>
        /// Установить параметры по умолчанию
        /// </summary>
        private Parameters SetDefaultValues()
        {
            return new Parameters
            {
                MainBodyLength = 500,
                Diameter = 15,
                DrummerСorner = 35,
                WorkingPartHeight = 10,
                WorkingAreaLength = 6,
                WorkingAreaWidth = 3
            };
        }

        /// <summary>
        /// Возвращает значение параметра по типу параметра
        /// </summary>
        /// <param name="parameters">Параметры</param>
        /// <param name="parameterType">Тип параметра</param>
        /// <returns>Значение параметра</returns>
        private dynamic GetPropertyValue(Parameters parameters,
            ParameterType parameterType)
        {
            return parameters.GetType().
                GetProperty(parameterType.ToString()).
                GetValue(parameters);
        }
    }
}
