using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using Rack;

namespace RackBuilder
{
     /// <summary>
     /// публичный класс отвечающий за 
     /// построение проектируемой 3D-модели стеллажа
     /// </summary>
    public class RackModelBuilder
    {
        /// <summary>
        /// приватный параметр, реализующий связь между API и Компас-3D
        /// </summary>
        private KompasConnector _connector;

        /// <summary>
        /// публичный метод, отвечающий за
        /// окончательную сборку проектируемой 3D-модели стеллажа
        /// </summary>
        /// <param name="parameters">переменная хранящая в себе
        /// текущие значения для построения 3D-модели стеллажа </param>
        public void Assembly (RackParameters parameters)
        {
            _connector = new KompasConnector();
            _connector.GetNewPart();
            BuildBody(parameters.RackHeight, 
                parameters.RackWidth, parameters.RackDepth);
            BuildSpaceFromFloor(parameters.HeightFromFloor,
                parameters.RackWidth, 
                parameters.MaterialThickness, parameters.RackHeight);
            BuildShelves(parameters.ShelvesNumber, 
                parameters.ShelvesHeight, 
                parameters.MaterialThickness, parameters.RackWidth, 
                parameters.CombiningShelvesType,
                parameters.NumberCombinedShelves);

        }

        /// <summary>
        /// приватный метод, отвечающий за
        /// построение каркаса проектируемой 3D-модели стеллажа 
        /// </summary>
        /// <param name="heigthBody">высота каркаса</param>
        /// <param name="widthBody">ширина каркаса</param>
        /// <param name="depthExtrussion">глубина выдавливания 
        /// для полок/пространства от пола до нижней полки</param>
        private void BuildBody(int heigthBody,
            int widthBody, int depthExtrussion)
        {
            var sketch = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D)sketch.BeginEdit();
            var rectangleParam = 
                (ksRectangleParam)_connector.KompasObject.GetParamStruct
                 ((short)StructType2DEnum.ko_RectangleParam);
            
            rectangleParam.x = 0;
            rectangleParam.y = 0;
            rectangleParam.ang = 0;
            rectangleParam.height = heigthBody;
            rectangleParam.width = widthBody;
            rectangleParam.style = 1;
           
            doc2d.ksRectangle(rectangleParam,0);
            sketch.EndEdit();
            
            СreateExtrusion(sketch, depthExtrussion);
        }

        /// <summary>
        /// приватный метод, отвечающий за
        /// построение выдавливаемой плоскости
        /// от пола до нижней полки проектируемой 3D-модели стеллажа
        /// </summary>
        /// <param name="heigthSpace">высота выдавливаемого
        /// пространства</param>
        /// <param name="widthBody">ширина выдавливаемого
        /// пространства</param>
        /// <param name="materialThickness">толщина материала,
        /// сопряженного с выдавливаемым пространством</param>
        /// <param name="heightBody">высота каркаса
        /// проектируемой 3D-модели</param>
        private void BuildSpaceFromFloor(int heigthSpace, 
            int widthBody, int materialThickness, int heightBody)
        {
            var sketch = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D)sketch.BeginEdit();
            var rectangleParam = 
                (ksRectangleParam)_connector.KompasObject.GetParamStruct
                 ((short)StructType2DEnum.ko_RectangleParam);

            rectangleParam.x = materialThickness;
            rectangleParam.y = heightBody- heigthSpace;
            rectangleParam.ang = 0;
            rectangleParam.height = heigthSpace;
            rectangleParam.width = widthBody - materialThickness*2;
            rectangleParam.style = 1;

            doc2d.ksRectangle(rectangleParam, 0);
            sketch.EndEdit();

