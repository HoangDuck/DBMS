
namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    partial class shiftInformationUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.dataGridViewCalam = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.ButtonIn = new Guna.UI.WinForms.GunaButton();
            this.ButtonOut = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI.WinForms.GunaButton();
            this.TextBoxout = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxin = new Guna.UI.WinForms.GunaTextBox();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalam)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaShadowPanel1.Controls.Add(this.dataGridViewCalam);
            this.gunaShadowPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(60, 20);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1316, 945);
            this.gunaShadowPanel1.TabIndex = 1;
            // 
            // dataGridViewCalam
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewCalam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCalam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCalam.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCalam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCalam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCalam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCalam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCalam.ColumnHeadersHeight = 4;
            this.dataGridViewCalam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCalam.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCalam.EnableHeadersVisualStyles = false;
            this.dataGridViewCalam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewCalam.Location = new System.Drawing.Point(19, 330);
            this.dataGridViewCalam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCalam.Name = "dataGridViewCalam";
            this.dataGridViewCalam.RowHeadersWidth = 51;
            this.dataGridViewCalam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCalam.Size = new System.Drawing.Size(1273, 577);
            this.dataGridViewCalam.TabIndex = 72;
            this.dataGridViewCalam.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridViewCalam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewCalam.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewCalam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewCalam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewCalam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewCalam.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewCalam.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewCalam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewCalam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCalam.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewCalam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewCalam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCalam.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewCalam.ThemeStyle.ReadOnly = false;
            this.dataGridViewCalam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewCalam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCalam.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewCalam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewCalam.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewCalam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewCalam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.Controls.Add(this.ButtonIn);
            this.gunaGroupBox1.Controls.Add(this.ButtonOut);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.btnConfirm);
            this.gunaGroupBox1.Controls.Add(this.TextBoxout);
            this.gunaGroupBox1.Controls.Add(this.TextBoxin);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Leelawadee UI", 27.75F);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.LineTop = 50;
            this.gunaGroupBox1.Location = new System.Drawing.Point(19, 22);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 10;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1273, 300);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "CHECK IN - CHECK OUT";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(330, 5);
            // 
            // ButtonIn
            // 
            this.ButtonIn.AnimationHoverSpeed = 0.07F;
            this.ButtonIn.AnimationSpeed = 0.03F;
            this.ButtonIn.BackColor = System.Drawing.Color.Transparent;
            this.ButtonIn.BaseColor = System.Drawing.Color.White;
            this.ButtonIn.BorderColor = System.Drawing.Color.Black;
            this.ButtonIn.BorderSize = 3;
            this.ButtonIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonIn.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonIn.Font = new System.Drawing.Font("Leelawadee UI", 27.75F);
            this.ButtonIn.ForeColor = System.Drawing.Color.Black;
            this.ButtonIn.Image = null;
            this.ButtonIn.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonIn.Location = new System.Drawing.Point(153, 74);
            this.ButtonIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonIn.Name = "ButtonIn";
            this.ButtonIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonIn.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonIn.OnHoverImage = null;
            this.ButtonIn.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonIn.Radius = 8;
            this.ButtonIn.Size = new System.Drawing.Size(295, 84);
            this.ButtonIn.TabIndex = 86;
            this.ButtonIn.Text = "CHECK IN";
            this.ButtonIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonIn.Click += new System.EventHandler(this.ButtonIn_Click);
            // 
            // ButtonOut
            // 
            this.ButtonOut.AnimationHoverSpeed = 0.07F;
            this.ButtonOut.AnimationSpeed = 0.03F;
            this.ButtonOut.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOut.BaseColor = System.Drawing.Color.White;
            this.ButtonOut.BorderColor = System.Drawing.Color.Black;
            this.ButtonOut.BorderSize = 3;
            this.ButtonOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonOut.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonOut.Font = new System.Drawing.Font("Leelawadee UI", 27.75F);
            this.ButtonOut.ForeColor = System.Drawing.Color.Black;
            this.ButtonOut.Image = null;
            this.ButtonOut.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonOut.Location = new System.Drawing.Point(153, 165);
            this.ButtonOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonOut.Name = "ButtonOut";
            this.ButtonOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonOut.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonOut.OnHoverImage = null;
            this.ButtonOut.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonOut.Radius = 8;
            this.ButtonOut.Size = new System.Drawing.Size(295, 84);
            this.ButtonOut.TabIndex = 86;
            this.ButtonOut.Text = "CHECK OUT";
            this.ButtonOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonOut.Click += new System.EventHandler(this.ButtonOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(903, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 38);
            this.label1.TabIndex = 72;
            this.label1.Text = "Lịch:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AnimationHoverSpeed = 0.07F;
            this.btnConfirm.AnimationSpeed = 0.03F;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BaseColor = System.Drawing.Color.Navy;
            this.btnConfirm.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirm.Font = new System.Drawing.Font("Leelawadee UI", 27.75F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = null;
            this.btnConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirm.Location = new System.Drawing.Point(816, 74);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirm.OnHoverImage = null;
            this.btnConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirm.Radius = 20;
            this.btnConfirm.Size = new System.Drawing.Size(295, 149);
            this.btnConfirm.TabIndex = 69;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TextBoxout
            // 
            this.TextBoxout.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxout.BaseColor = System.Drawing.Color.White;
            this.TextBoxout.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxout.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxout.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxout.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxout.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBoxout.ForeColor = System.Drawing.Color.Black;
            this.TextBoxout.Location = new System.Drawing.Point(456, 177);
            this.TextBoxout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxout.Name = "TextBoxout";
            this.TextBoxout.PasswordChar = '\0';
            this.TextBoxout.Radius = 10;
            this.TextBoxout.SelectedText = "";
            this.TextBoxout.Size = new System.Drawing.Size(241, 54);
            this.TextBoxout.TabIndex = 67;
            // 
            // TextBoxin
            // 
            this.TextBoxin.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxin.BaseColor = System.Drawing.Color.White;
            this.TextBoxin.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxin.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxin.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBoxin.ForeColor = System.Drawing.Color.Black;
            this.TextBoxin.Location = new System.Drawing.Point(456, 91);
            this.TextBoxin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxin.Name = "TextBoxin";
            this.TextBoxin.PasswordChar = '\0';
            this.TextBoxin.Radius = 10;
            this.TextBoxin.SelectedText = "";
            this.TextBoxin.Size = new System.Drawing.Size(241, 54);
            this.TextBoxin.TabIndex = 65;
            // 
            // shiftInformationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "shiftInformationUC";
            this.Size = new System.Drawing.Size(1436, 985);
            this.Load += new System.EventHandler(this.shiftInformationUC_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalam)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaDataGridView dataGridViewCalam;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton ButtonIn;
        private Guna.UI.WinForms.GunaButton ButtonOut;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnConfirm;
        private Guna.UI.WinForms.GunaTextBox TextBoxout;
        private Guna.UI.WinForms.GunaTextBox TextBoxin;
    }
}
