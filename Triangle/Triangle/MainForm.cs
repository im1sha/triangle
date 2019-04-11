using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class MainForm : Form, Core.View.IView
    {
        private readonly Core.Presenter.IPresenter presenter;

        #region IView

        public string SideA
        {
            get => textBoxA.Text;
            private set { textBoxA.Text = value; }
        }
        public string SideB
        {
            get => textBoxB.Text;
            private set { textBoxB.Text = value; }
        }
        public string SideC
        {
            get => textBoxC.Text;
            private set { textBoxC.Text = value; }
        }
        public string Output
        {
            get => labelOutput.Text;
            private set { labelOutput.Text = value; }
        }

        #endregion

        public string[] LabelsNames { get => new[] { labelA.Text, labelB.Text, labelC.Text }; }

        public MainForm()
        {
            InitializeComponent();
            presenter = new Core.Presenter.MainPresenter(this);
        }

        private void OnCalculate(object sender, EventArgs e)
        {
            try
            {
                Output = presenter?.GetTriangleType(SideA, SideB, SideC, LabelsNames);
            }
            catch (ApplicationException ex)
            {
                Output = string.Empty;
                MessageBox.Show(ex.Message.ToString(), "Проверьте введенные данные");
            }             
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender is TextBox) && presenter != null)
            {
                if (presenter.IsInputCharValid((sender as TextBox).Text, e.KeyChar))
                {
                    return;
                }
                e.Handled = true;
            }
        }

        private void OnLeave(object sender, EventArgs e)
        {
            if ((sender is TextBox) && presenter != null)
            {
                (sender as TextBox).Text = presenter.HandleInput((sender as TextBox).Text);
            }
        }
    }
}


