using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonThemChiTieu_Click(object sender, EventArgs e)
        {
            formNhapChiTieu formNhapChiTieu = new formNhapChiTieu();
            formNhapChiTieu.Activate();
            formNhapChiTieu.ShowDialog();
        }
    }
}
