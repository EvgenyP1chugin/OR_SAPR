using System;
using System.Collections.Generic;

namespace Rack
{
    /// <summary>
    /// публичный класс предназначенный для хранения 
    /// и выполнения валидации нижнего уровня
    /// </summary>
    public class RackParameters
    {
        /// <summary>
        /// высота от пола до нижней полки
        /// </summary>
        private int _heightFromFloor;

        /// <summary>
        /// толщина материала 3D-модели стеллажа
        /// </summary>
        private int _materialThickness;

        /// <summary>
        /// глубина проектируемой 3D-модели стеллажа
        /// </summary>
        private int _rackDepth;

        /// <summary>
        /// высота проектируемой 3D-модели стеллажа
        /// </summary>
        private int _rackHeight;

        /// <summary>
        /// высота проектируемой 3D-модели стеллажа
        /// </summary>
        private int _rackWidth;

        /// <summary>
        /// высота пространства между полками
        /// </summary>
        private int _shelvesHeight;

        /// <summary>
        /// количество полок
        /// </summary>
        private int _shelvesNumber;

        /// <summary>
        /// словарь для хранения ошибок ввода
        /// </summary>
        public Dictionary<Parameter, string> ErrorsDictionary { get; }
            = new Dictionary<Parameter, string>();
        
            

        /// <summary>
        /// свойство обрабатывающее поле 
        /// высоты пространства от пола до нижней полки,
        /// содержит валидацию допустимых значений 
        /// </summary>
        public int HeightFromFloor
        {
            get => _heightFromFloor;

            set
            {
                try
                {
                    const int minValue = 80;
                    const int maxValue = 100;
                    Validator.CheckParametersValue(minValue, maxValue,
                        value, Parameter.HeightFromFloor);
                    _heightFromFloor = value;
                }
                catch (Exception ex)
                {
                    ErrorsDictionary.Add(Parameter.HeightFromFloor, 
                        ex.Message);
                }
            }
        }

        /// <summary>
        /// свойство обрабатывающее поле 
        /// толщины материала проектируемой 3D-модели стеллажа,
        /// содержит валидацию допустимых значений 
        /// </summary>
        public int MaterialThickness
        {
            get => _materialThickness;

            set
            {
                try
                {
                    const int minValue = 10;
                    const int maxValue = 20;
                    Validator.CheckParametersValue(minValue, maxValue,
                        value, Parameter.MaterialThickness);
                    _materialThickness = value;
                }
                catch (Exception ex)
                {
                    ErrorsDictionary.Add(Parameter.MaterialThickness,
                        ex.Message);
                }
            }
        }

        /// <summary>
        /// свойство обрабатывающее поле 
        /// глубины проектируемой 3D-модели стеллажа,
        /// содержит валидацию допустимых значений 
        /// </summary>
        public int RackDepth
        {
            get => _rackDepth;

            set
            {
                try
                {
                    const int minValue = 300;
                    const int maxValue = 600;
                    Validator.CheckParametersValue(minValue, maxValue,
                        value, Parameter.RackDepth);
                    _rackDepth = value;
                }
                catch (Exception ex)
                {
                    ErrorsDictionary.Add(Parameter.RackDepth,
                        ex.Message);
                }
            }
        }

        /// <summary>
        /// свойство обрабатывающее поле 
        /// высоты проектируемой 3D-модели стеллажа,
        /// содержит валидацию допустимых значений 
        /// </summary>
        public int RackHeight
        {
            get => _rackHeight;

            set
            {
                try
                {
                    const int minValue = 1000;
                    const int maxValue = 3000;
                    Validator.CheckParametersValue(minValue, maxValue,
                        value, Parameter.RackHeight);
                    _rackHeight = value;
                }
                catch (Exception ex)
                {
                    ErrorsDictionary.Add(Parameter.RackHeight,
                        ex.Message);
                }
            }
        }

        /// <summary>
        /// свойство обрабатывающее поле 
        /// ширины материала проектируемой 3D-модели стеллажа,
        /// содержит валидацию допустимых значений 
        /// </summary>
        public int RackWidth
        {
            get => _rackWidth;

            set
            {
                try
                {
                    const int minValue = 300;
                    const int maxValue = 800;
                    Validator.CheckParametersValue(minValue, maxValue,
                        value, Parameter.RackWidth);
                    _rackWidth = value;
                }
                catch (Exception ex)
                {
                    ErrorsDictionary.Add(Parameter.RackWidth,
                        ex.Message);
                }
            }
        }

        /// <summary>
        /// свойство обрабатывающее поле 
        /// количества полок проектируемой 3D-модели стеллажа,
        /// содержит валидацию допустимых значений 
        /// </summary>
        public int ShelvesNumber
        {
            get => _shelvesNumber;

            set
            {
                try
                {
                    const int minValue = 2;
                    Validator.CheckParametersValue(minValue, (_rackHeight -
                        _heightFromFloor - _materialThickness) % 200,
                        value, Parameter.ShelvesNumber);
                    _shelvesNumber = value;
                }
                catch (Exception ex)
                {
                    ErrorsDictionary.Add(Parameter.ShelvesNumber,
                        ex.Message);
                }
            }
        }

        /// <summary>
        /// свойство обрабатывающее поле 
        /// высоту полок проектируемой 3D-модели стеллажа,
        /// содержит валидацию допустимых значений 
        /// </summary>
        public int ShelvesHeight
        {
            get => _shelvesHeight;

             set
            {
                try
                {
                    const int minValue = 200;
                    Validator.CheckParametersValue(minValue, (_rackHeight -
                        _heightFromFloor - _materialThickness) / 2,
                        value, Parameter.ShelvesHeight);
                    _shelvesHeight = value;
                }
                catch (Exception ex)
                {
                    ErrorsDictionary.Add(Parameter.ShelvesHeight,
                        ex.Message);
                }

            }
        }

        /// <summary>
        /// метод, рассчитывающий расстояние между полками, 
        /// при текущих значениях
        /// </summary>
        private int SetShelvesHeight()
        {
            if (ErrorsDictionary.Count == 0)
            {
                var currentValue = (_rackHeight - _heightFromFloor -
                    _materialThickness * _shelvesNumber) / _shelvesNumber;
                return currentValue;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// конструктор класса, присваивающий значения
        /// </summary>
        public RackParameters(int heightFromFloor, int materialThickness,
           int rackDepth, int rackHeight, int rackWidth, int shelvesNumber) 
        {
            ErrorsDictionary.Clear();
            HeightFromFloor = heightFromFloor;
            MaterialThickness = materialThickness;
            RackDepth = rackDepth;
            RackHeight = rackHeight;
            RackWidth = rackWidth;
            ShelvesNumber = shelvesNumber;
            ShelvesHeight = SetShelvesHeight();
        }

    }
}
