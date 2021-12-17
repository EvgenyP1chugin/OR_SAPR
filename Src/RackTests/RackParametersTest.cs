using Rack;
using NUnit.Framework;

namespace RackTests
{
    /// <summary>
    /// класс тестирования ввода параметров стеллажа
    /// </summary>
    [TestFixture]
    public class RackParametersTest
    {
        /// <summary>
        /// Экземпляр стеллажа со значениями по умолчанию
        /// </summary>
        private static RackParameters RackParameters =>
            new RackParameters(80, 10, 300, 1000, 300, 2);

        [TestCase(10,ParametersType.MaterialThickness, TestName =
            "Позитивный - ввод толщины материала")]
        [TestCase(80,ParametersType.HeightFromFloor, TestName = 
            "Позитивный - ввод высоты пространства" +
            " от пола до нижней полки")]
        [TestCase(1000,ParametersType.RackHeight , TestName =
            "Позитивный - ввод высоты стеллажа")]
        [TestCase(300,ParametersType.RackDepth, TestName =
            "Позитивный - ввод глубины стеллажа")]
        [TestCase(300,ParametersType.RackWidth, TestName =
            "Позитивный - ввод ширины стеллажа")]
        [TestCase(2,ParametersType.ShelvesNumber, TestName =
            "Позитивный - ввод кол-ва полок")]
        [TestCase(200,ParametersType.ShelvesHeight, TestName =
            "Позитивный - ввод высоты полок")]
        public void RackParameters_SetPositive( int correctValue,
            ParametersType parameter)
        {
            var rackParameters = RackParameters;
            var value = correctValue;
            var expected = correctValue;

            var propertyInfo = typeof(RackParameters).
                GetProperty(parameter.ToString());
            propertyInfo.SetValue(rackParameters, value);

            var actual = propertyInfo.GetValue(rackParameters);

            Assert.AreEqual(expected, actual,
                $"Значение {parameter} введено неверно.");

        }


        [TestCase(ParametersType.RackHeight,
            "Значение параметра RackHeight не вошло в диапазон",
           TestName = "Позитивный - проверка совпадения текста ошибки" +
                      " при вводе высоты стеллажа")]
        [TestCase(ParametersType.HeightFromFloor,
            "Значение параметра HeightFromFloor не вошло в диапазон",
           TestName = "Позитивный - проверка совпадения текста ошибки " +
                      "при вводе высоты от пола до нижней полки")]
        [TestCase(ParametersType.RackDepth,
            "Значение параметра RackDepth не вошло в диапазон",
           TestName = "Позитивный - проверка совпадения текста ошибки " +
                      "при вводе глубины стеллажа")]
        [TestCase(ParametersType.RackWidth,
            "Значение параметра RackWidth не вошло в диапазон",
           TestName = "Позитивный - проверка совпадения текста ошибки " +
                      "при вводе ширины стеллажа")]
        [TestCase(ParametersType.ShelvesNumber,
            "Значение параметра ShelvesNumber не вошло в диапазон",
           TestName = "Позитивный - проверка совпадения текста ошибки " +
                      "при вводе количества полок")]
        [TestCase(ParametersType.MaterialThickness,
            "Значение параметра MaterialThickness не вошло в диапазон",
           TestName = "Позитивный - проверка совпадения текста ошибки " +
                      "при вводе толщины материала")]
        [TestCase(ParametersType.ShelvesHeight,
            "Значение параметра ShelvesHeight не вошло в диапазон",
            TestName = "Позитивный - проверка совпадения текста ошибки " +
                       "при вводе высоты полки")]
        public void TestGetErrors_HaveErrorsValue
            (ParametersType parametersType, string errorText)
        {
            var rackParameters = 
                new RackParameters(79, 9, 299, 999, 299, -1);

            var error = rackParameters.ErrorsDictionary[parametersType];
            var actual = error;

            Assert.AreEqual
                (errorText, actual, "Текст ошибки не совпадает");
        }

        [TestCase("", TestName = 
            "Негативный - Отправить пустую строку в словарь ошибок ")]
        [TestCase(null, TestName = "Негативный " +
                                   "- Отправить null в словарь ошибок")]
        public void TestGetErrors_NoErrorsValue(string testPropertyName)
        {
           
            var rackParameters = RackParameters;

            var actual = RackParameters.ErrorsDictionary;

            Assert.IsEmpty(actual, "Словарь не пуст");
        }

    }
}