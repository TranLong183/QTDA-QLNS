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
    public partial class frmbangcong : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        public frmbangcong()
        {
            InitializeComponent();
        }
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();
        private void label2_Click(object sender, EventArgs e)
        {
           
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {


        }

        private void frmbangcong_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
          
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

       

        

        

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

       

       

       

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }



        private void cb4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cb1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt7.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txt8.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            txt9.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cb2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txt53.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt50.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            comboBox10.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txt11.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txt12.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            textBox1.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            textBox2.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txt13.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
            txt14.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
            txt15.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
            txt16.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
            txt17.Text = dataGridView2.Rows[i].Cells[13].Value.ToString();
            txt52.Text = dataGridView2.Rows[i].Cells[14].Value.ToString();
            txt18.Text = dataGridView2.Rows[i].Cells[15].Value.ToString();
            
        }

       

      

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt11_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            }
            //catch
            //{
            //    MessageBox.Show("Dữ liệu đầu vào không đúng");
            //}
        //}

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void tl_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void txt50_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {
         

        }
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox10_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox10_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
        
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

       

       
       
             
    
        }


        


          
    }

