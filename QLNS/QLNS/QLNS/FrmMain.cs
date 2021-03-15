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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public int k = 1;
        public void truyen()
        {

           
        }
        public static string quyen;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            

        }





        private void menuItem11_Click(object sender, EventArgs e)
        {
           
        }



        private void menuItem19_Click(object sender, EventArgs e)
        {

        }

        private void menuItem20_Click(object sender, EventArgs e)
        {

        }


        private void cmd_exit_MouseMove(object sender, MouseEventArgs e)
        {
            cmd_exit.BackgroundImage = Properties.Resources.butbut;
        }

        private void cmd_exit_MouseLeave(object sender, EventArgs e)
        {
            cmd_exit.BackgroundImage = Properties.Resources._133;
        }
        


        private void cmd_taiKhoan_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void cmd_taiKhoan_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void cmd_dangnhap_Click(object sender, EventArgs e)
        {


         

        }

        private void cmd_dangnhap_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
        }

        private void cmd_dangnhap_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.b1;
        }

        private void cmd_dangky_Click(object sender, EventArgs e)
        {


        }

        

        private void cmd_nhansu_Click(object sender, EventArgs e)
        {
            frmcoban fc = new frmcoban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fc);
            fc.Show();

        }

        private void cmd_thongticanhan_Click(object sender, EventArgs e)
        {
            

        }

        private void cmd_chedo_Click(object sender, EventArgs e)
        {
            
        }

        private void cmd_tienluong_Click(object sender, EventArgs e)
        {
            
        }

        private void cmd_tracuu_Click(object sender, EventArgs e)
        {

        }
        private void cmd_Qlphongban_Click(object sender, EventArgs e)
        {
            

        }

        private void cmd_Qlbophan_Click(object sender, EventArgs e)
        {
            
        }

        private void cmd_QLhoso_Click(object sender, EventArgs e)
        {
            
        }

        private void cmd_qlbangcong_Click(object sender, EventArgs e)
        {
        }


        private void btntracuu_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            
        }

        private void btndmk_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
           

        }

        private void btnchedo_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            
        }

        private void btnluong_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            
        }

        private void bubblenhansu_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            
        }

        private void bubblebophan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
           
        }

        private void bubblephongban_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            
        }

        private void bubbleBcnhanvien_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void cmd_minimax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cmd_maximax_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).Size = new Size(26, 25);
        }

        private void cmd_maximax_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(24, 23);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void panel_show_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            frmdangnhap dn = new frmdangnhap();
            this.Hide();
            dn.ShowDialog();
            dn.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuItemdmk_Click_1(object sender, EventArgs e)
        {
           

        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            

        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
           
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
           
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
           
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            

        }

        private void menuItem19_Click_1(object sender, EventArgs e)
        {
           

        }

        private void menuItem20_Click_1(object sender, EventArgs e)
        {
            
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
           
        }

       


    }
}
