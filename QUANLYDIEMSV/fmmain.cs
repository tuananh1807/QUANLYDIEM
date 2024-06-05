using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace QUANLYDIEMSV
{

    public partial class fmmain : Form
    {
        public fmmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of fmdangnhap form
            fmdangnhap frmDangNhap = new fmdangnhap();

            // Show the fmdangnhap form
            frmDangNhap.Show();

            // Optionally, hide or close the current fmmain form
            this.Hide();
            // or this.Close(); // if you want to close the main form
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
