using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RackUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(RackHeight.Text) < 1000 || double.Parse(RackHeight.Text) > 3000)
                {
                    RackHeight.BackColor = Color.Red;
                    string message = "Высота стеллажа введена неверно";
                    MessageBox.Show
                   (
                       message,
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                    );
                }
            }
            catch
            {
                string message = "Высота стеллажа введена неверно";
                MessageBox.Show
               (
                   message,
                   "Ошибка ввода",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
                RackHeight.BackColor = Color.Red;
            }

            if (double.Parse(RackDepth.Text) < 300 || double.Parse(RackDepth.Text) > 600)
            {
                string message = "Глубина стеллажа введена неверно";
                MessageBox.Show
               (
                   message,
                   "Ошибка ввода",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
                RackDepth.BackColor = Color.Red;
            }

            if (double.Parse(RackWidth.Text) < 300 || double.Parse(RackWidth.Text) > 800)
            {
                string message = "Ширина стеллажа введена неверно";
                MessageBox.Show
               (
                   message,
                   "Ошибка ввода",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
                RackWidth.BackColor = Color.Red;
            }

            if (double.Parse(HeightFromFloor.Text) < 80 || double.Parse(HeightFromFloor.Text) > 100)
            {
                string message = "Высота от пола до нижней полки введена неверно";
                MessageBox.Show
               (
                   message,
                   "Ошибка ввода",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
                HeightFromFloor.BackColor = Color.Red;
            }

            if (double.Parse(MaterialThickness.Text) < 10 || double.Parse(MaterialThickness.Text) > 20)
            {
                string message = "Толщина материала введена неверно";
                MessageBox.Show
               (
                   message,
                   "Ошибка ввода",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
                MaterialThickness.BackColor = Color.Red;
            }

            if (double.Parse(ShelvesNumber.Text) > ((double.Parse(RackHeight.Text) - double.Parse(HeightFromFloor.Text) - 
                double.Parse(MaterialThickness.Text) 
                * double.Parse(ShelvesNumber.Text) / double.Parse(ShelvesNumber.Text))))
            {
                string message = "Толщина материала введена неверно";
                MessageBox.Show
               (
                   message,
                   "Ошибка ввода",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
                ShelvesNumber.BackColor = Color.Red;
            }

        }

    }
}
