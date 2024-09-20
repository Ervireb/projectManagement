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
        public Form1()
        {
            InitializeComponent();
            var presenter = new Presenter(this);
            buttonLoad.Click += ButtonLoad_Click; // Подписка на событие кнопки
            textBoxInfo.TextChanged += textBoxInfo_TextChanged; // Подписка на событие изменения текста
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            clickCount++; // Увеличиваем счётчик нажатий

            switch (clickCount)
            {
                case 1:
                    DisplayData("Hello, MVP!"); break;
                case 2:
                    DisplayData("Котики — это милые домашние животные."); break;
                case 3:
                    DisplayData("Они известны своей независимостью и игривым характером."); break;
                case 4:
                    DisplayData("Котики могут быть разного цвета и породы."); break;
                case 5:
                    DisplayData("/ᐠ｡ꞈ｡ᐟ\\");break;
                case 6:
                    DisplayData("ᓚᘏᗢ"); break;
                default:
                    DisplayData("( ⓛ ω ⓛ *)"); break;
            }
        }

        public void DisplayData(string data)
        {
            textBoxInfo.Text = data; // Отображение данных в текстовом поле
        }
        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить логику, которая будет выполняться при изменении текста
            // например
            // MessageBox.Show("Текст изменён: " + textBoxInfo.Text);
        }
    }
}

