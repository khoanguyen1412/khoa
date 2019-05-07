using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy    HH:mm:ss");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmThemsach frmthemsach = new frmThemsach();
            frmthemsach.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSuasach frmsuasach = new frmSuasach();
            frmsuasach.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNhapsach frmnhapsach = new frmNhapsach();
            frmnhapsach.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmThemhoadon frmthemhoadon = new frmThemhoadon();
            frmthemhoadon.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmThutien frmthutien = new frmThutien();
            frmthutien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmThemkhachhang frmthemkhachhang = new frmThemkhachhang();
            frmthemkhachhang.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSuakhachhang frmsuakhachhang = new frmSuakhachhang();
            frmsuakhachhang.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else return;
        }
    }
}
