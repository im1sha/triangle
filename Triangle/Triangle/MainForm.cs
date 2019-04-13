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
        private readonly Core.Model.InputSerializer serializer = new Core.Model.InputSerializer();

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

        private void OnGetType(object sender, EventArgs e)
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

        private void OnLeaveInput(object sender, EventArgs e)
        {
            if ((sender is TextBox) && presenter != null)
            {
                (sender as TextBox).Text = presenter.HandleInput((sender as TextBox).Text);
            }
        }

        private void OnHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Для того чтобы узнать тип вашего треугольника введите " +
                "в поля ввода \"Сторона А\", \"Сторона B\" и \"Сторона C\" " +
                "целые положительные числа.\n" +
                "Затем нажмите на кнопку \"Определить тип треугольника\".\n" +
                "В нижней части окна приложения будет показан тип вашего треугольника\n\n" + 
                "Для сохранения введенных сторон нажмите кнопку \"Сохранить введенные стороны\".\n" +
                "Для загрузки ранее введенных сторон нажмите кнопку \"Загрузить введенные стороны\".", 
                "Инструкция пользования программой");
        }

        
        private void OnAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа предназначена для определения типа треугольника.\n\n" +
                "2019, Михаил Овчелупов", "О программе");
        }

        private void OnLoad(object sender, EventArgs e)
        {
            try
            {
                string[] deserializedData = serializer.Deserialize().Strings;
                SideC = deserializedData[2];
                SideB = deserializedData[1];
                SideA = deserializedData[0];
                MessageBox.Show("Стороны треугольника загружены", "Загрузка введенных сторон");
            }
            catch
            {
                MessageBox.Show("Не найдено сохраненных данных", "Ошибка загрузки");
            }
        }

        private void OnSave(object sender, EventArgs e) 
        {
            try
            {
                serializer.Serialize(new Core.Model.InputSerializer.Input(new[] { SideA, SideB, SideC }));
                MessageBox.Show("Стороны треугольника сохранены", "Сохранение введенных сторон");
            }
            catch 
            {
                MessageBox.Show("Пожалуйста, проверьте введенные данные", "Ошибка сохранения");
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


