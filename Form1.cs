using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trang.Class;

namespace Trang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Student sv_D = new Student("thảo heo", 1117, "gfuuf");
            //txtHoten.Text = sv_D.Name;
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test sv_A = new test("Trang", 1117351, "fsdf");
            txtHoten.Text = sv_A.Name;
            txtMSSV.Text = Convert.ToString(sv_A.Id);
            txtMK.Text = sv_A.pass;
            
        }
        private ConnectSQL con;

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectSQL conn = new ConnectSQL();
            
            string lenh = "select * from tblQuan";
            dataGridView1.DataSource = conn.bang(lenh);
        }

        

       
    }
}
