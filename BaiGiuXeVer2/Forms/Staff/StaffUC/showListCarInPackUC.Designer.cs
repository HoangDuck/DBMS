
namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    partial class showListCarInPackUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.radiobtnNgay = new Guna.UI.WinForms.GunaRadioButton();
            this.radiobtnThang = new Guna.UI.WinForms.GunaRadioButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.TextBox_Search = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxt_GhiChu = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtmNgayTra = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TextBox_BienSo = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.BaseColor = System.Drawing.Color.White;
            this.GroupBox1.BorderColor = System.Drawing.Color.Gray;
            this.GroupBox1.Controls.Add(this.gunaPanel1);
            this.GroupBox1.Controls.Add(this.btnEdit);
            this.GroupBox1.Controls.Add(this.TextBox_Search);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.LineColor = System.Drawing.Color.Gray;
            this.GroupBox1.Location = new System.Drawing.Point(32, 107);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Radius = 10;
            this.GroupBox1.Size = new System.Drawing.Size(429, 295);
            this.GroupBox1.TabIndex = 45;
            this.GroupBox1.Text = "Tìm Kiếm";
            this.GroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.radiobtnNgay);
            this.gunaPanel1.Controls.Add(this.radiobtnThang);
            this.gunaPanel1.Location = new System.Drawing.Point(39, 111);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(353, 66);
            this.gunaPanel1.TabIndex = 111;
            // 
            // radiobtnNgay
            // 
            this.radiobtnNgay.BaseColor = System.Drawing.SystemColors.Control;
            this.radiobtnNgay.CheckedOffColor = System.Drawing.Color.Gray;
            this.radiobtnNgay.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.radiobtnNgay.FillColor = System.Drawing.Color.White;
            this.radiobtnNgay.ForeColor = System.Drawing.Color.Black;
            this.radiobtnNgay.Location = new System.Drawing.Point(38, 18);
            this.radiobtnNgay.Name = "radiobtnNgay";
            this.radiobtnNgay.Size = new System.Drawing.Size(62, 20);
            this.radiobtnNgay.TabIndex = 1;
            this.radiobtnNgay.Text = "Ngày";
            this.radiobtnNgay.CheckedChanged += new System.EventHandler(this.radiobtnNgay_CheckedChanged);
            // 
            // radiobtnThang
            // 
            this.radiobtnThang.BaseColor = System.Drawing.SystemColors.Control;
            this.radiobtnThang.CheckedOffColor = System.Drawing.Color.Gray;
            this.radiobtnThang.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.radiobtnThang.FillColor = System.Drawing.Color.White;
            this.radiobtnThang.ForeColor = System.Drawing.Color.Black;
            this.radiobtnThang.Location = new System.Drawing.Point(209, 18);
            this.radiobtnThang.Name = "radiobtnThang";
            this.radiobtnThang.Size = new System.Drawing.Size(68, 20);
            this.radiobtnThang.TabIndex = 0;
            this.radiobtnThang.Text = "Tháng";
            this.radiobtnThang.CheckedChanged += new System.EventHandler(this.radiobtnThang_CheckedChanged);
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
            this.btnEdit.Location = new System.Drawing.Point(278, 205);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 8;
            this.btnEdit.Size = new System.Drawing.Size(132, 66);
            this.btnEdit.TabIndex = 109;
            this.btnEdit.Text = "Tìm";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Search.BaseColor = System.Drawing.Color.White;
            this.TextBox_Search.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Search.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_Search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_Search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_Search.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_Search.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Search.Location = new System.Drawing.Point(30, 205);
            this.TextBox_Search.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.PasswordChar = '\0';
            this.TextBox_Search.Radius = 10;
            this.TextBox_Search.SelectedText = "";
            this.TextBox_Search.Size = new System.Drawing.Size(240, 66);
            this.TextBox_Search.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(52, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 35);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nhập biển số xe cần tìm:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BaseColor = System.Drawing.Color.White;
            this.groupBox2.BorderColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.gunaButton1);
            this.groupBox2.Controls.Add(this.gunaTextBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gunaTextBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.gunaTextBox1);
            this.groupBox2.Controls.Add(this.TextBoxt_GhiChu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gunaDateTimePicker1);
            this.groupBox2.Controls.Add(this.dtmNgayTra);
            this.groupBox2.Controls.Add(this.TextBox_BienSo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.LineColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(464, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Radius = 10;
            this.groupBox2.Size = new System.Drawing.Size(940, 295);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.Text = "Thông tin xe";
            this.groupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaTextBox3.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox3.Location = new System.Drawing.Point(628, 217);
            this.gunaTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 10;
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(249, 54);
            this.gunaTextBox3.TabIndex = 45;
            this.gunaTextBox3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(488, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 35);
            this.label5.TabIndex = 44;
            this.label5.Text = "Phạt:";
            this.label5.Visible = false;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaTextBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox2.Location = new System.Drawing.Point(628, 164);
            this.gunaTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(249, 54);
            this.gunaTextBox2.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(488, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 35);
            this.label3.TabIndex = 42;
            this.label3.Text = "SĐT: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 35);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ngày Trả:";
            this.label9.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(25, 58);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 35);
            this.label17.TabIndex = 26;
            this.label17.Text = "Biển số:";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox1.Location = new System.Drawing.Point(628, 58);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(249, 54);
            this.gunaTextBox1.TabIndex = 41;
            // 
            // TextBoxt_GhiChu
            // 
            this.TextBoxt_GhiChu.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxt_GhiChu.BaseColor = System.Drawing.Color.White;
            this.TextBoxt_GhiChu.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxt_GhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxt_GhiChu.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxt_GhiChu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxt_GhiChu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxt_GhiChu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBoxt_GhiChu.ForeColor = System.Drawing.Color.Black;
            this.TextBoxt_GhiChu.Location = new System.Drawing.Point(628, 111);
            this.TextBoxt_GhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxt_GhiChu.Name = "TextBoxt_GhiChu";
            this.TextBoxt_GhiChu.PasswordChar = '\0';
            this.TextBoxt_GhiChu.Radius = 10;
            this.TextBoxt_GhiChu.SelectedText = "";
            this.TextBoxt_GhiChu.Size = new System.Drawing.Size(249, 54);
            this.TextBoxt_GhiChu.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày gửi: ";
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(176, 119);
            this.gunaDateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Radius = 10;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(249, 37);
            this.gunaDateTimePicker1.TabIndex = 39;
            this.gunaDateTimePicker1.Text = "22/04/2021";
            this.gunaDateTimePicker1.Value = new System.DateTime(2021, 4, 22, 11, 37, 58, 266);
            // 
            // dtmNgayTra
            // 
            this.dtmNgayTra.BackColor = System.Drawing.Color.Transparent;
            this.dtmNgayTra.BaseColor = System.Drawing.Color.White;
            this.dtmNgayTra.BorderColor = System.Drawing.Color.Silver;
            this.dtmNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayTra.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtmNgayTra.Enabled = false;
            this.dtmNgayTra.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgayTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmNgayTra.ForeColor = System.Drawing.Color.Black;
            this.dtmNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayTra.Location = new System.Drawing.Point(176, 172);
            this.dtmNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtmNgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmNgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmNgayTra.Name = "dtmNgayTra";
            this.dtmNgayTra.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtmNgayTra.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgayTra.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgayTra.OnPressedColor = System.Drawing.Color.Black;
            this.dtmNgayTra.Radius = 10;
            this.dtmNgayTra.Size = new System.Drawing.Size(249, 37);
            this.dtmNgayTra.TabIndex = 39;
            this.dtmNgayTra.Text = "22/04/2021";
            this.dtmNgayTra.Value = new System.DateTime(2021, 4, 22, 11, 37, 58, 266);
            this.dtmNgayTra.Visible = false;
            // 
            // TextBox_BienSo
            // 
            this.TextBox_BienSo.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_BienSo.BaseColor = System.Drawing.Color.White;
            this.TextBox_BienSo.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_BienSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_BienSo.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_BienSo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_BienSo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_BienSo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_BienSo.ForeColor = System.Drawing.Color.Black;
            this.TextBox_BienSo.Location = new System.Drawing.Point(176, 58);
            this.TextBox_BienSo.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_BienSo.Name = "TextBox_BienSo";
            this.TextBox_BienSo.PasswordChar = '\0';
            this.TextBox_BienSo.Radius = 10;
            this.TextBox_BienSo.SelectedText = "";
            this.TextBox_BienSo.Size = new System.Drawing.Size(213, 54);
            this.TextBox_BienSo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(488, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Địa chỉ: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(488, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tên KH: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(284, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(861, 89);
            this.label8.TabIndex = 108;
            this.label8.Text = "DANH SÁCH XE TRONG BÃI";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(32, 410);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1372, 556);
            this.gunaDataGridView1.TabIndex = 109;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.BorderSize = 3;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(31, 225);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 8;
            this.gunaButton1.Size = new System.Drawing.Size(207, 46);
            this.gunaButton1.TabIndex = 112;
            this.gunaButton1.Text = "Xem danh sách";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(281, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 25);
            this.label7.TabIndex = 113;
            this.label7.Text = "Bấm thêm một lần để cập nhật lại";
            // 
            // showListCarInPackUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "showListCarInPackUC";
            this.Size = new System.Drawing.Size(1436, 985);
            this.Load += new System.EventHandler(this.showListCarInPackUC_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox GroupBox1;
        private Guna.UI.WinForms.GunaGroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private Guna.UI.WinForms.GunaTextBox TextBoxt_GhiChu;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDateTimePicker dtmNgayTra;
        private Guna.UI.WinForms.GunaTextBox TextBox_BienSo;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox TextBox_Search;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaRadioButton radiobtnNgay;
        private Guna.UI.WinForms.GunaRadioButton radiobtnThang;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label7;
    }
}
