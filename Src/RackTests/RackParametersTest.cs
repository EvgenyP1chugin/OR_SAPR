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

        [TestCase(1000, TestName = "Позитивный - ввод высоты стеллажа")]
        public void RackHeight_SetPositive(int correctValue)
        {
            var rackParameters = RackParameters;
            var value = correctValue;
            var expected = correctValue;

            rackParameters.RackHeight = value;
            var actual = rackParameters.RackHeight;

            Assert.AreEqual(expected, actual,
                $"Значение высоты стеллажа введено неверно.");

        }

        [TestCase(80, TestName = "Позитивный - ввод высоты пространства" +
                                 " от пола до нижней полки")]
        public void HeightFromFloor_SetPositive(int correctValue)
        {
            var rackParameters = RackParameters;
            var value = correctValue;
            var expected = correctValue;

            rackParameters.HeightFromFloor = value;
            var actual = rackParameters.HeightFromFloor;

            Assert.AreEqual(expected, actual,
                $"Значение высоты пространства " +
                $"от пола до нижней полки введено неверно.");
        }

        [TestCase(10, TestName = "Позитивный - ввод толщины материала")]
        public void MaterialThickness_SetPositive(int correctValue)
        {
            var rackParameters = RackParameters;
            var value = correctValue;
            var expected = correctValue;

            rackParameters.MaterialThickness = value;
            var actual = rackParameters.MaterialThickness;

            Assert.AreEqual(expected, actual,
                $"Значение толщины материала введено неверно.");
        }

        [TestCase(300, TestName = "Позитивный - ввод глубины стеллажа")]
        public void RackDepth_SetPositive(int correctValue)
        {
            var rackParameters = RackParameters;
            var value = correctValue;
            var expected = correctValue;

            rackParameters.RackDepth = value;
            var actual = rackParameters.RackDepth;

            Assert.AreEqual(expected, actual,
                $"Значение глубины стеллажа введено неверно.");
        }

        [TestCase(300, TestName = "Позитивный - ввод ширины стеллажа")]
        public void RackWidth_SetPositive(int correctValue)
        {
            var rackParameters = RackParameters;
            var value = correctValue;
            var expected = correctValue;

            rackParameters.RackWidth = value;
            var actual = rackParameters.RackWidth;

            Assert.AreEqual(expected, actual,
                $"Значение ширины стеллажа введено неверно.");
        }

        [TestCase(2, TestName = "Позитивный - ввод кол-ва полок")]
        public void ShelvesNumber_SetPositive(int correctValue)
        {
            var rackParameters = RackParameters;
            var value = correctValue;
            var expected = correctValue;

            rackParameters.ShelvesNumber = value;
            var actual = rackParameters.ShelvesNumber;

            Assert.AreEqual(expected, actual,
                $"Количество полок введено неверно.");
        }

        [TestCase(200, TestName = "Позитивный - ввод высоты полок")]
        public void ShelvesHeight_SetPositive(int correctValue)
        {
            var rackParameters = RackParameters;
            var value = correctValue;
            var expected = correctValue;

            rackParameters.ShelvesHeight = value;
            var actual = rackParameters.ShelvesHeight;

            Assert.AreEqual(expected, actual,
                $"Количество полок введено неверно.");
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