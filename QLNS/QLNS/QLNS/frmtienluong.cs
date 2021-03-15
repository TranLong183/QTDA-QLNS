using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmtienluong : Form
    {
        public frmtienluong()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmtienluong_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
        }
    }
}
