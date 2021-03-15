using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;


namespace QLNS
{
    public partial class frmcoban : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        public frmcoban()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
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

        private void frmcoban_Load(object sender, EventArgs e)
        {
            
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
          
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /
              
        }

        
        
            
   
        private void button3_Click(object sender, EventArgs e)
        {
           
            

           }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sql;
            //sql = "Select MaPhong from tblPhongBan where MaBoPhan=N'" + comboBox2.Text + "'";
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
