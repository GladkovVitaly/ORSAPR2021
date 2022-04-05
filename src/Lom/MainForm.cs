using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CrowbarParameters;
using CrowbarBuilder;
using KompasConnector;

namespace СrowbarUI
{
    /// <summary>
    /// Класс, который хранит и обрабатывает пользовательский интерфейс плагина.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Построитель лома
        /// </summary>
        private Builder _CrowbarBuilder;

        /// <summary>
        /// Параметры лома
        /// </summary>
        private Parameters _crowbarParameters = new Parameters();

        /// <summary>
        /// Переменная для связи с Компасом
        /// </summary>
        private Konnector _kompasConnector = new Konnector();

        /// <summary>
        /// Словарь пар (Textboxes, parameter type)
        /// </summary>
        private Dictionary<TextBox, ParameterType> _textBoxDictionary;

        /// <summary>
        /// Конструктор главного окна
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _textBoxDictionary = new Dictionary<TextBox, ParameterType>
            {
                {mainBodyLengthTextBox, ParameterType.MainBodyLength },
                {diameterTextBox, ParameterType.Diameter },
                {drummerСornerTextBox, ParameterType.DrummerСorner},
                {workingAreaLengthTextBox, ParameterType.WorkingAreaLength},
                {workingAreaWidthTextBox, ParameterType.WorkingAreaWidth},
                {workingPartHeightTextBox, ParameterType.WorkingPartHeight}
            };
        }

        /// <summary>
        /// Конвертирует строку в double
        /// </summary>
        /// <param name="text">Строка</param>
        /// <returns name="numberResult">Число</returns>
        private double ConvertStringToDouble(string text)
        {
            double.TryParse(text, out double numberResult);
            return numberResult;
        }

        /// <summary>
        /// Обработчик событий кнопки "Построить"
        /// </summary>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                _crowbarParameters.MainBodyLength = ConvertStringToDouble(mainBodyLengthTextBox.Text);
                _crowbarParameters.Diameter = ConvertStringToDouble(diameterTextBox.Text);
                _crowbarParameters.DrummerСorner = ConvertStringToDouble(drummerСornerTextBox.Text);
                _crowbarParameters.WorkingAreaLength = ConvertStringToDouble(workingAreaLengthTextBox.Text);
                _crowbarParameters.WorkingAreaWidth = ConvertStringToDouble(workingAreaWidthTextBox.Text);
                _crowbarParameters.WorkingPartHeight = ConvertStringToDouble(workingPartHeightTextBox.Text);


            }
            catch (Exception exception)
            {
                buildButton.Enabled = false;
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OKCancel);
                return;
            }
            try
            {
                _kompasConnector.OpenKompas();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return;
            }

            _CrowbarBuilder = new Builder();
            _CrowbarBuilder.Build(_kompasConnector, _crowbarParameters);

        }

        /// <summary>
        /// Метод проверки текстового поля
        /// </summary>
        /// <param name="sender">TextBox</param>
        private void Textbox_Validating(object sender, EventArgs e)
        {
            if (!(sender is TextBox textbox)) return;
            try
            {
                _textBoxDictionary.TryGetValue(textbox,
                    out var parameterTypeInTextbox);
                _crowbarParameters.SetParameterValueByType(double.Parse(textbox.Text),
                    parameterTypeInTextbox);

                if(textbox == mainBodyLengthTextBox)
                {
                    workingPartHeightTextBox.Enabled = true;
                    workingPartHeightLabel.Visible = true;
                    var workingPartHeightMaximumValue =
                        _crowbarParameters.GetMaximumValue(ParameterType.WorkingPartHeight);
                    workingPartHeightLabel.Text = $"(1 - {workingPartHeightMaximumValue}) мм";
                } 
                else if (textbox == diameterTextBox)
                {
                    workingAreaLengthTextBox.Enabled = true;
                    workingAreaLengthLabel.Visible = true;
                    var workingAreaLengthMaximumValue =
                        _crowbarParameters.GetMaximumValue(ParameterType.WorkingAreaLength);
                    workingAreaLengthLabel.Text = $"(1 - {workingAreaLengthMaximumValue}) мм";
                }
                else if (textbox == workingAreaLengthTextBox)
                {
                    workingAreaWidthTextBox.Enabled = true;
                    workingAreaWidthLabel.Visible = true;
                    var workingAreaWidthMaximumValue =
                        _crowbarParameters.GetMaximumValue(ParameterType.WorkingAreaWidth);
                    var workingAreaWidthMinimumValue =
                        _crowbarParameters.GetMinimumValue(ParameterType.WorkingAreaWidth);
                    workingAreaWidthLabel.Text = $"(1 - {workingAreaWidthMaximumValue}) мм";
                }
                textbox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (textbox == mainBodyLengthTextBox)
                {
                    workingPartHeightTextBox.Enabled = false;
                    workingPartHeightLabel.Visible = false;
                }
                if (textbox == diameterTextBox)
                {
                    workingAreaLengthTextBox.Enabled = false;
                    workingAreaLengthLabel.Visible = false;
                }
                if(textbox == workingAreaLengthTextBox)
                {
                    workingAreaWidthTextBox.Enabled = false;
                    workingAreaWidthLabel.Visible = false;
                }
                textbox.BackColor = Color.Salmon;
            }
            SwitchingBuildButton();
        }


        /// <summary>
        /// Включает BuildButton, если значения во всех текстовых полях верны
        /// </summary>
        private void SwitchingBuildButton()
        {
            try
            {
                foreach (var textBoxParameterTypePair in _textBoxDictionary)
                {
                    double.TryParse(textBoxParameterTypePair.Key.Text,
                        out double parameterValue);
                    if (textBoxParameterTypePair.Key.Text == "")
                    {
                        throw new ArgumentException("Не все параметры заданы");
                    }
                    _crowbarParameters.SetParameterValueByType(
                        parameterValue, textBoxParameterTypePair.Value);
                }

                buildButton.Enabled = true;
            }
            catch (Exception)
            {
                buildButton.Enabled = false;
            }
        }

        /// <summary>
        ///  обработчика событий для кнопки установки параметров по умолчанию
        /// </summary>
        private void DefaultParametersButton_Click(object sender, EventArgs e)
        {
            _crowbarParameters.SetDefaultParameters();

            foreach (var textBoxParameterTypePair in _textBoxDictionary)
            {
                textBoxParameterTypePair.Key.Text = _crowbarParameters.GetParameterValueByType(textBoxParameterTypePair.Value).ToString();
                textBoxParameterTypePair.Key.BackColor = Color.White;
            }

            workingPartHeightTextBox.Enabled = true;
            workingPartHeightLabel.Visible = true;
            workingAreaLengthTextBox.Enabled = true;
            workingAreaLengthLabel.Visible = true;
            workingAreaWidthTextBox.Enabled = true;
            workingAreaWidthLabel.Visible = true;
        }
    }
}
