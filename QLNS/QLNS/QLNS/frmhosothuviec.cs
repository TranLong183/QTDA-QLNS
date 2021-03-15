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
    public partial class frmhosothuviec : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmhosothuviec()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void frmhosothuviec_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
    }
}
