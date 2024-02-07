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
    public partial class Form3 : Form
    {
        // Создаем событие для оповещения о сохранении данных
        public event EventHandler DataSaved;

        public Form3()
        {
            InitializeComponent();
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            Data.Event = text.Text;
            Data.Date = dateCal.SelectionRange.Start.ToShortDateString();
            DateTime dateTime = timePic.Value;
            Data.Time = dateTime.TimeOfDay;
            Data.Type = this.typeCombo.GetItemText(this.typeCombo.SelectedItem);

            // Вызываем событие, когда данные сохранены
            DataSaved?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        private void dateCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("Выбранная дата уже прошла");
            }
        }
    }
}
