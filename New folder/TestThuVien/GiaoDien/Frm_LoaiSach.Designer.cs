namespace TestThuVien.GiaoDien
{
    partial class Frm_LoaiSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenLoaiSach = new System.Windows.Forms.TextBox();
            this.but_Them = new System.Windows.Forms.Button();
            this.but_Thoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 61);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(94, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 36);
            this.label8.TabIndex = 2;
            this.label8.Text = "Thêm Loại Sách";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên Loại Sách :";
            // 
            // txt_TenLoaiSach
            // 
            this.txt_TenLoaiSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenLoaiSach.Location = new System.Drawing.Point(122, 67);
            this.txt_TenLoaiSach.Name = "txt_TenLoaiSach";
            this.txt_TenLoaiSach.Size = new System.Drawing.Size(274, 26);
            this.txt_TenLoaiSach.TabIndex = 34;
            // 
            // but_Them
            // 
            this.but_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_Them.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Them.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_Them.FlatAppearance.BorderSize = 0;
            this.but_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_Them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Them.Location = new System.Drawing.Point(122, 108);
            this.but_Them.Name = "but_Them";
            this.but_Them.Size = new System.Drawing.Size(170, 35);
            this.but_Them.TabIndex = 36;
            this.but_Them.Text = "Thêm";
            this.but_Them.UseVisualStyleBackColor = false;
            this.but_Them.Click += new System.EventHandler(this.but_Them_Click);
            // 
            // but_Thoat
            // 
            this.but_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_Thoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_Thoat.FlatAppearance.BorderSize = 0;
            this.but_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Thoat.Location = new System.Drawing.Point(308, 108);
            this.but_Thoat.Name = "but_Thoat";
            this.but_Thoat.Size = new System.Drawing.Size(88, 35);
            this.but_Thoat.TabIndex = 37;
            this.but_Thoat.Text = "Thoát";
            this.but_Thoat.UseVisualStyleBackColor = false;
            this.but_Thoat.Click += new System.EventHandler(this.but_Thoat_Click);
            // 
            // Frm_LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(408, 170);
            this.Controls.Add(this.but_Thoat);
            this.Controls.Add(this.but_Them);
            this.Controls.Add(this.txt_TenLoaiSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_LoaiSach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenLoaiSach;
        private System.Windows.Forms.Button but_Them;
        private System.Windows.Forms.Button but_Thoat;
    }
}