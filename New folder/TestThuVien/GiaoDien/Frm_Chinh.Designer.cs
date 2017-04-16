namespace TestThuVien.GiaoDien
{
    partial class Frm_Chinh
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cob_TimKiem = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.but_TiemKiem = new System.Windows.Forms.Button();
            this.TXT_TimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_LienHe = new System.Windows.Forms.Button();
            this.buy_GioiThieu = new System.Windows.Forms.Button();
            this.but_TrangChu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.but_HoiVien = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.but_QLTra = new System.Windows.Forms.Button();
            this.but_QLSach = new System.Windows.Forms.Button();
            this.but_QLMuon = new System.Windows.Forms.Button();
            this.but_QLKho = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imgSach = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.cob_TimKiem);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.but_TiemKiem);
            this.panel1.Controls.Add(this.TXT_TimKiem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 589);
            this.panel1.TabIndex = 1;
            // 
            // cob_TimKiem
            // 
            this.cob_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cob_TimKiem.FormattingEnabled = true;
            this.cob_TimKiem.Items.AddRange(new object[] {
            "Thể Loại",
            "Tên Sách",
            "Tên Tác Giả"});
            this.cob_TimKiem.Location = new System.Drawing.Point(2, 135);
            this.cob_TimKiem.Name = "cob_TimKiem";
            this.cob_TimKiem.Size = new System.Drawing.Size(121, 28);
            this.cob_TimKiem.TabIndex = 4;
            this.cob_TimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cob_TimKiem_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 34);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Tài Liệu";
            // 
            // but_TiemKiem
            // 
            this.but_TiemKiem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_TiemKiem.BackgroundImage = global::TestThuVien.Properties.Resources.metro_search_112611;
            this.but_TiemKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_TiemKiem.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_TiemKiem.FlatAppearance.BorderSize = 0;
            this.but_TiemKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_TiemKiem.Location = new System.Drawing.Point(127, 164);
            this.but_TiemKiem.Name = "but_TiemKiem";
            this.but_TiemKiem.Size = new System.Drawing.Size(40, 40);
            this.but_TiemKiem.TabIndex = 0;
            this.but_TiemKiem.UseVisualStyleBackColor = false;
            this.but_TiemKiem.Click += new System.EventHandler(this.but_TiemKiem_Click);
            // 
            // TXT_TimKiem
            // 
            this.TXT_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TXT_TimKiem.Location = new System.Drawing.Point(3, 171);
            this.TXT_TimKiem.Name = "TXT_TimKiem";
            this.TXT_TimKiem.Size = new System.Drawing.Size(120, 26);
            this.TXT_TimKiem.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TestThuVien.Properties.Resources.liprary;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(1, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 114);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.but_LienHe);
            this.panel3.Controls.Add(this.buy_GioiThieu);
            this.panel3.Controls.Add(this.but_TrangChu);
            this.panel3.Location = new System.Drawing.Point(314, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 38);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(408, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(214, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "|";
            // 
            // but_LienHe
            // 
            this.but_LienHe.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_LienHe.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_LienHe.FlatAppearance.BorderSize = 0;
            this.but_LienHe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_LienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_LienHe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_LienHe.Location = new System.Drawing.Point(492, 3);
            this.but_LienHe.Name = "but_LienHe";
            this.but_LienHe.Size = new System.Drawing.Size(97, 34);
            this.but_LienHe.TabIndex = 4;
            this.but_LienHe.Text = "Liên Hệ";
            this.but_LienHe.UseVisualStyleBackColor = false;
            this.but_LienHe.Click += new System.EventHandler(this.but_LienHe_Click);
            // 
            // buy_GioiThieu
            // 
            this.buy_GioiThieu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buy_GioiThieu.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buy_GioiThieu.FlatAppearance.BorderSize = 0;
            this.buy_GioiThieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy_GioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buy_GioiThieu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buy_GioiThieu.Location = new System.Drawing.Point(274, 3);
            this.buy_GioiThieu.Name = "buy_GioiThieu";
            this.buy_GioiThieu.Size = new System.Drawing.Size(97, 34);
            this.buy_GioiThieu.TabIndex = 3;
            this.buy_GioiThieu.Text = "Giới Thiệu";
            this.buy_GioiThieu.UseVisualStyleBackColor = false;
            this.buy_GioiThieu.Click += new System.EventHandler(this.buy_GioiThieu_Click);
            // 
            // but_TrangChu
            // 
            this.but_TrangChu.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_TrangChu.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_TrangChu.FlatAppearance.BorderSize = 0;
            this.but_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_TrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_TrangChu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_TrangChu.Location = new System.Drawing.Point(74, 2);
            this.but_TrangChu.Name = "but_TrangChu";
            this.but_TrangChu.Size = new System.Drawing.Size(97, 34);
            this.but_TrangChu.TabIndex = 2;
            this.but_TrangChu.Text = "Trang Chủ";
            this.but_TrangChu.UseVisualStyleBackColor = false;
            this.but_TrangChu.Click += new System.EventHandler(this.but_TrangChu_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.but_HoiVien);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.but_QLTra);
            this.panel5.Controls.Add(this.but_QLSach);
            this.panel5.Controls.Add(this.but_QLMuon);
            this.panel5.Controls.Add(this.but_QLKho);
            this.panel5.Location = new System.Drawing.Point(174, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(930, 40);
            this.panel5.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(740, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "|";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(547, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "|";
            // 
            // but_HoiVien
            // 
            this.but_HoiVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_HoiVien.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_HoiVien.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_HoiVien.FlatAppearance.BorderSize = 0;
            this.but_HoiVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_HoiVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_HoiVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_HoiVien.Location = new System.Drawing.Point(25, 3);
            this.but_HoiVien.Name = "but_HoiVien";
            this.but_HoiVien.Size = new System.Drawing.Size(97, 34);
            this.but_HoiVien.TabIndex = 14;
            this.but_HoiVien.Text = "Hội Viên";
            this.but_HoiVien.UseVisualStyleBackColor = false;
            this.but_HoiVien.Click += new System.EventHandler(this.but_HoiVien_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(161, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "|";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(354, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "|";
            // 
            // but_QLTra
            // 
            this.but_QLTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_QLTra.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_QLTra.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_QLTra.FlatAppearance.BorderSize = 0;
            this.but_QLTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_QLTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_QLTra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_QLTra.Location = new System.Drawing.Point(604, 5);
            this.but_QLTra.Name = "but_QLTra";
            this.but_QLTra.Size = new System.Drawing.Size(97, 34);
            this.but_QLTra.TabIndex = 10;
            this.but_QLTra.Text = "QL Trả";
            this.but_QLTra.UseVisualStyleBackColor = false;
            this.but_QLTra.Click += new System.EventHandler(this.but_QLTra_Click);
            // 
            // but_QLSach
            // 
            this.but_QLSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_QLSach.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_QLSach.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_QLSach.FlatAppearance.BorderSize = 0;
            this.but_QLSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_QLSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_QLSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_QLSach.Location = new System.Drawing.Point(218, 5);
            this.but_QLSach.Name = "but_QLSach";
            this.but_QLSach.Size = new System.Drawing.Size(97, 34);
            this.but_QLSach.TabIndex = 7;
            this.but_QLSach.Text = "QL Sách";
            this.but_QLSach.UseVisualStyleBackColor = false;
            this.but_QLSach.Click += new System.EventHandler(this.but_QLSach_Click);
            // 
            // but_QLMuon
            // 
            this.but_QLMuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_QLMuon.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_QLMuon.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_QLMuon.FlatAppearance.BorderSize = 0;
            this.but_QLMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_QLMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_QLMuon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_QLMuon.Location = new System.Drawing.Point(411, 5);
            this.but_QLMuon.Name = "but_QLMuon";
            this.but_QLMuon.Size = new System.Drawing.Size(97, 34);
            this.but_QLMuon.TabIndex = 9;
            this.but_QLMuon.Text = "QL Mượn";
            this.but_QLMuon.UseVisualStyleBackColor = false;
            this.but_QLMuon.Click += new System.EventHandler(this.but_QLMuon_Click);
            // 
            // but_QLKho
            // 
            this.but_QLKho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_QLKho.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_QLKho.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_QLKho.FlatAppearance.BorderSize = 0;
            this.but_QLKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_QLKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_QLKho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_QLKho.Location = new System.Drawing.Point(797, 5);
            this.but_QLKho.Name = "but_QLKho";
            this.but_QLKho.Size = new System.Drawing.Size(97, 34);
            this.but_QLKho.TabIndex = 8;
            this.but_QLKho.Text = "QL Kho";
            this.but_QLKho.UseVisualStyleBackColor = false;
            this.but_QLKho.Click += new System.EventHandler(this.but_QLKho_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.LargeImageList = this.imgSach;
            this.listView1.Location = new System.Drawing.Point(176, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(928, 490);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imgSach
            // 
            this.imgSach.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgSach.ImageSize = new System.Drawing.Size(150, 200);
            this.imgSach.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::TestThuVien.Properties.Resources._012_power512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1060, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Frm_Chinh
            // 
            this.AcceptButton = this.but_TiemKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1110, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Chinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Chinh";
            this.Load += new System.EventHandler(this.Frm_Chinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_TiemKiem;
        private System.Windows.Forms.TextBox TXT_TimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_LienHe;
        private System.Windows.Forms.Button buy_GioiThieu;
        private System.Windows.Forms.Button but_TrangChu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button but_HoiVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_QLTra;
        private System.Windows.Forms.Button but_QLSach;
        private System.Windows.Forms.Button but_QLMuon;
        private System.Windows.Forms.Button but_QLKho;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cob_TimKiem;
        private System.Windows.Forms.ImageList imgSach;
    }
}