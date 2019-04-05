using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangle.Logic;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnCalculate(object sender, EventArgs e)
        {
            var triangle = new Shape();

            ulong a = 0, b = 0, c = 0;

            bool areLengthsPositive = HavePositiveLength(new[] { textBoxA.Text, textBoxB.Text, textBoxC.Text });

            if (areLengthsPositive)
            {
                a = Convert.ToUInt64(textBoxA.Text);
                b = Convert.ToUInt64(textBoxB.Text);
                c = Convert.ToUInt64(textBoxC.Text);
            }
            else
            {
                MessageBox.Show("Введите значения длин для всех сторон треугольника.",
                               "Ошибка ввода",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                labelOutput.Text = "";
                return;
            }
                            
            if (!triangle.AreSidesInBounds(new[] { a, b, c }))
            {
                MessageBox.Show($"Диапазон допустимых значений сторон треуголника: от 1 до {(ulong.MaxValue / 2).ToString()}. \n" +
                               "Введите допустимые значения для длин сторон треугольника.",
                               "Ошибка ввода",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                labelOutput.Text = "";
                return;
            }

            if (triangle.IsEquilateral(a, b, c))
            {
                labelOutput.Text = "Равносторонний треугольник";
            }
            else if (triangle.IsIsosceles(a, b, c))
            {
                labelOutput.Text = "Равнобедренный треугольник";
            }
            else if (triangle.IsValidTriangle(a, b, c))
            {
                labelOutput.Text = "Неравносторонний треугольник";
            }
            else
            {
                labelOutput.Text = "Треугольник не существует";
            }
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {       

            if (e.KeyChar == (char)8)
            {
                return;
            }

            if ((sender is TextBox) && ((sender as TextBox).Text.Length == (ulong.MaxValue / 2).ToString().Length))
            {
                e.Handled = true; 
            }

            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }          
        }

        private bool HavePositiveLength(string[] strs)
        {
            return strs.All(str => str != null && str.Length > 0);
        }
    }
}


