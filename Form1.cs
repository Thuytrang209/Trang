using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trang.Class_Student;

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
            Student sv_A = new Student();
            sv_A.Name = " Trang";
            sv_A.Password = "12345";
            MessageBox.Show(sv_A.Name + "\r\n" + "Password: " + sv_A.Password);
        }
    }
}
