namespace QUANLYDIEMSV
{
    partial class fmmain
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(154, 65);
            button1.Name = "button1";
            button1.Size = new Size(167, 80);
            button1.TabIndex = 0;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(444, 65);
            button2.Name = "button2";
            button2.Size = new Size(167, 80);
            button2.TabIndex = 1;
            button2.Text = "THOÁT";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 9);
            label1.Name = "label1";
            label1.Size = new Size(665, 32);
            label1.TabIndex = 2;
            label1.Text = "TRANG NÀY ĐỂ DẪN BẠN ĐỂN VIỆC QUẢN LÝ SINH VIÊN";
            // 
            // fmmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 177);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "fmmain";
            Text = "fmmain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}