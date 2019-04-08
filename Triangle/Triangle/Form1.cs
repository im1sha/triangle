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
            var determiner = new TypeDeterminer();

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
                MessageBox.Show("Введите числовые значения длин для трех сторон треугольника. Значения длин сторон должны принадлежать промежутку от 1 до 9223372036854775807",
                               "Ошибка ввода",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                labelOutput.Text = "";
                return;
            }
                            
            if (!determiner.AreSidesInBounds(new[] { a, b, c }))
            {
                MessageBox.Show("Значения длин сторон должны принадлежать промежутку от 1 до 9223372036854775807",
                               "Ошибка ввода",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                labelOutput.Text = "";
                return;
            }


            labelOutput.Text = GetResultString(determiner, a, b, c);
        }

        private string GetResultString(TypeDeterminer determiner, ulong a, ulong b, ulong c)
        {
            string result;

            if (!determiner.IsValidTriangle(a, b, c))
            {
                result =  "Введите такие значения длин сторон, для которых верно: сумма любых двух сторон больше третьей стороны";
            }
            else if (determiner.IsEquilateral(a, b, c))
            {
                result = "Равносторонний треугольник";
            }
            else if (determiner.IsIsosceles(a, b, c))
            {
                result = "Равнобедренный треугольник";
            }
            else
            {
                result = "Неравносторонний треугольник";
            }

            return result;
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