            CreateExtrude(sketch);
        }
       
        /// <summary>
        /// приватный метод, отвечающий за
        /// построение выдавливаемого пространства полок
        /// проектируемой 3D-модели стеллажа
        /// </summary>
        /// <param name="shelvesNumber">количество полок</param>
        /// <param name="shelvesHeight">высота полок</param>
        /// <param name="materialThickness">толщина материала</param>
        /// <param name="widthBody">ширина каркаса
        /// <param name="type">тип объединения полок
        /// (низ\верх)</param>
        /// <param name="numberCombinedShelves">кол-во полок
        /// для объединения</param>
        private void BuildShelves(int shelvesNumber, int shelvesHeight, 
            int materialThickness, int widthBody,
            CombiningShelvesType type, int numberCombinedShelves)
        {
            var sketch = CreateSketch(Obj3dType.o3d_planeXOZ);
            for (int i = 0; i <= shelvesNumber; i++)
            {
                var doc2d = (ksDocument2D)sketch.BeginEdit();
                var rectangleParam = 
                   (ksRectangleParam)_connector.KompasObject.GetParamStruct
                ((short)StructType2DEnum.ko_RectangleParam);
                var rectangleHeight = 
                    shelvesHeight - materialThickness;

                switch (type)
                {
                    case CombiningShelvesType.CombiningUp:
                    {
                        if (numberCombinedShelves != 0 &&
                            i < numberCombinedShelves)
                        {
                            rectangleHeight = shelvesHeight;
                        }
                        break;
                    }
                    case CombiningShelvesType.CombiningDown:
                    {
                        if (numberCombinedShelves != 0 &&
                            i != shelvesNumber-1 && 
                            i >= shelvesNumber - numberCombinedShelves)
                        {
                            rectangleHeight = shelvesHeight;
                        }
                        break;
                    }
                }

                rectangleParam.x = materialThickness;
                rectangleParam.y = i * shelvesHeight + materialThickness;
                rectangleParam.ang = 0;
                rectangleParam.height = rectangleHeight;
                rectangleParam.width = widthBody - materialThickness * 2;
                rectangleParam.style = 1;

                doc2d.ksRectangle(rectangleParam, 0);
                sketch.EndEdit();
                CreateExtrude(sketch);
            }
        }

        /// <summary>
        /// приватный метод, предназначенный для 
        /// выдавливания каркаса проектируемой 3D-модели стеллажа
        /// </summary>
        /// <param name="sketchDef">эскиз по которому будет
        /// производиться выдавливание</param>
        /// <param name="depth">глубина выдавливания каркаса</param>
        /// <param name="side">направление выдавливания каркаса</param>
        private void СreateExtrusion(ksSketchDefinition sketchDef,
            double depth, bool side = true)
        {
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_bossExtrusion;
            var extrusionEntity = 
                (ksEntity)_connector.Part.NewEntity((short)type);
            var extrusionDef = 
                (ksBossExtrusionDefinition)extrusionEntity.GetDefinition();

            extrusionDef.SetSideParam(side, (short)End_Type.etBlind, 
                depth);
            extrusionDef.directionType = side ?
               (short)Direction_Type.dtNormal : 
               (short)Direction_Type.dtReverse;
            extrusionDef.SetSketch(sketchDef);

            extrusionEntity.Create();

        }

        /// <summary>
        /// приватный метод, предназначенный для 
        /// выдавливания внутренних пространств
        /// (полки/пространство от пола до нижней полки)
        /// из каркаса 3D-модели стеллажа
        /// </summary>
        /// <param name="sketchDef">эскиз по которому
        /// будет производиться выдавливание </param>
        /// <param name="side">направление выдавливания</param>
        private void CreateExtrude(ksSketchDefinition sketchDef,
           bool side = false)
        {
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_cutExtrusion;
            var extrudeEntity = 
                (ksEntity)_connector.Part.NewEntity((short)type);
            var extrudeDef = 
                (ksCutExtrusionDefinition)extrudeEntity.GetDefinition();
            extrudeDef.SetSideParam(side, (short)End_Type.etThroughAll);

            extrudeDef.directionType = side ?
                (short)Direction_Type.dtNormal : 
                (short)Direction_Type.dtReverse;

            extrudeDef.SetSketch(sketchDef);

            extrudeEntity.Create();
        }

        /// <summary>
        /// приватный метод, отвечающий за 
        /// создание эскиза на выбранной плоскости
        /// </summary>
        /// <param name="planeType">вариант плоскости</param>
        /// <returns></returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType)
        {
            var plane = 
                (ksEntity)_connector.Part.GetDefaultEntity
                ((short)planeType);
            var sketch = 
                (ksEntity)_connector.Part.NewEntity
                ((short)Obj3dType.o3d_sketch);
            ksSketchDefinition ksSketch = 
                (ksSketchDefinition)sketch.GetDefinition();

            ksSketch.SetPlane(plane);
            sketch.Create();

            return ksSketch;
        }
    }
}
