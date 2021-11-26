
namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    partial class calendarUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.ComboBoxLich = new Guna.UI.WinForms.GunaComboBox();
            this.label1TongNgayLam = new System.Windows.Forms.Label();
            this.DGV_LichLamViec = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaShadowPanel1.Controls.Add(this.ComboBoxLich);
            this.gunaShadowPanel1.Controls.Add(this.label1TongNgayLam);
            this.gunaShadowPanel1.Controls.Add(this.DGV_LichLamViec);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(60, 20);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1316, 945);
            this.gunaShadowPanel1.TabIndex = 2;
            // 
            // ComboBoxLich
            // 
            this.ComboBoxLich.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxLich.BaseColor = System.Drawing.Color.White;
            this.ComboBoxLich.BorderColor = System.Drawing.Color.Silver;
            this.ComboBoxLich.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxLich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLich.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxLich.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.ComboBoxLich.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxLich.FormattingEnabled = true;
            this.ComboBoxLich.Location = new System.Drawing.Point(20, 98);
            this.ComboBoxLich.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxLich.Name = "ComboBoxLich";
            this.ComboBoxLich.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBoxLich.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBoxLich.Size = new System.Drawing.Size(189, 35);
            this.ComboBoxLich.TabIndex = 110;
            // 
            // label1TongNgayLam
            // 
            this.label1TongNgayLam.AutoSize = true;
            this.label1TongNgayLam.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1TongNgayLam.ForeColor = System.Drawing.Color.Gray;
            this.label1TongNgayLam.Location = new System.Drawing.Point(761, 108);
            this.label1TongNgayLam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1TongNgayLam.Name = "label1TongNgayLam";
            this.label1TongNgayLam.Size = new System.Drawing.Size(362, 28);
            this.label1TongNgayLam.TabIndex = 109;
            this.label1TongNgayLam.Text = "Tổng số ngày làm (đến lúc làm mới lịch):";
            // 
            // DGV_LichLamViec
            // 
            this.DGV_LichLamViec.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_LichLamViec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_LichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_LichLamViec.BackgroundColor = System.Drawing.Color.White;
            this.DGV_LichLamViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_LichLamViec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_LichLamViec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_LichLamViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_LichLamViec.ColumnHeadersHeight = 30;
            this.DGV_LichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_LichLamViec.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_LichLamViec.EnableHeadersVisualStyles = false;
            this.DGV_LichLamViec.GridColor = System.Drawing.Color.Gainsboro;
            this.DGV_LichLamViec.Location = new System.Drawing.Point(20, 143);
            this.DGV_LichLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_LichLamViec.Name = "DGV_LichLamViec";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_LichLamViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_LichLamViec.RowHeadersVisible = false;
            this.DGV_LichLamViec.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_LichLamViec.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_LichLamViec.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_LichLamViec.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DGV_LichLamViec.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV_LichLamViec.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_LichLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_LichLamViec.Size = new System.Drawing.Size(1275, 754);
            this.DGV_LichLamViec.TabIndex = 108;
            this.DGV_LichLamViec.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGV_LichLamViec.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_LichLamViec.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_LichLamViec.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV_LichLamViec.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV_LichLamViec.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_LichLamViec.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV_LichLamViec.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.DGV_LichLamViec.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGV_LichLamViec.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_LichLamViec.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DGV_LichLamViec.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_LichLamViec.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV_LichLamViec.ThemeStyle.HeaderStyle.Height = 30;
            this.DGV_LichLamViec.ThemeStyle.ReadOnly = false;
            this.DGV_LichLamViec.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_LichLamViec.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_LichLamViec.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DGV_LichLamViec.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV_LichLamViec.ThemeStyle.RowsStyle.Height = 22;
            this.DGV_LichLamViec.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_LichLamViec.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Ngày";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sáng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trưa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tối";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(487, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỊCH LÀM VIỆC";
            // 
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // calendarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "calendarUC";
            this.Size = new System.Drawing.Size(1436, 985);
            this.Load += new System.EventHandler(this.calendarUC_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LichLamViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        private Guna.UI.WinForms.GunaComboBox ComboBoxLich;
        private System.Windows.Forms.Label label1TongNgayLam;
        private Guna.UI.WinForms.GunaDataGridView DGV_LichLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
    }
}
