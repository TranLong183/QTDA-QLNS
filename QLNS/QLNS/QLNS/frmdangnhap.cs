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


        }
    }