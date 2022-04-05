using System;
using System.Runtime.InteropServices;
using Kompas6API5;
using Kompas6Constants3D;

namespace KompasConnector
{
    /// <summary>
    /// Класс для соединением с Компасом-3D
    /// </summary>
    public class Konnector
    {
        /// <summary>
        /// Содержит название программы
        /// </summary>
        private const string ProgId = "KOMPAS.Application.5";

        /// <summary>
        /// Compass-3D API
        /// </summary>
        public KompasObject Kompas { get; set; }

        /// <summary>
        /// Compass-3D компонентный интерфейс
        /// </summary>
        public ksPart KsPart { get; set; }

        /// <summary>
        /// KompasConnector конструктор классы
        /// </summary>
        public void OpenKompas()
        {
            try
            {
                // если программа открыта
                Kompas = (KompasObject)Marshal.GetActiveObject(ProgId);
            }
            catch (COMException)
            {
                try
                {
                    var type = Type.GetTypeFromProgID(ProgId);
                    // если программа еще не открыта, то пытаемся ее открыть
                    Kompas = (KompasObject)Activator.CreateInstance(type);
                }
                catch (Exception)
                {
                    throw new ArgumentException(@"Ошибка запуска программы");
                }
            }

            Kompas.Visible = true;
            Kompas.ActivateControllerAPI();

        }

        /// <summary>
        /// Создайте новый документ 3D
        /// </summary>
        public void GetNewPart()
        {
            var doc3D = (ksDocument3D)Kompas.Document3D();
            doc3D.Create();
            KsPart = (ksPart)doc3D.GetPart((short)Part_Type.pTop_Part);
        }
    }
}