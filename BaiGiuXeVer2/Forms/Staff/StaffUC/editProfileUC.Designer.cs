
namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    partial class editProfileUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.pic_bienso = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.dtmNgaySinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cboGioiTinh = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_DiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.TextBox_TenQuanLy = new Guna.UI.WinForms.GunaTextBox();
            this.TextBox_SDT = new Guna.UI.WinForms.GunaTextBox();
            this.TextBox_HoTen = new Guna.UI.WinForms.GunaTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBox_MaSo = new Guna.UI.WinForms.GunaTextBox();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bienso)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.pic_bienso);
            this.gunaShadowPanel1.Controls.Add(this.dtmNgaySinh);
            this.gunaShadowPanel1.Controls.Add(this.cboGioiTinh);
            this.gunaShadowPanel1.Controls.Add(this.label7);
            this.gunaShadowPanel1.Controls.Add(this.label8);
            this.gunaShadowPanel1.Controls.Add(this.label6);
            this.gunaShadowPanel1.Controls.Add(this.label5);
            this.gunaShadowPanel1.Controls.Add(this.label4);
            this.gunaShadowPanel1.Controls.Add(this.label3);
            this.gunaShadowPanel1.Controls.Add(this.label2);
            this.gunaShadowPanel1.Controls.Add(this.TextBox_DiaChi);
            this.gunaShadowPanel1.Controls.Add(this.TextBox_TenQuanLy);
            this.gunaShadowPanel1.Controls.Add(this.TextBox_SDT);
            this.gunaShadowPanel1.Controls.Add(this.TextBox_HoTen);
            this.gunaShadowPanel1.Controls.Add(this.label17);
            this.gunaShadowPanel1.Controls.Add(this.TextBox_MaSo);
            this.gunaShadowPanel1.Controls.Add(this.btnEdit);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(407, 47);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 8;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(623, 884);
            this.gunaShadowPanel1.TabIndex = 1;
            // 
            // pic_bienso
            // 
            this.pic_bienso.BaseColor = System.Drawing.Color.White;
            this.pic_bienso.Image = global::BaiGiuXeVer2.Properties.Resources.default_DDLK_avatar;
            this.pic_bienso.Location = new System.Drawing.Point(191, 630);
            this.pic_bienso.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.pic_bienso.Name = "pic_bienso";
            this.pic_bienso.Size = new System.Drawing.Size(153, 142);
            this.pic_bienso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_bienso.TabIndex = 92;
            this.pic_bienso.TabStop = false;
            this.pic_bienso.UseTransfarantBackground = false;
            this.pic_bienso.Click += new System.EventHandler(this.pic_bienso_Click);
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.dtmNgaySinh.BaseColor = System.Drawing.Color.White;
            this.dtmNgaySinh.BorderColor = System.Drawing.Color.Silver;
            this.dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtmNgaySinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaySinh.Location = new System.Drawing.Point(191, 329);
            this.dtmNgaySinh.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.dtmNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtmNgaySinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgaySinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgaySinh.OnPressedColor = System.Drawing.Color.Black;
            this.dtmNgaySinh.Radius = 10;
            this.dtmNgaySinh.Size = new System.Drawing.Size(213, 37);
            this.dtmNgaySinh.TabIndex = 91;
            this.dtmNgaySinh.Text = "22/04/2021";
            this.dtmNgaySinh.Value = new System.DateTime(2021, 4, 22, 11, 37, 58, 266);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboGioiTinh.BaseColor = System.Drawing.Color.White;
            this.cboGioiTinh.BorderColor = System.Drawing.Color.Silver;
            this.cboGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(191, 276);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboGioiTinh.Radius = 10;
            this.cboGioiTinh.Size = new System.Drawing.Size(212, 35);
            this.cboGioiTinh.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(28, 443);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 35);
            this.label7.TabIndex = 88;
            this.label7.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(28, 645);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 35);
            this.label8.TabIndex = 88;
            this.label8.Text = "Ảnh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(28, 569);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 35);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tên quản lý:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(28, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 35);
            this.label5.TabIndex = 88;
            this.label5.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(28, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 35);
            this.label4.TabIndex = 88;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(28, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 35);
            this.label3.TabIndex = 88;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(28, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 35);
            this.label2.TabIndex = 88;
            this.label2.Text = "Họ tên:";
            // 
            // TextBox_DiaChi
            // 
            this.TextBox_DiaChi.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_DiaChi.BaseColor = System.Drawing.Color.White;
            this.TextBox_DiaChi.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_DiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_DiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_DiaChi.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.TextBox_DiaChi.Location = new System.Drawing.Point(191, 443);
            this.TextBox_DiaChi.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.TextBox_DiaChi.Multiline = true;
            this.TextBox_DiaChi.Name = "TextBox_DiaChi";
            this.TextBox_DiaChi.PasswordChar = '\0';
            this.TextBox_DiaChi.Radius = 10;
            this.TextBox_DiaChi.SelectedText = "";
            this.TextBox_DiaChi.ShortcutsEnabled = false;
            this.TextBox_DiaChi.Size = new System.Drawing.Size(392, 110);
            this.TextBox_DiaChi.TabIndex = 89;
            // 
            // TextBox_TenQuanLy
            // 
            this.TextBox_TenQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_TenQuanLy.BaseColor = System.Drawing.Color.White;
            this.TextBox_TenQuanLy.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_TenQuanLy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_TenQuanLy.Enabled = false;
            this.TextBox_TenQuanLy.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_TenQuanLy.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_TenQuanLy.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_TenQuanLy.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_TenQuanLy.ForeColor = System.Drawing.Color.Black;
            this.TextBox_TenQuanLy.Location = new System.Drawing.Point(191, 569);
            this.TextBox_TenQuanLy.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.TextBox_TenQuanLy.Name = "TextBox_TenQuanLy";
            this.TextBox_TenQuanLy.PasswordChar = '\0';
            this.TextBox_TenQuanLy.Radius = 10;
            this.TextBox_TenQuanLy.SelectedText = "";
            this.TextBox_TenQuanLy.Size = new System.Drawing.Size(392, 54);
            this.TextBox_TenQuanLy.TabIndex = 89;
            // 
            // TextBox_SDT
            // 
            this.TextBox_SDT.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_SDT.BaseColor = System.Drawing.Color.White;
            this.TextBox_SDT.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_SDT.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_SDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_SDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_SDT.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_SDT.ForeColor = System.Drawing.Color.Black;
            this.TextBox_SDT.Location = new System.Drawing.Point(191, 382);
            this.TextBox_SDT.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.TextBox_SDT.Name = "TextBox_SDT";
            this.TextBox_SDT.PasswordChar = '\0';
            this.TextBox_SDT.Radius = 10;
            this.TextBox_SDT.SelectedText = "";
            this.TextBox_SDT.Size = new System.Drawing.Size(392, 54);
            this.TextBox_SDT.TabIndex = 89;
            // 
            // TextBox_HoTen
            // 
            this.TextBox_HoTen.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_HoTen.BaseColor = System.Drawing.Color.White;
            this.TextBox_HoTen.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_HoTen.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_HoTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_HoTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_HoTen.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_HoTen.ForeColor = System.Drawing.Color.Black;
            this.TextBox_HoTen.Location = new System.Drawing.Point(191, 214);
            this.TextBox_HoTen.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.TextBox_HoTen.Name = "TextBox_HoTen";
            this.TextBox_HoTen.PasswordChar = '\0';
            this.TextBox_HoTen.Radius = 10;
            this.TextBox_HoTen.SelectedText = "";
            this.TextBox_HoTen.Size = new System.Drawing.Size(392, 54);
            this.TextBox_HoTen.TabIndex = 89;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(28, 153);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 35);
            this.label17.TabIndex = 86;
            this.label17.Text = "Mã số:";
            // 
            // TextBox_MaSo
            // 
            this.TextBox_MaSo.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_MaSo.BaseColor = System.Drawing.Color.White;
            this.TextBox_MaSo.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_MaSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_MaSo.Enabled = false;
            this.TextBox_MaSo.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_MaSo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_MaSo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_MaSo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_MaSo.ForeColor = System.Drawing.Color.Black;
            this.TextBox_MaSo.Location = new System.Drawing.Point(191, 153);
            this.TextBox_MaSo.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_MaSo.Name = "TextBox_MaSo";
            this.TextBox_MaSo.PasswordChar = '\0';
            this.TextBox_MaSo.Radius = 10;
            this.TextBox_MaSo.SelectedText = "";
            this.TextBox_MaSo.Size = new System.Drawing.Size(392, 54);
            this.TextBox_MaSo.TabIndex = 87;
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.White;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.BorderSize = 3;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = null;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(192, 789);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 8;
            this.btnEdit.Size = new System.Drawing.Size(268, 69);
            this.btnEdit.TabIndex = 85;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(173, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN";
            // 
            // editProfileUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editProfileUC";
            this.Size = new System.Drawing.Size(1436, 985);
            this.Load += new System.EventHandler(this.editProfileUC_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bienso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker dtmNgaySinh;
        private Guna.UI.WinForms.GunaComboBox cboGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox TextBox_SDT;
        private Guna.UI.WinForms.GunaTextBox TextBox_HoTen;
        private System.Windows.Forms.Label label17;
        private Guna.UI.WinForms.GunaTextBox TextBox_MaSo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox TextBox_DiaChi;
        private Guna.UI.WinForms.GunaTextBox TextBox_TenQuanLy;
        private Guna.UI.WinForms.GunaCirclePictureBox pic_bienso;
        private System.Windows.Forms.Label label8;
    }
}
