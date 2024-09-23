using mvp_app.Presenters;
using mvp_app.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mvp_app
{
    public partial class Form1 : Form, IView
    {
        private int clickCount = 1; // Счётчик нажатий
        private float currentFontSize = 12f; // Начальный размер шрифта
        private System.Windows.Forms.TextBox textBoxTitle = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.NumericUpDown numericUpDown = new System.Windows.Forms.NumericUpDown();
        public Form1()
        {
            InitializeComponent();
            var presenter = new Presenter(this);
            buttonLoad.Click += ButtonLoad_Click; // Подписка на событие кнопки
            textBoxInfo.TextChanged += textBoxInfo_TextChanged; // Подписка на событие изменения текста
        }
        public System.Windows.Forms.Button ButtonLoad
        {
            get { return buttonLoad; }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            clickCount++; // Увеличиваем счётчик нажатий

            switch (clickCount)
            {
                case 1:
                    DisplayData("Hello, MVP!", 14f); break;
                case 2:
                    DisplayData("Котики — это милые домашние животные. Они известны своей независимостью и игривым характером. Котики могут быть разного цвета и породы.", 10f); break;
                case 3:
                    DisplayData("/ᐠ｡ꞈ｡ᐟ\\", 32f); break;
                case 4:
                    DisplayData("ᓚᘏᗢ", 46f); break; // ᗢᘗᓗ
                default:
                    DisplayData("( ⓛ ω ⓛ *)", 32f); break;
            }
        }



        public void DisplayData(string data, float fontSize)
        {
            textBoxInfo.Text = data; // Отображение данных в текстовом поле
            textBoxInfo.Font = new Font(textBoxInfo.Font.FontFamily, fontSize);
        }
        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {
            // vvvлогика, вып. при изменении текста
            // например
            // MessageBox.Show("Текст изменён: " + textBoxInfo.Text);
        }
        public int SelectedItemId
        {
            get { return (int)numericUpDown.Value; } // Пример получения значения
            set { numericUpDown.Value = value; } // Пример установки значения
        }

        public string SelectedItemTitle
        {
            get { return textBoxTitle.Text; } // Пример получения значения
            set { textBoxTitle.Text = value; } // Пример установки значения
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

