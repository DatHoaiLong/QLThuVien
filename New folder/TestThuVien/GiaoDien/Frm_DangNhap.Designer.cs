namespace TestThuVien.GiaoDien
{
    partial class Frm_DangNhap
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
            this.txt_TaiKhoanDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MatKhauDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.but_Dangnhap = new System.Windows.Forms.Button();
            this.but_Thoat = new System.Windows.Forms.Button();
            this.but_Dangky = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TaiKhoanDN
            // 
            this.txt_TaiKhoanDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TaiKhoanDN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_TaiKhoanDN.Location = new System.Drawing.Point(161, 161);
            this.txt_TaiKhoanDN.Name = "txt_TaiKhoanDN";
            this.txt_TaiKhoanDN.Size = new System.Drawing.Size(207, 26);
            this.txt_TaiKhoanDN.TabIndex = 0;
            this.txt_TaiKhoanDN.Text = "Tài Khoản";
            this.txt_TaiKhoanDN.Click += new System.EventHandler(this.txt_Username_Click);
            this.txt_TaiKhoanDN.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(192, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEMBER  LOGIN";
            // 
            // txt_MatKhauDN
            // 
            this.txt_MatKhauDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MatKhauDN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_MatKhauDN.Location = new System.Drawing.Point(161, 228);
            this.txt_MatKhauDN.Name = "txt_MatKhauDN";
            this.txt_MatKhauDN.PasswordChar = '*';
            this.txt_MatKhauDN.Size = new System.Drawing.Size(207, 26);
            this.txt_MatKhauDN.TabIndex = 1;
            this.txt_MatKhauDN.Text = "Mật Khẩu";
            this.txt_MatKhauDN.Click += new System.EventHandler(this.txt_Password_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(135, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(134, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(136, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "---";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(161, 279);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 22);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Nhớ Mật Khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // but_Dangnhap
            // 
            this.but_Dangnhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Dangnhap.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.but_Dangnhap.FlatAppearance.BorderSize = 0;
            this.but_Dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Dangnhap.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_Dangnhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Dangnhap.Location = new System.Drawing.Point(75, 366);
            this.but_Dangnhap.Name = "but_Dangnhap";
            this.but_Dangnhap.Size = new System.Drawing.Size(102, 33);
            this.but_Dangnhap.TabIndex = 11;
            this.but_Dangnhap.Text = "Đăng Nhập";
            this.but_Dangnhap.UseVisualStyleBackColor = false;
            this.but_Dangnhap.Click += new System.EventHandler(this.but_Dangnhap_Click);
            // 
            // but_Thoat
            // 
            this.but_Thoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_Thoat.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.but_Thoat.FlatAppearance.BorderSize = 0;
            this.but_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Thoat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Thoat.Location = new System.Drawing.Point(331, 366);
            this.but_Thoat.Name = "but_Thoat";
            this.but_Thoat.Size = new System.Drawing.Size(70, 33);
            this.but_Thoat.TabIndex = 12;
            this.but_Thoat.Text = "Thoát";
            this.but_Thoat.UseVisualStyleBackColor = false;
            this.but_Thoat.Click += new System.EventHandler(this.but_Thoat_Click);
            // 
            // but_Dangky
            // 
            this.but_Dangky.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Dangky.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.but_Dangky.FlatAppearance.BorderSize = 0;
            this.but_Dangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Dangky.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_Dangky.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Dangky.Location = new System.Drawing.Point(216, 366);
            this.but_Dangky.Name = "but_Dangky";
            this.but_Dangky.Size = new System.Drawing.Size(79, 33);
            this.but_Dangky.TabIndex = 13;
            this.but_Dangky.Text = "Đăng Ký";
            this.but_Dangky.UseVisualStyleBackColor = false;
            this.but_Dangky.Click += new System.EventHandler(this.but_Dangky_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TestThuVien.Properties.Resources.person_icon;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(88, 151);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TestThuVien.Properties.Resources.unlock_icon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(88, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TestThuVien.Properties.Resources.Login_Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(207, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_DangNhap
            // 
            this.AcceptButton = this.but_Dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.but_Thoat;
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(this.but_Dangky);
            this.Controls.Add(this.but_Thoat);
            this.Controls.Add(this.but_Dangnhap);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MatKhauDN);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TaiKhoanDN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DangNhap";
            this.Load += new System.EventHandler(this.Frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_TaiKhoanDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_MatKhauDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button but_Dangnhap;
        private System.Windows.Forms.Button but_Thoat;
        private System.Windows.Forms.Button but_Dangky;
    }
}