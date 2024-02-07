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
        Form2 form2;
        public Form3()
        {
            InitializeComponent();
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            Data.Date = dateCal.SelectionRange.Start.ToShortDateString();
            DateTime dateTime = timePic.Value;
            Data.Time = dateTime.TimeOfDay;
            Data.Type = this.typeCombo.GetItemText(this.typeCombo.SelectedItem);
            form2 = new Form2();
            form2.Show();
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
