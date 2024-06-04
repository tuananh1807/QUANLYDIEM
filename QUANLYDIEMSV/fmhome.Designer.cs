namespace QUANLYDIEMSV
{
    partial class Homecs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.IMG_9502_1_;
            pictureBox1.Image = Properties.Resources.QUẢN_LÝ_ĐIỂM_SINH_VIÊN;
            pictureBox1.InitialImage = Properties.Resources.IMG_9502_1_;
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(833, 319);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.sv;
            pictureBox2.Image = Properties.Resources.sv1;
            pictureBox2.InitialImage = Properties.Resources.sv;
            pictureBox2.Location = new Point(12, 366);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 469);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 6;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // pictureBox7
            // 
            pictureBox7.ErrorImage = Properties.Resources.sv;
            pictureBox7.Image = Properties.Resources._5;
            pictureBox7.InitialImage = Properties.Resources.sv;
            pictureBox7.Location = new Point(193, 366);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(114, 91);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 469);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 8;
            label2.Text = "QUẢN LÝ LỚP HỌC PHẦN";
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = Properties.Resources.sv;
            pictureBox3.Image = Properties.Resources._4;
            pictureBox3.InitialImage = Properties.Resources.sv;
            pictureBox3.Location = new Point(371, 366);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = Properties.Resources.sv;
            pictureBox4.Image = Properties.Resources._3;
            pictureBox4.InitialImage = Properties.Resources.sv;
            pictureBox4.Location = new Point(556, 366);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 91);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.ErrorImage = Properties.Resources.sv;
            pictureBox5.Image = Properties.Resources.sv1;
            pictureBox5.InitialImage = Properties.Resources.sv;
            pictureBox5.Location = new Point(731, 366);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(114, 91);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 469);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 12;
            label3.Text = "QUẢN LÝ BẢNG ĐIỂM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 469);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 13;
            label4.Text = "QUẢN LÝ LỚP";
            // 
            // Homecs
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(857, 493);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox7);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Homecs";
            Text = "Trang chủ QLDSV";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox7;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label3;
        private Label label4;
    }
}
