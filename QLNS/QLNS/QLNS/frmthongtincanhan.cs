using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace QLNS
{
    public partial class frmthongtincanhan : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmthongtincanhan()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("amthanh.wav");
            p.Play();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmthongtincanhan_Load(object sender, EventArgs e)
        {
            
            cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
            cls.loadcombobox(comboBox1, "select * from TblTTNVCoBan", 2);
        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          


            

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
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
