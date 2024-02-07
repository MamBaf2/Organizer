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
        private ToolTip toolTipLogin;
        private ToolTip toolTipPassword;
        public Form1()
        {
            InitializeComponent();
            txtPass.Text = "";
            txtPass.PasswordChar = '\0'; // Отображение текста пароля
            txtPass.ForeColor = System.Drawing.Color.Black;
            // Настройка события для CheckBox
            checkShow.CheckedChanged += checkShow_CheckedChanged;
            // Инициализация объектов ToolTip
            toolTipLogin = new ToolTip();
            toolTipPassword = new ToolTip();

            // Установка подсказок для полей ввода
            toolTipLogin.SetToolTip(txtLog, "Введите ваш логин");
            toolTipPassword.SetToolTip(txtPass, "Введите ваш пароль");
        }
        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            // Показать/скрыть текст пароля при изменении состояния CheckBox
            txtPass.PasswordChar = checkShow.Checked ? '\0' : '*';
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            // 
            if (txtPass.Text == "")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*'; // Скрытие текста пароля
                txtPass.ForeColor = System.Drawing.Color.Black;
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
