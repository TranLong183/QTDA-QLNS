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
    public partial class frmdangki : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmdangki()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmdangki_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {

            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
        private void button6_MouseMove_1(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button6_MouseLeave_1(object sender, EventArgs e)
        {

            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
        private void button1_MouseMove_1(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {

            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

       
    }

}
