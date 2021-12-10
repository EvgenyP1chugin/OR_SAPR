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
        [TestCase(999,1000,3000,Parameter.RackHeight, TestName =
            "Негативный - ввод значений вне диапазона")]
        public void RackHeight_SetPositive(int incorrectValue,
            int minValue,int maxValue, Parameter parameter)
        {

            Assert.Throws<ArgumentException>(() =>
                    Validator.CheckParametersValue
                        (minValue,maxValue,incorrectValue,parameter),
                $"Значение высоты стеллажа введено неверно.");

        }
    }
}
