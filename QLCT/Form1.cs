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

        private void buttonBaoCao_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Activate();
            form2.ShowDialog();
        }

        private void buttonThemThuNhap_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Activate();
            form3.ShowDialog();
        }
    }
}
