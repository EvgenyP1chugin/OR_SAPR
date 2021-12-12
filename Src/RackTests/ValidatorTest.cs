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
        public void RackHeight_SetPositive(int incorrectValue,
            int minValue,int maxValue, ParametersType parametersType)
        {

            Assert.Throws<ArgumentException>(() =>
                    Validator.CheckParametersValue
                        (minValue,maxValue,incorrectValue,parametersType),
                $"Значение высоты стеллажа введено неверно.");

        }
    }
}
