using System;
using Rack;
using NUnit.Framework;

namespace RackTests


{
    /// <summary>
    /// класс тестирования валидатора
    /// </summary>
    [TestFixture]
    public class ValidatorTest
    {

        [TestCase(999,1000,3000,ParametersType.RackHeight, TestName =
            "Негативный - ввод значений вне диапазона")]
        public void Validator_SetNegative(int incorrectValue,
            int minValue,int maxValue, ParametersType parametersType)
        {

            Assert.Throws<ArgumentException>(() =>
                    Validator.CheckParametersValue
                        (minValue,maxValue,incorrectValue,parametersType),
                $"Значение высоты стеллажа введено неверно.");

        }

        [TestCase(1005,1000,3000,ParametersType.RackHeight, TestName =
            "Позитивный - ввод значений в диапазоне")]
        public void Validator_SetPositive(int correctValue,
            int minValue,int maxValue, ParametersType parametersType)
        {
            Assert.DoesNotThrow(() => Validator.CheckParametersValue(minValue, maxValue,
                correctValue, parametersType), $"значение вышло за пределы");
        }
    }
}
