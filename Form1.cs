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
        }


        private void saveBut_Click(object sender, EventArgs e)
        {

        }

        private void date_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;

            string date = selectedDate.ToString("dd.MM.yyyy");

            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("Выбранная дата уже прошла");
            }
        }
    }
}
