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
    public partial class frmtimkiem : Form
    {
        Clsdatabase cls = new Clsdatabase();

        public frmtimkiem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int i = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void frmtimkiem_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan");
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
