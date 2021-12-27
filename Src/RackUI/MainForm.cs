using System;
using System.Drawing;
using System.Windows.Forms;
using RackBuilder;
using Rack;

namespace RackUI
{
    /// <summary>
    /// публичный класс предназначенный для реализации интерфейса
    /// </summary>
    public partial class MainForm : Form
    {

       /// <summary>
       ///  цвет, 
       /// сигнализирующий о неверном вводе значения параметра
       /// </summary>
        private Color _incorrentInputColor = Color.Red;

        /// <summary>
        /// 
        /// </summary>
        private RackModelBuilder _builder;

        /// <summary>
        /// текущие параметры 3D-модели,
        /// изначально им присваиваются значения по умолчанию
        /// </summary>
        private RackParameters _currentParameters =
            RackParameters.DefaultParameters;


        /// <summary>
        /// инициализация главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// приватный метод, проверяющий введенное в textbox значение
        /// </summary>
        /// <param name="textBox">проверяемое поле ввода</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">исключение, в случае,
        /// если введено не целове число</exception>
        private int IntParse (TextBox textBox)
        {
            try
            {
                Color correntInputColor = Color.White;
                int temp = Int32.Parse(textBox.Text);
                textBox.BackColor = correntInputColor;
                return temp;
            }
            catch
            {
                textBox.BackColor = _incorrentInputColor;
                throw new ArgumentException(
                    "Введено не целое число");
            }
        }

        /// <summary>
        /// приватный метод, исполняется после нажатия кнопки "Построить"
        /// запускает проверку на целочисленность введенных значений,
        /// проверяет наличие записей в словаре ошибок 
        /// и выводит их с помощью оповещения в отдельном окне,
        /// запускает функцию сборки проектируемой 3D-модели
        /// </summary>
        private void BuildButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                CombiningShelvesType combiningType = 
                    CombiningShelvesType.NoneCombining;

                if (CombiningShelvesUpRadioButton.Checked)
                {
                    combiningType = CombiningShelvesType.CombiningUp;
                }
                else if(CombiningShelvesDownRadioButton.Checked)
                {
                    combiningType = CombiningShelvesType.CombiningDown;
                }

                _currentParameters =
                    new RackParameters(
                        IntParse(HeightFromFloor),
                        IntParse(MaterialThickness),
                        IntParse(RackDepth),
                        IntParse(RackHeight),
                        IntParse(RackWidth),
                        IntParse(ShelvesNumber),
                        IntParse(NumberCombinedShelves),
                        combiningType);

                if (_currentParameters.ErrorsDictionary.Count != 0)
                {
                    string message = null;
                    foreach (var param in 
                        _currentParameters.ErrorsDictionary.Keys)
                    {
                        message += 
                           _currentParameters.ErrorsDictionary[param]
                           + "\n";
                       string textboxname = param.ToString();
                       TextBox textBox =
                            Controls.Find(textboxname,false)[0] 
                           as TextBox;
                        textBox.BackColor = _incorrentInputColor;
                    }
                        MessageBox.Show(
                           message,
                           "Ошибка ввода",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error
                        );
                        return;
                }

                _builder = new RackModelBuilder();
                _builder.Assembly(_currentParameters);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// вызов схемы проектируемой 3D-модели
        /// </summary>
        private void SchemeButton_Click(object sender, EventArgs e)
        {
            var scheme = new Scheme();
            scheme.Show();
        }

        /// <summary>
        /// приватный метод отвечающий за включение\выключение
        /// ввода параметров связанных с объединением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CombiningShelvesCheckBox_CheckedChanged
            (object sender, EventArgs e)
        {
            if (CombiningShelvesCheckBox.Checked)
            {
                EnableCombining(true);
            }
            else
            {
                EnableCombining(false);
                NumberCombinedShelves.Text = "1";
            }
        }

        /// <summary>
        /// приватный метод отвечающий за
        /// включение\выключение полей для объединения полок
        /// </summary>
        /// <param name="isEnabled">включить или выключить
        /// объединение</param>
        private void EnableCombining(bool isEnabled)
        {
            CombiningShelvesDownRadioButton.Enabled = isEnabled;
            CombiningShelvesUpRadioButton.Enabled = isEnabled;
            NumberCombinedShelves.Enabled = isEnabled;
            CombiningShelvesLabelDown.Enabled = isEnabled;
            CombiningShelvesLabelUp.Enabled = isEnabled;
            CombiningShelvesDownRadioButton.Checked = isEnabled;
            CombiningShelvesUpRadioButton.Checked = isEnabled;
        }

        /// <summary>
        /// метод для подсчета и вывода
        /// количества доступных для создания полок
        /// для объединения
        /// </summary>
        private void ShelvesNumber_TextChanged(object sender, EventArgs e)
        {
            var wasParsed = Int32.TryParse(ShelvesNumber.Text,
                out int result);
            var resultMessage = wasParsed
                ? $"{result - 1}"
                : "n";
            CombiningShelvesLabelDown.Text = $@"(от 1 до {resultMessage})";
        }
       
        //TODO: Дубли
        /// <summary>
        /// обновить запись о диапазоне количества полок,
        /// когда меняется толщина материала
        /// высота стеллажа
        /// высота от пола до нижней полки
        /// </summary>
        private void ShelvesParameters_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(RackHeight.Text,
                out int rackHeight);
            Int32.TryParse(HeightFromFloor.Text,
                out int heightFromFloor);
            Int32.TryParse(MaterialThickness.Text,
                out int materialThickness);
            int shelvesNumber =
                (rackHeight - heightFromFloor - materialThickness) / 200;
            label7.Text = $"(от 2 до " + $"{shelvesNumber - 1})";
        }

    }
}
