using System;

namespace CrowbarParameters
{
    /// <summary>
    /// Содержит список параметров
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// Длина основной части
        /// </summary>
        private Parameter _mainBodyLength =
            new Parameter(MIN_MAIN_BODY_LENGTH, MAX_MAIN_BODY_LENGTH);

        /// <summary>
        /// Диаметр лома
        /// </summary>
        private Parameter _diameter =
            new Parameter(MIN_DIAMETER, MAX_DIAMETER);

        /// <summary>
        /// Угол ударника
        /// </summary>
        private Parameter _drummerСorner =
            new Parameter(MIN_DRUMMER_CORNER, MAX_DRUMMER_CORNER);

        /// <summary>
        /// Высота рабочей части
        /// </summary>
        private Parameter _workingPartHeight =
            new Parameter(MIN_WORKING_PART_HEIGHT, MAX_WORKING_PART_HEIGHT);

        /// <summary>
        /// Длина рабочей площади
        /// </summary>
        private Parameter _workingAreaLength =
            new Parameter(MIN_WORKING_AREA_LENGTH, MAX_WORKING_AREA_LENGTH);

        /// <summary>
        /// Ширина рабочей площади
        /// </summary>
        private Parameter _workingAreaWidth =
            new Parameter(MIN_WORKING_AREA_WIDTH, MAX_WORKING_AREA_WIDTH);

        #region Propertyes
        /// <summary>
        /// Свойства длины основной части
        /// </summary>
        public double MainBodyLength
        {
            get => _mainBodyLength.ParameterValue;

            set
            {
                _mainBodyLength.ParameterValue = value;

                _workingPartHeight.MaximumValue = value;
            }
        }

        /// <summary>
        /// Свойства диаметра лома
        /// </summary>
        public double Diameter
        {
            get => _diameter.ParameterValue;

            set
            {
                _diameter.ParameterValue = value;

                _workingAreaLength.MaximumValue = value;
            }
        }

        /// <summary>
        /// Свойства высоты рабочей части
        /// </summary>
        public double DrummerСorner
        {
            get => _drummerСorner.ParameterValue;

            set => _drummerСorner.ParameterValue = value;
        }

        /// <summary>
        /// Свойства высоты рабочей площади
        /// </summary>
        public double WorkingPartHeight
        {
            get => _workingPartHeight.ParameterValue;

            set => _workingPartHeight.ParameterValue = value;
        }

        /// <summary>
        /// Свойства длины рабочей площади
        /// </summary>
        public double WorkingAreaLength
        {
            get => _workingAreaLength.ParameterValue;

            set
            {
                _workingAreaLength.ParameterValue = value;

                _workingAreaWidth.MaximumValue = value;
            }

        }

        /// <summary>
        /// Свойства ширины рабочей площади
        /// </summary>
        public double WorkingAreaWidth
        {
            get => _workingAreaWidth.ParameterValue;

            set => _workingAreaWidth.ParameterValue = value;
        }
        #endregion

        #region MinimumAndMaximumValues

        /// <summary>
        /// Минимальное значение длины основной части
        /// </summary>
        public const double MIN_MAIN_BODY_LENGTH = 300.0;

        /// <summary>
        ///Максимальное значение длины основной части
        /// </summary>
        public const double MAX_MAIN_BODY_LENGTH = 600.0;

        /// <summary>
        ///Минимальное значение диаметра лома
        /// </summary>
        public const double MIN_DIAMETER = 10.0;

        /// <summary>
        ///Минимальное значение диаметра лома
        /// </summary>
        public const double MAX_DIAMETER = 20.0;

        /// <summary>
        ///Минимальное значение высоты рабочей части
        /// </summary>
        public const double MIN_DRUMMER_CORNER = 30.0;

        /// <summary>
        ///Минимальное значение высоты рабочей части
        /// </summary>
        public const double MAX_DRUMMER_CORNER = 45.0;

        /// <summary>
        ///Минимальное значение of высоты рабочей площади
        /// </summary>
        public const double MIN_WORKING_PART_HEIGHT = 1.0;

        /// <summary>
        ///Максимальное значение of высоты рабочей площади
        /// </summary>
        public const double MAX_WORKING_PART_HEIGHT = 300.0;

        /// <summary>
        ///Минимальное значение of длины рабочей площади
        /// </summary>
        public const double MIN_WORKING_AREA_LENGTH = 1.0;

        /// <summary>
        ///Максимальное значение of длины рабочей площади
        /// </summary>
        public const double MAX_WORKING_AREA_LENGTH = 30.0;

