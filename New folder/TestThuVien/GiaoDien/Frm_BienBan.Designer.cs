namespace TestThuVien.GiaoDien
{
    partial class Frm_BienBan
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
            this.lbl_bienban = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaHV = new System.Windows.Forms.TextBox();
            this.txt_TenHV = new System.Windows.Forms.TextBox();
            this.txt_HinhThucXuLy = new System.Windows.Forms.TextBox();
            this.comb_ViPham = new System.Windows.Forms.ComboBox();
            this.but_Tim = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_bienban);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 100);
            this.panel1.TabIndex = 2;
            // 
            // lbl_bienban
            // 
            this.lbl_bienban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_bienban.AutoSize = true;
            this.lbl_bienban.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_bienban.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_bienban.Location = new System.Drawing.Point(149, 31);
            this.lbl_bienban.Name = "lbl_bienban";
            this.lbl_bienban.Size = new System.Drawing.Size(279, 40);
            this.lbl_bienban.TabIndex = 2;
            this.lbl_bienban.Text = "Biên Bản Vi Phạm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TestThuVien.Properties.Resources.href;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(41, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Hội Viên :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(41, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Hội Viên :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(41, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vi Phạm :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(41, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hình Thức Xử Lý  :";
            // 
            // txt_MaHV
            // 
            this.txt_MaHV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaHV.Location = new System.Drawing.Point(176, 118);
            this.txt_MaHV.Name = "txt_MaHV";
            this.txt_MaHV.ReadOnly = true;
            this.txt_MaHV.Size = new System.Drawing.Size(333, 26);
            this.txt_MaHV.TabIndex = 46;
            // 
            // txt_TenHV
            // 
            this.txt_TenHV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenHV.Location = new System.Drawing.Point(176, 170);
            this.txt_TenHV.Name = "txt_TenHV";
            this.txt_TenHV.ReadOnly = true;
            this.txt_TenHV.Size = new System.Drawing.Size(333, 26);
            this.txt_TenHV.TabIndex = 47;
            // 
            // txt_HinhThucXuLy
            // 
            this.txt_HinhThucXuLy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_HinhThucXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HinhThucXuLy.Location = new System.Drawing.Point(176, 268);
            this.txt_HinhThucXuLy.Multiline = true;
            this.txt_HinhThucXuLy.Name = "txt_HinhThucXuLy";
            this.txt_HinhThucXuLy.Size = new System.Drawing.Size(333, 117);
            this.txt_HinhThucXuLy.TabIndex = 49;
            // 
            // comb_ViPham
            // 
            this.comb_ViPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comb_ViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_ViPham.FormattingEnabled = true;
            this.comb_ViPham.Items.AddRange(new object[] {
            "Trả sách không đúng thời hạn",
            "Làm mất sách",
            "Làm hư hỏng sách"});
            this.comb_ViPham.Location = new System.Drawing.Point(176, 222);
            this.comb_ViPham.Name = "comb_ViPham";
            this.comb_ViPham.Size = new System.Drawing.Size(333, 28);
            this.comb_ViPham.TabIndex = 50;
            this.comb_ViPham.Text = "-----Các hình thức vi phạm-----";
            this.comb_ViPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_ViPham_KeyDown);
            // 
            // but_Tim
            // 
            this.but_Tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_Tim.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Tim.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_Tim.FlatAppearance.BorderSize = 0;
            this.but_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_Tim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Tim.Location = new System.Drawing.Point(213, 414);
            this.but_Tim.Name = "but_Tim";
            this.but_Tim.Size = new System.Drawing.Size(124, 27);
            this.but_Tim.TabIndex = 51;
            this.but_Tim.Text = "In Biên Bản";
            this.but_Tim.UseVisualStyleBackColor = false;
            this.but_Tim.Click += new System.EventHandler(this.but_Tim_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Frm_BienBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(543, 463);
            this.Controls.Add(this.but_Tim);
            this.Controls.Add(this.comb_ViPham);
            this.Controls.Add(this.txt_HinhThucXuLy);
            this.Controls.Add(this.txt_TenHV);
            this.Controls.Add(this.txt_MaHV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_BienBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BienBan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_bienban;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaHV;
        private System.Windows.Forms.TextBox txt_TenHV;
        private System.Windows.Forms.TextBox txt_HinhThucXuLy;
        private System.Windows.Forms.ComboBox comb_ViPham;
        private System.Windows.Forms.Button but_Tim;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}