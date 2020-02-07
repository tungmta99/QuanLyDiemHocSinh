namespace FormDangNhap
{
    partial class Form1
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
            this.DangNhap = new System.Windows.Forms.Label();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.tenDangNhap = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.Label();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.quenPassword = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // DangNhap
            // 
            this.DangNhap.AutoSize = true;
            this.DangNhap.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.Location = new System.Drawing.Point(113, 37);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(171, 34);
            this.DangNhap.TabIndex = 0;
            this.DangNhap.Text = "Dang Nhap";
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(119, 101);
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(212, 20);
            this.textBoxTenDangNhap.TabIndex = 1;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.AutoSize = true;
            this.tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenDangNhap.Location = new System.Drawing.Point(12, 101);
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.Size = new System.Drawing.Size(104, 16);
            this.tenDangNhap.TabIndex = 2;
            this.tenDangNhap.Text = "Ten Dang Nhap";
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.Location = new System.Drawing.Point(22, 152);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(72, 16);
            this.PassWord.TabIndex = 3;
            this.PassWord.Text = "PassWord";
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(119, 152);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(212, 20);
            this.textBoxPassWord.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(25, 232);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(306, 29);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Dang Nhap";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // quenPassword
            // 
            this.quenPassword.AutoSize = true;
            this.quenPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quenPassword.Location = new System.Drawing.Point(116, 190);
            this.quenPassword.Name = "quenPassword";
            this.quenPassword.Size = new System.Drawing.Size(113, 16);
            this.quenPassword.TabIndex = 7;
            this.quenPassword.TabStop = true;
            this.quenPassword.Text = "Quen Password ?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(276, 190);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 16);
            this.linkLabel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 297);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.quenPassword);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.tenDangNhap);
            this.Controls.Add(this.textBoxTenDangNhap);
            this.Controls.Add(this.DangNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DangNhap;
        private System.Windows.Forms.TextBox textBoxTenDangNhap;
        private System.Windows.Forms.Label tenDangNhap;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel quenPassword;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

