using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV;


namespace QLNV
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nhanvien nv1 = new nhanvien();
            nv1.Show();
        }
        //
        

        private void lb_level_Click(object sender, EventArgs e)
        {

        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin ad1 = new admin();
            ad1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F1 f1 = new F1();
            f1.Show();
        }
    }
}
