using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khenthuong
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm frmMain = new MainForm();
            frmMain.Show();
            this.Hide();
            frmMain.DangXuat += FrmMain_DangXuat;
        }

        private void FrmMain_DangXuat(object sender, EventArgs e)
        {
            (sender as MainForm).is_logout = true;
            (sender as MainForm).Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) 
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
