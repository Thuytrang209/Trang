using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Trang.Class;

namespace Trang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DatabaseConnect connect = new DatabaseConnect();
            MessageBox.Show(connect.statusConnect + "_____" + connect.Error);
            

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (txtServer.Text == @"DANGTRANG\SQLEXPRESS" & txtUser.Text == "Thuy Trang" & txtPass.Text == "123")
        //    {
        //        //MessageBox.Show(connect.statusConnect + "_____" + connect.Error);
        //        MessageBox.Show("thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("lỗi");
        //    }
        //}

    }
}
