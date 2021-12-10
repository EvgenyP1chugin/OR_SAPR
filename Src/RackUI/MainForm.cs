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
        /// цвет, 
        /// сообщающий о верно введенном значении параметра
        /// </summary>
        private Color _correntInputColor = Color.White;

        /// <summary>
        /// 
        /// </summary>
        private RackModelBuilder _builder;

        /// <summary>
        /// текущие параметры 3D-модели,
        /// изначально им присваиваются значения по умолчанию
        /// </summary>
        private RackParameters _currentParameters = DefaultParameters;

        /// <summary>
        /// установка значений по умолчанию 
        /// для проектируемой 3D-модели стеллажа 
        /// </summary>
        public static RackParameters DefaultParameters => 
            new RackParameters(80, 10, 300, 1000, 300, 2);
        
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
                int temp = Int32.Parse(textBox.Text);
                textBox.BackColor = _correntInputColor;
                return temp;
            }
            catch
            {
                textBox.BackColor = _incorrentInputColor;
                throw new ArgumentException("Введено не целое число");
            }
        }

        /// <summary>
        /// приватный метод, исполняется после нажатия кнопки "Построить"
        /// запускает проверку на целоцисленность введенных значений,
        /// проверяет наличие записей в словаре ошибок 
        /// и выводит их с помощью оповещения в отдельном окне,
        /// запускает функцию сборки проектируемой 3D-модели
        /// </summary>
        private void BuildButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                _currentParameters =
                   new RackParameters(IntParse(HeightFromFloor),
                   IntParse(MaterialThickness),
                   IntParse(RackDepth),
                   IntParse(RackHeight),
                   IntParse(RackWidth),
                   IntParse(ShelvesNumber));

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
                            Controls.Find(textboxname,true)[0] 
                            as TextBox;
                         textBox.BackColor = _incorrentInputColor;
                     }
                         MessageBox.Show
                        (
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
            var Scheme = new Scheme();
            Scheme.Show();
        }

    }
}