        /// <summary>
        ///Минимальное значение ширины рабочей площади
        /// </summary>
        public const double MIN_WORKING_AREA_WIDTH = 1.0;

        /// <summary>
        ///Максимальное значение ширины рабочей площади
        /// </summary>
        public const double MAX_WORKING_AREA_WIDTH = 30.0;

        #endregion

        /// <summary>
        /// Установить параметры по умолчанию
        /// </summary>
        public void SetDefaultParameters()
        {
            this.MainBodyLength = 500;
            this.Diameter = 15;
            this.DrummerСorner = 35;
            this.WorkingPartHeight = 10;
            this.WorkingAreaLength = 6;
            this.WorkingAreaWidth = 3;
        }

        /// <summary>
        /// Возвращает минимальное значение параметра
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <returns>Минимальное значение параметра</returns>
        public double GetMinimumValue(ParameterType parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.MainBodyLength:
                    {
                        return this._mainBodyLength.MinimumValue;
                    }
                case ParameterType.Diameter:
                    {
                        return this._diameter.MinimumValue;
                    }
                case ParameterType.DrummerСorner:
                    {
                        return this._drummerСorner.MinimumValue;
                    }
                case ParameterType.WorkingPartHeight:
                    {
                        return this._workingPartHeight.MinimumValue;
                    }
                case ParameterType.WorkingAreaLength:
                    {
                        return this._workingAreaLength.MinimumValue;
                    }
                case ParameterType.WorkingAreaWidth:
                    {
                        return this._workingAreaWidth.MinimumValue;
                    }
                default:
                    {
                        throw new ArgumentException("Не правильный тип параметра");
                    }
            }
        }

        /// <summary>
        /// Возвращает максимальное значение параметра
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <returns>Максимальное значение параметра</returns>
        public double GetMaximumValue(ParameterType parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.MainBodyLength:
                    {
                        return this._mainBodyLength.MaximumValue;
                    }
                case ParameterType.Diameter:
                    {
                        return this._diameter.MaximumValue;
                    }
                case ParameterType.DrummerСorner:
                    {
                        return this._drummerСorner.MaximumValue;
                    }
                case ParameterType.WorkingPartHeight:
                    {
                        return this._workingPartHeight.MaximumValue;
                    }
                case ParameterType.WorkingAreaLength:
                    {
                        return this._workingAreaLength.MaximumValue;
                    }
                case ParameterType.WorkingAreaWidth:
                    {
                        return this._workingAreaWidth.MaximumValue;
                    }
                default:
                    {
                        throw new ArgumentException("Не правильный тип параметра");
                    }
            }
        }

        /// <summary>
        /// Установить значение параметра по типу параметра
        /// </summary>
        /// <param name="value">Значение параметра</param>
        /// <param name="parameterType">Тип параметра</param>
        public void SetParameterValueByType(dynamic value, ParameterType parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.MainBodyLength:
                    {
                        this.MainBodyLength = value;
                        break;
                    }
                case ParameterType.Diameter:
                    {
                        this.Diameter = value;
                        break;
                    }
                case ParameterType.DrummerСorner:
                    {
                        this.DrummerСorner = value;
                        break;
                    }
                case ParameterType.WorkingPartHeight:
                    {
                        this.WorkingPartHeight = value;
                        break;
                    }
                case ParameterType.WorkingAreaLength:
                    {
                        this.WorkingAreaLength = value;
                        break;
                    }
                case ParameterType.WorkingAreaWidth:
                    {
                        this.WorkingAreaWidth = value;
                        break;
                    }
            }
        }

        /// <summary>
        /// Возвращает значение параметра по типу параметра
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <returns>Значение параметра</returns>
        public double GetParameterValueByType(ParameterType parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.MainBodyLength:
                    {
                        return this.MainBodyLength;                     
                    }
                case ParameterType.Diameter:
                    {
                        return this.Diameter;                        
                    }
                case ParameterType.DrummerСorner:
                    {
                        return this.DrummerСorner;                        
                    }
                case ParameterType.WorkingPartHeight:
                    {
                        return this.WorkingPartHeight;                        
                    }
                case ParameterType.WorkingAreaLength:
                    {
                        return this.WorkingAreaLength;                        
                    }
                case ParameterType.WorkingAreaWidth:
                    {
                        return this.WorkingAreaWidth;                        
                    }
                default:
                    {
                        throw new ArgumentException("Не правильный тип параметра");
                    }
            }
        }
    }
}
