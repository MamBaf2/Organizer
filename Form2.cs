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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = Data.Date;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = Data.Time;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = Data.Type;
        }
    }
}
