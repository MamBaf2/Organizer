using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Organizer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Привязываем обработчики событий изменения состояния RadioButton
            cat.CheckedChanged += RadioButton_CheckedChanged;
            ev.CheckedChanged += RadioButton_CheckedChanged;
            // По умолчанию скрываем ComboBox и TextBox
            cBox.Visible = false;
            text.Visible = false;
            KeyPreview = true;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Проверяем, какой RadioButton был выбран
            if (sender == cat)
            {
                // При выборе RadioButton "cat" делаем ComboBox видимым и TextBox невидимым
                cBox.Visible = true;
                text.Visible = false;
            }
            else if (sender == ev)
            {
                // При выборе RadioButton "ev" делаем ComboBox невидимым и TextBox видимым
                cBox.Visible = false;
                text.Visible = true;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Загружаем данные при загрузке формы
            LoadEventData(); // Этот метод не определен
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            // Открываем третью форму и подписываемся на событие сохранения данных
            Form3 form3 = new Form3();
            form3.DataSaved += Form3_DataSaved;
            form3.Show();
        }

        private void Form3_DataSaved(object sender, EventArgs e)
        {
            // Добавляем новые данные в DataGridView при сохранении данных из Form3
            AddEventDataToGridView(); // Используем метод AddEventDataToGridView
        }

        private void AddEventDataToGridView()
        {
            // Добавляем новую строку с данными из Data в DataGridView
            int rowIndex = dataGridView1.Rows.Add(Data.Type, Data.Date, Data.Time, Data.Event);
            // Прокручиваем DataGridView к новой строке
            dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
        }

        private void LoadEventData()
        {
            // Здесь можно загрузить начальные данные в DataGridView
        }
        // Обработчик нажатия клавиш на форме
        protected override void OnKeyDown(KeyEventArgs e)
        {
            // Обработка комбинаций клавиш
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Ctrl+S - сохранение данных в файл
                SaveDataToFile();
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                // Ctrl+O - открытие файла
                OpenFileWithData();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                // Del - удаление выделенной строки в DataGridView
                DeleteSelectedRow();
            }

            base.OnKeyDown(e);
        }

        private void SaveDataToFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save Data";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                         /*Записываем заголовки столбцов
                        writer.WriteLine("Дата,Время,События");*/

                        // Записываем данные из DataGridView в файл
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            string date = row.Cells[0].Value.ToString();
                            string time = row.Cells[1].Value.ToString();
                            string type = row.Cells[2].Value.ToString();

                            writer.WriteLine($"{date},{time},{type}");
                        }
                    }

                    MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenFileWithData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Открыть данные";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Читаем данные из файла
                    List<string[]> data = new List<string[]>();
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] values = line.Split(',');
                            data.Add(values);
                        }
                    }

                    // Очищаем DataGridView перед загрузкой новых данных
                    dataGridView1.Rows.Clear();

                    // Загружаем данные из файла в DataGridView
                    foreach (var values in data)
                    {
                        dataGridView1.Rows.Add(values);
                    }

                    MessageBox.Show("Данные успешно загружены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteSelectedRow()
        {
            // Проверяем, есть ли выделенные строки
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Удаляем каждую выделенную строку
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }
        private void FilterDataByCategory(string selectedCategory)
        {
            // Показываем все строки
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }

            // Проходим по всем строкам DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Получаем значение категории из ячейки DataGridView
                string category = row.Cells[2].Value.ToString();

                // Проверяем, соответствует ли текущая строка выбранной категории
                if (category != selectedCategory)
                {
                    // Скрываем строку, если она не соответствует выбранной категории
                    row.Visible = false;
                }
            }

            // Обновляем список элементов в ComboBox
            UpdateComboBoxItems();
    }
        private void UpdateComboBoxItems()
        {
            // Очищаем список элементов ComboBox
            cBox.Items.Clear();

            // Проходим по всем строкам DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Получаем значение категории из ячейки DataGridView
                string category = row.Cells[2].Value.ToString();

                // Если категория еще не добавлена в ComboBox, добавляем ее
                if (!cBox.Items.Contains(category))
                {
                    cBox.Items.Add(category);
                }
            }
        }

        private void filBut_Click(object sender, EventArgs e)
        {
           // Получаем выбранный элемент из ComboBox
            string selectedCategory = cBox.SelectedItem?.ToString();

            // Вызываем метод фильтрации
            FilterDataByCategory(selectedCategory);
        }
    }
}
