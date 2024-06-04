﻿using Microsoft.IdentityModel.Tokens;
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
            // Kiểm tra xem form "fmdangnhap" đã mở chưa
            if (Utility.IsOpeningForm("fmdangnhap"))
            {
                // Nếu đã mở, không làm gì cả
                return;
            }

            // Nếu form "fmdangnhap" chưa mở, tạo một instance mới của nó và hiển thị
            fmdangnhap f = new fmdangnhap();
            // Đặt form cha là form chính
            f.Show();
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