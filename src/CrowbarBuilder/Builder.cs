using System;
using KompasConnector;
using Kompas6API5;
using Kompas6Constants3D;
using CrowbarParameters;

namespace CrowbarBuilder
{
    /// <summary>
    /// Класс для построения лома
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Поле связи с компасом
        /// </summary>
        private Konnector _connector;

        /// <summary>
        /// Параметры лома
        /// </summary>
        private Parameters _parameters;

        /// <summary>
        /// Создаёт скетч для лома
        /// </summary>
        /// <param name="iSketch">Скетч</param>
        void CreateSketch(ksEntity iSketch)
        {
            ksSketchDefinition iDefinition = iSketch.GetDefinition();
            ksEntity iPlane = _connector.KsPart.GetDefaultEntity((short)Obj3dType.o3d_planeYOZ);
            iDefinition.SetPlane(iPlane);

            // Создаем скетч
            iSketch.Create();

            ksDocument2D iDocument2D = iDefinition.BeginEdit();

            iDocument2D.ksLineSeg(0.0, 0, -_parameters.WorkingAreaLength, 0, 1);

            iDocument2D.ksLineSeg(-_parameters.WorkingAreaLength, 
                0, -_parameters.WorkingAreaLength, 
                _parameters.WorkingAreaWidth, 1);
            iDocument2D.ksLineSeg(-_parameters.WorkingAreaLength, 
                _parameters.WorkingAreaWidth, -_parameters.Diameter, 
                _parameters.WorkingAreaWidth + _parameters.WorkingPartHeight, 1);
            iDocument2D.ksLineSeg(-_parameters.Diameter, 
                _parameters.WorkingAreaWidth + _parameters.WorkingPartHeight, 
                -_parameters.Diameter, _parameters.WorkingAreaWidth + 
                _parameters.WorkingPartHeight + _parameters.MainBodyLength, 1);

            //TODO: RSDN
            var drummer = _parameters.Diameter / (2 * Math.Sin(_parameters.DrummerСorner*Math.PI / 360));

            iDocument2D.ksLineSeg(-_parameters.Diameter, 
                _parameters.WorkingAreaWidth + _parameters.WorkingPartHeight + 
                _parameters.MainBodyLength, 0.0, _parameters.WorkingAreaWidth + 
                _parameters.WorkingPartHeight + _parameters.MainBodyLength + drummer, 1);

            //TODO: RSDN
            iDocument2D.ksLineSeg(0.0, _parameters.WorkingAreaWidth + 
                _parameters.WorkingPartHeight + _parameters.MainBodyLength + drummer, 0.0, 0, 3);

            iDefinition.EndEdit();
        }

        //TODO: XML
        /// <summary>
        /// Метод для построения лома
        /// </summary>
        /// <param name="konnector">Коннектор</param>
        /// <param name="_parameters">Параметры лома</param>
        public void Build(Konnector konnector, Parameters parameters)
        {
            _connector = konnector;
            _connector.GetNewPart();
            _parameters = parameters;

            //TODO: RSDN
            ksEntity iSketch = _connector.KsPart.NewEntity((short)Obj3dType.o3d_sketch);

            CreateSketch(iSketch);


            // Создаем обьект вращения
            ksEntity entity = _connector.KsPart.NewEntity((short)Obj3dType.o3d_bossRotated);
            //TODO: RSDN
            ksBossRotatedDefinition iDefinition = entity.GetDefinition();
            
            //TODO: RSDN
            ksEntityCollection iCollection = _connector.KsPart.EntityCollection((short)Obj3dType.o3d_edge);
            iCollection.SelectByPoint(0, 0, 0);
            ksEntity iEdge = iCollection.Last();
            iSketch = iEdge.GetDefinition().GetOwnerEntity();
            iDefinition.SetSketch(iSketch);

            //TODO: RSDN
            ksRotatedParam iRotatedParam = iDefinition.RotatedParam();
            iRotatedParam.angleNormal = 360.0;
            iRotatedParam.angleReverse = 360.0;
            iRotatedParam.direction = (short)Direction_Type.dtNormal;
            iRotatedParam.toroidShape = false;
            iCollection = _connector.KsPart.EntityCollection((short)Obj3dType.o3d_edge);
            iCollection.SelectByPoint(0, 0, 0);
            //TODO: RSDN
            iEdge = iCollection.Last();

            entity.Create(); 
        }
    }
}
