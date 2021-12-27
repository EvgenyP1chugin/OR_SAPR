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
        /// Количество полок, которые будут объединены
        /// </summary>
        private int _numberCombinedShelves;

        /// <summary>
        /// словарь для хранения ошибок ввода
        /// </summary>
        public Dictionary<ParametersType, string> ErrorsDictionary { get;}
            = new Dictionary<ParametersType, string>();
        
        /// <summary>
        /// установка значений по умолчанию 
        /// для проектируемой 3D-модели стеллажа 
        /// </summary>
        public static RackParameters DefaultParameters =>
            new RackParameters(80, 10, 
                300, 1000, 300, 
                2, 1,
                CombiningShelvesType.NoneCombining);

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
                const int minValue = 80;
                const int maxValue = 100;
                SetValue(ref _heightFromFloor, value, minValue,
                    maxValue, ParametersType.HeightFromFloor);
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
                const int minValue = 10;
                const int maxValue = 20;
                SetValue(ref _materialThickness, value, minValue,
                    maxValue, ParametersType.MaterialThickness);
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
                const int minValue = 300;
                const int maxValue = 600;
                SetValue(ref _rackDepth, value, minValue,
                    maxValue, ParametersType.RackDepth);
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
                const int minValue = 1000;
                const int maxValue = 3000;
                SetValue(ref _rackHeight, value, minValue,
                    maxValue, ParametersType.RackHeight);
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
                const int minValue = 300;
                const int maxValue = 800;
                SetValue(ref _rackWidth, value, minValue,
                    maxValue, ParametersType.RackWidth);
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
                const int minValue = 2; 
                int maxValue = (_rackHeight 
                                - _heightFromFloor 
                                - _materialThickness) / 200;
                SetValue(ref _shelvesNumber, value, minValue,
                    maxValue, ParametersType.ShelvesNumber);
              
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
                const int minValue = 200;
                int maxValue = (_rackHeight 
                                - _heightFromFloor 
                                - _materialThickness) / 2;
                SetValue(ref _shelvesHeight, value, minValue,
                    maxValue, ParametersType.ShelvesHeight);

             }
        }
        /// <summary>
        /// свойство обрабатывающее ввод
        /// количества полок для объединения
        /// </summary>
        public int NumberCombinedShelves
        {
            get => _numberCombinedShelves;
            
            set
            {
                const int minValue = 1;
                int maxValue = _shelvesNumber - 1;
                SetValue(ref _numberCombinedShelves, value, 
                    minValue, maxValue, 
                    ParametersType.NumberCombinedShelves);
            }
        }
       
        /// <summary>
        /// конструктор объединения полок
        /// </summary>
        public CombiningShelvesType CombiningShelvesType { get; set;}
       
        /// <summary>
        /// метод, рассчитывающий расстояние между полками, 
        /// при текущих значениях
        /// </summary>
        private int SetShelvesHeight()
        {
            if (ErrorsDictionary.Count == 0)
            {
                var currentValue = (_rackHeight - _heightFromFloor -
                    _materialThickness) / _shelvesNumber;
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
        /// <param name="heightFromFloor">высота пространства
        /// от пола до нижней полки</param>
        /// <param name="materialThickness">толщина материала</param>
        /// <param name="rackDepth">глубина стеллажа</param>
        /// <param name="rackHeight">высота стеллажа</param>
        /// <param name="rackWidth">ширина стеллажа</param>
        /// <param name="shelvesNumber">количество полок</param>
        /// <param name="numberCombinedShelves">кол-во полок для объединения</param>
        /// <param name="combiningType">тип объединения</param>
        public RackParameters(int heightFromFloor, int materialThickness,
            int rackDepth, int rackHeight, int rackWidth,
            int shelvesNumber, int numberCombinedShelves,
            CombiningShelvesType combiningType)
        {
            ErrorsDictionary.Clear();
            HeightFromFloor = heightFromFloor;
            MaterialThickness = materialThickness;
            RackDepth = rackDepth;
            RackHeight = rackHeight;
            RackWidth = rackWidth;
            ShelvesNumber = shelvesNumber;
            NumberCombinedShelves = numberCombinedShelves;
            ShelvesHeight = SetShelvesHeight();
            CombiningShelvesType = combiningType;
        }

        /// <summary>
        /// установка значения
        /// </summary>
        /// <param name="property">зачение которое будет занесено</param>
        /// <param name="value">введенное значение</param>
        /// <param name="minValue">минимальное значение</param>
        /// <param name="maxValue">максимальное значение</param>
        /// <param name="parameter">тип параметра</param>
        public void SetValue(ref int property, int value,
            int minValue, int maxValue, ParametersType parameter)
        {
            try
            {

                Validator.CheckParametersValue(minValue, maxValue,
                    value, parameter);
                property = value;
            }
            catch (Exception ex)
            {
                ErrorsDictionary.Add(parameter,
                    ex.Message);
            }
        }
    }
}