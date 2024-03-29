﻿using System;

namespace Rack
{
    /// <summary>
    /// статический класс для проверки корректности введенных значений
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// статический метод, выполняющий проверку 
        /// заданного значения на соответсвие диапазону
        /// </summary>
        /// <param name="minValue">минимальное значение</param>
        /// <param name="maxValue">максимальное значение</param>
        /// <param name="value">проверяемое значение</param>
        /// <param name="parametersType">параметр проверяемого значения</param>
        /// <exception cref="ArgumentException">исключение вызываемое при 
        /// несоответсвии заданного значения диапазону</exception>
        public static void CheckParametersValue(int minValue, 
            int maxValue, int value, ParametersType parametersType)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException
                    ($"Значение параметра {parametersType}" +
                    $" не вошло в диапазон");
            }
        }
    }
}
