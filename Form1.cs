using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Установка начальных подсказок и цветов
            txtLog.Text = "Введите логин";
            txtLog.ForeColor = System.Drawing.Color.Gray;

            txtPass.Text = "Введите пароль";
            txtPass.PasswordChar = '\0'; // Отображение текста пароля
            txtPass.ForeColor = System.Drawing.Color.Gray;
            // Настройка события для CheckBox
            checkShow.CheckedChanged += checkShow_CheckedChanged;
        }
        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            // Показать/скрыть текст пароля при изменении состояния CheckBox
            txtPass.PasswordChar = checkShow.Checked ? '\0' : '*';
        }

        private void txtLog_Enter(object sender, EventArgs e)
        {
            // Очистка подсказки при клике на поле
            if (txtLog.Text == "Введите логин")
            {
                txtLog.Text = "";
                txtLog.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtLog_Leave(object sender, EventArgs e)
        {
            // Восстановление подсказки, если поле пусто
            if (string.IsNullOrWhiteSpace(txtLog.Text))
            {
                txtLog.Text = "Введите логин";
                txtLog.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            // Подсказка при вводе пароля
            if (txtPass.Text == "Введите пароль")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*'; // Скрытие текста пароля
                txtPass.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            // Восстановление подсказки, если поле пусто
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.Text = "Введите пароль";
                txtPass.PasswordChar = '\0'; // Отображение текста пароля
                txtPass.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnEnt_Click(object sender, EventArgs e)
        {
            // Логика для кнопки входа
            string login = txtLog.Text;
            string password = txtPass.Text;
            // Проверка логина и пароля
            if (login == "mamba" && password == "banan")
            {
                /* Открываем вторую форму при успешной авторизации
                Form2 form2 = new Form2();
                form2.Show(); */

            }
            else
            {
                // Выводим сообщение об ошибке при неверном логине или пароле
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Закрытие приложения
            Application.Exit();
        }
    }
}
