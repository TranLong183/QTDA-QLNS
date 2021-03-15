using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLNS
{
    public partial class frmdangnhap : Form
    {
        Clsdatabase cls = new Clsdatabase();
        private SqlConnection Con = null;
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-N5JKS23\sqlexpress;Initial Catalog=QLNS;Integrated Security=True";
            Con.Open();
            string select = "Select * From tbuser where Username='" + textBox1.Text + "' and Pass='" + textBox2.Text + "' and Quyen='Admin'";
            SqlCommand cmd = new SqlCommand(select, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Read();
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin) !", "Thông báo !");
                FrmMain.quyen = "Admin";
                this.Hide();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền user) !", "Thông báo !");
                FrmMain.quyen = "user";
                this.Hide();
                this.Close();
            }
            FrmMain frm = new FrmMain();
                //frm.Show();
                frm.ShowDialog();
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
           
            
            }

        }

              
     }
        

