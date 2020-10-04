using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLNV
{
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }

        
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            them them1 = new them();
            them1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timkiem tk1 = new timkiem();
            tk1.ShowDialog();
        }
    }
}
