namespace QUANLYDIEMSV
{
    partial class fmdangnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txttdn = new TextBox();
            txtmk = new TextBox();
            btnlogin = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(146, 39);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(134, 71);
            label2.Name = "label2";
            label2.Size = new Size(187, 15);
            label2.TabIndex = 1;
            label2.Text = "Phần mềm quản lý điểm sinh viên";
            label2.Click += label2_Click;
            // 
            // txttdn
            // 
            txttdn.AutoCompleteMode = AutoCompleteMode.Suggest;
            txttdn.Location = new Point(173, 98);
            txttdn.Name = "txttdn";
            txttdn.Size = new Size(286, 23);
            txttdn.TabIndex = 2;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(173, 141);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(286, 23);
            txtmk.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.Red;
            btnlogin.Image = Properties.Resources.QUẢN_LÝ_ĐIỂM_SINH_VIÊN__1_;
            btnlogin.Location = new Point(146, 195);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(152, 45);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Đăng nhập";
            btnlogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sv1;
            pictureBox1.Location = new Point(12, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.chia;
            pictureBox2.Location = new Point(12, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 100);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 7;
            label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 141);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 8;
            label4.Text = "Mật khẩu";
            // 
            // fmdangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.QUẢN_LÝ_ĐIỂM_SINH_VIÊN__1_;
            ClientSize = new Size(485, 252);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnlogin);
            Controls.Add(txtmk);
            Controls.Add(txttdn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fmdangnhap";
            Text = "ĐĂNG NHẬP ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txttdn;
        private TextBox txtmk;
        private Button btnlogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
    }
}