﻿
namespace Rack
{
    /// <summary>
    /// перечисление типов параметров 
    /// проектируемой 3D-модели стеллажа
    /// </summary>
    public enum ParametersType
    {
        /// <summary>
        /// высота пространства от пола до нижней полки
        /// </summary>
        HeightFromFloor,

        /// <summary>
        /// толщина материала 3D-модели стеллажа
        /// </summary>
        MaterialThickness,

        /// <summary>
        /// глубина 3D-модели стеллажа
        /// </summary>
        RackDepth,

        /// <summary>
        /// высота 3D-модели стеллажа
        /// </summary>
        RackHeight,

        /// <summary>
        /// ширина 3D-модели стеллажа
        /// </summary>
        RackWidth,

        /// <summary>
        /// высота пространства между полками
        /// </summary>
        ShelvesHeight,

        /// <summary>
        /// количество полок 
        /// </summary>
        ShelvesNumber,

        /// <summary>
        /// Количество полок для объединения
        /// </summary>
        NumberCombinedShelves
    }
}
