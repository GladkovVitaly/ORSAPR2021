using System;

namespace CrowbarParameters
{
    /// <summary>
    /// Содержит свойства параметра
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Значение параметра
        /// </summary>
        private double _parameterValue;

        /// <summary>
        /// Минимальное значение
        /// </summary>
        private double _minimumValue = -1;

        /// <summary>
        /// Максимальное значение
        /// </summary>
        private double _maximumValue = -1;

        /// <summary>
        /// Свойства минимального значения параметра
        /// </summary>
        public double MinimumValue
        {
            get => _minimumValue;
            set => _minimumValue = value;
        }

        /// <summary>
        /// Свойства максимального значения параметра
        /// </summary>
        public double MaximumValue
        {
            get => _maximumValue;
            set => _maximumValue = value;
        }

        /// <summary>
        /// Свойства значения параметра
        /// </summary>
        public double ParameterValue
        {
            get => _parameterValue;
            set
            {
                if (MinimumValue == -1 || MaximumValue == -1)
                {
                    throw new ArgumentException(
                        $"Зависимый параметр не задан");
                }

                if (IsNumberInRange(value, MinimumValue, MaximumValue))
                {
                    _parameterValue = value;
                }
                else
                {

                    throw new ArgumentException(
                        $"Значение параметра должно быть больше, чем {MinimumValue} " +
                        $"и меньше, чем {MaximumValue} ");

                }
            }
        }

        /// <summary>
        /// Конструктор параметра
        /// </summary>
        /// <param name="minimumValue">Минимальное значениеr</param>
        /// <param name="maximumValue">Максимальное значение</param>
        public Parameter(double minimumValue, double maximumValue)
        {
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Parameter() { }

        /// <summary>
        /// Проверка входит ли значение в интервал 
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <returns>True, если значение входит в интервал и false, если нет</returns>
        private bool IsNumberInRange(double value, double min, double max)
        {
            return value >= min && value <= max;
        }

        public bool Equals(Parameter other)
        {
            return this.ParameterValue == other.ParameterValue ||
                   this.MaximumValue == other.MaximumValue ||
                   this.MinimumValue == other.MinimumValue;
        }
    }
}
