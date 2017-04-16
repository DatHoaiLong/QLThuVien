namespace TestThuVien.GiaoDien
{
    partial class Frm_QLMuon
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.but_Sua = new System.Windows.Forms.Button();
            this.but_Xoa = new System.Windows.Forms.Button();
            this.butluu = new System.Windows.Forms.Button();
            this.txt_NgayMuon = new System.Windows.Forms.TextBox();
            this.txt_NgayHenTra = new System.Windows.Forms.TextBox();
            this.dataGridView_QLMuonSach = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHoiVien = new System.Windows.Forms.TextBox();
            this.txt_TenHoiVien = new System.Windows.Forms.TextBox();
            this.but_kiemtratinhtrang = new System.Windows.Forms.Button();
            this.but_Them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 100);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(271, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 40);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quản Lý Mượn Sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TestThuVien.Properties.Resources.book_icon_flat_style_long_shadow_open_50658949;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(33, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Sách :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(406, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số Lượng Mượn :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(406, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Mượn :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(406, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày Hẹn Trả :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(33, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã Sách :";
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSach.Location = new System.Drawing.Point(114, 124);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(235, 26);
            this.txt_MaSach.TabIndex = 16;
            this.txt_MaSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaSach_KeyDown);
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenSach.Location = new System.Drawing.Point(112, 163);
            this.txt_TenSach.Multiline = true;
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(235, 52);
            this.txt_TenSach.TabIndex = 17;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoLuong.Location = new System.Drawing.Point(539, 218);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(200, 26);
            this.txt_SoLuong.TabIndex = 18;
            // 
            // but_Sua
            // 
            this.but_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_Sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Sua.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_Sua.FlatAppearance.BorderSize = 0;
            this.but_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Sua.Location = new System.Drawing.Point(186, 286);
            this.but_Sua.Name = "but_Sua";
            this.but_Sua.Size = new System.Drawing.Size(79, 35);
            this.but_Sua.TabIndex = 28;
            this.but_Sua.Text = "Sửa";
            this.but_Sua.UseVisualStyleBackColor = false;
            this.but_Sua.Click += new System.EventHandler(this.but_Sua_Click);
            // 
            // but_Xoa
            // 
            this.but_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_Xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_Xoa.FlatAppearance.BorderSize = 0;
            this.but_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Xoa.Location = new System.Drawing.Point(275, 286);
            this.but_Xoa.Name = "but_Xoa";
            this.but_Xoa.Size = new System.Drawing.Size(74, 35);
            this.but_Xoa.TabIndex = 27;
            this.but_Xoa.Text = "Xóa";
            this.but_Xoa.UseVisualStyleBackColor = false;
            this.but_Xoa.Click += new System.EventHandler(this.but_Xoa_Click);
            // 
            // butluu
            // 
            this.butluu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butluu.BackColor = System.Drawing.Color.DodgerBlue;
            this.butluu.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butluu.FlatAppearance.BorderSize = 0;
            this.butluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butluu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butluu.Location = new System.Drawing.Point(103, 286);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(73, 35);
            this.butluu.TabIndex = 26;
            this.butluu.Text = "Lưu";
            this.butluu.UseVisualStyleBackColor = false;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // txt_NgayMuon
            // 
            this.txt_NgayMuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_NgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NgayMuon.Location = new System.Drawing.Point(539, 266);
            this.txt_NgayMuon.Name = "txt_NgayMuon";
            this.txt_NgayMuon.Size = new System.Drawing.Size(200, 26);
            this.txt_NgayMuon.TabIndex = 29;
            // 
            // txt_NgayHenTra
            // 
            this.txt_NgayHenTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_NgayHenTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NgayHenTra.Location = new System.Drawing.Point(539, 314);
            this.txt_NgayHenTra.Name = "txt_NgayHenTra";
            this.txt_NgayHenTra.Size = new System.Drawing.Size(200, 26);
            this.txt_NgayHenTra.TabIndex = 30;
            // 
            // dataGridView_QLMuonSach
            // 
            this.dataGridView_QLMuonSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_QLMuonSach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_QLMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QLMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView_QLMuonSach.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_QLMuonSach.Location = new System.Drawing.Point(0, 347);
            this.dataGridView_QLMuonSach.Name = "dataGridView_QLMuonSach";
            this.dataGridView_QLMuonSach.ReadOnly = true;
            this.dataGridView_QLMuonSach.RowHeadersVisible = false;
            this.dataGridView_QLMuonSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_QLMuonSach.Size = new System.Drawing.Size(787, 218);
            this.dataGridView_QLMuonSach.TabIndex = 44;
            this.dataGridView_QLMuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_QLMuonSach_CellClick);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MaHoiVien";
            this.Column3.HeaderText = "Mã Hội Viên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "TenHoiVien";
            this.Column1.HeaderText = "Tên Hội Viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "MaSach";
            this.Column7.HeaderText = "Mã Sách";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SoLuongMuon";
            this.Column4.HeaderText = "Số Lượng Mượn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "NgayMuon";
            this.Column5.HeaderText = "Ngày Mượn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "NgayHenTra";
            this.Column6.HeaderText = "Ngày Hẹn Trả";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(406, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã Hội Viên :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(406, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên Hội Viên :";
            // 
            // txt_MaHoiVien
            // 
            this.txt_MaHoiVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaHoiVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaHoiVien.Location = new System.Drawing.Point(539, 122);
            this.txt_MaHoiVien.Name = "txt_MaHoiVien";
            this.txt_MaHoiVien.Size = new System.Drawing.Size(200, 26);
            this.txt_MaHoiVien.TabIndex = 48;
            this.txt_MaHoiVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaHoiVien_KeyDown);
            // 
            // txt_TenHoiVien
            // 
            this.txt_TenHoiVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenHoiVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenHoiVien.Location = new System.Drawing.Point(539, 170);
            this.txt_TenHoiVien.Name = "txt_TenHoiVien";
            this.txt_TenHoiVien.Size = new System.Drawing.Size(200, 26);
            this.txt_TenHoiVien.TabIndex = 49;
            // 
            // but_kiemtratinhtrang
            // 
            this.but_kiemtratinhtrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_kiemtratinhtrang.BackColor = System.Drawing.Color.DodgerBlue;
            this.but_kiemtratinhtrang.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.but_kiemtratinhtrang.FlatAppearance.BorderSize = 0;
            this.but_kiemtratinhtrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_kiemtratinhtrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_kiemtratinhtrang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_kiemtratinhtrang.Location = new System.Drawing.Point(114, 227);
            this.but_kiemtratinhtrang.Name = "but_kiemtratinhtrang";
            this.but_kiemtratinhtrang.Size = new System.Drawing.Size(235, 35);
            this.but_kiemtratinhtrang.TabIndex = 50;
            this.but_kiemtratinhtrang.Text = "Kiểm Tra Tình Trạng";
            this.but_kiemtratinhtrang.UseVisualStyleBackColor = false;
            this.but_kiemtratinhtrang.Click += new System.EventHandler(this.but_kiemtratinhtrang_Click);
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
            this.but_Them.Location = new System.Drawing.Point(16, 286);
            this.but_Them.Name = "but_Them";
            this.but_Them.Size = new System.Drawing.Size(73, 35);
            this.but_Them.TabIndex = 51;
            this.but_Them.Text = "Thêm";
            this.but_Them.UseVisualStyleBackColor = false;
            this.but_Them.Click += new System.EventHandler(this.but_Them_Click);
            // 
            // Frm_QLMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(786, 567);
            this.Controls.Add(this.but_Them);
            this.Controls.Add(this.but_kiemtratinhtrang);
            this.Controls.Add(this.txt_TenHoiVien);
            this.Controls.Add(this.txt_TenSach);
            this.Controls.Add(this.txt_MaHoiVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_QLMuonSach);
            this.Controls.Add(this.txt_NgayHenTra);
            this.Controls.Add(this.txt_NgayMuon);
            this.Controls.Add(this.but_Sua);
            this.Controls.Add(this.but_Xoa);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_MaSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_QLMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_QLMuon";
            this.Load += new System.EventHandler(this.Frm_QLMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Button but_Sua;
        private System.Windows.Forms.Button but_Xoa;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.TextBox txt_NgayMuon;
        private System.Windows.Forms.TextBox txt_NgayHenTra;
        private System.Windows.Forms.DataGridView dataGridView_QLMuonSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaHoiVien;
        private System.Windows.Forms.TextBox txt_TenHoiVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button but_kiemtratinhtrang;
        private System.Windows.Forms.Button but_Them;
    }
}