
namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    partial class changePasswordUC
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
            this.btnChange = new Guna.UI.WinForms.GunaButton();
            this.cbShowPassword = new Guna.UI.WinForms.GunaCheckBox();
            this.textConfirmNewPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.textCurrentPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.textNewPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnChange);
            this.gunaShadowPanel1.Controls.Add(this.cbShowPassword);
            this.gunaShadowPanel1.Controls.Add(this.textConfirmNewPassword);
            this.gunaShadowPanel1.Controls.Add(this.textCurrentPassword);
            this.gunaShadowPanel1.Controls.Add(this.textNewPassword);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(407, 47);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 8;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(623, 884);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.AnimationHoverSpeed = 0.07F;
            this.btnChange.AnimationSpeed = 0.03F;
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.BaseColor = System.Drawing.Color.White;
            this.btnChange.BorderColor = System.Drawing.Color.Black;
            this.btnChange.BorderSize = 3;
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChange.FocusedColor = System.Drawing.Color.Empty;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.Color.Black;
            this.btnChange.Image = null;
            this.btnChange.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChange.Location = new System.Drawing.Point(203, 554);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChange.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChange.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChange.OnHoverImage = null;
            this.btnChange.OnPressedColor = System.Drawing.Color.Black;
            this.btnChange.Radius = 8;
            this.btnChange.Size = new System.Drawing.Size(221, 57);
            this.btnChange.TabIndex = 85;
            this.btnChange.Text = "Đổi";
            this.btnChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.BaseColor = System.Drawing.Color.White;
            this.cbShowPassword.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbShowPassword.FillColor = System.Drawing.Color.White;
            this.cbShowPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.Location = new System.Drawing.Point(28, 470);
            this.cbShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(181, 27);
            this.cbShowPassword.TabIndex = 84;
            this.cbShowPassword.Text = "Hiển thị mật khẩu";
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // textConfirmNewPassword
            // 
            this.textConfirmNewPassword.BackColor = System.Drawing.Color.White;
            this.textConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textConfirmNewPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textConfirmNewPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmNewPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.textConfirmNewPassword.Location = new System.Drawing.Point(28, 380);
            this.textConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textConfirmNewPassword.Name = "textConfirmNewPassword";
            this.textConfirmNewPassword.PasswordChar = '\0';
            this.textConfirmNewPassword.SelectedText = "";
            this.textConfirmNewPassword.Size = new System.Drawing.Size(567, 54);
            this.textConfirmNewPassword.TabIndex = 83;
            this.textConfirmNewPassword.Text = "Confirm New Password";
            this.textConfirmNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textConfirmNewPassword.Enter += new System.EventHandler(this.textConfirmNewPassword_Enter);
            this.textConfirmNewPassword.Leave += new System.EventHandler(this.textConfirmNewPassword_Leave);
            // 
            // textCurrentPassword
            // 
            this.textCurrentPassword.BackColor = System.Drawing.Color.White;
            this.textCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCurrentPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textCurrentPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCurrentPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.textCurrentPassword.Location = new System.Drawing.Point(28, 240);
            this.textCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCurrentPassword.Name = "textCurrentPassword";
            this.textCurrentPassword.PasswordChar = '\0';
            this.textCurrentPassword.SelectedText = "";
            this.textCurrentPassword.Size = new System.Drawing.Size(567, 54);
            this.textCurrentPassword.TabIndex = 82;
            this.textCurrentPassword.Text = "Current Password";
            this.textCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCurrentPassword.Enter += new System.EventHandler(this.textCurrentPassword_Enter);
            this.textCurrentPassword.Leave += new System.EventHandler(this.textCurrentPassword_Leave);
            // 
            // textNewPassword
            // 
            this.textNewPassword.BackColor = System.Drawing.Color.White;
            this.textNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNewPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textNewPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.textNewPassword.Location = new System.Drawing.Point(28, 306);
            this.textNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNewPassword.Name = "textNewPassword";
            this.textNewPassword.PasswordChar = '\0';
            this.textNewPassword.SelectedText = "";
            this.textNewPassword.Size = new System.Drawing.Size(567, 54);
            this.textNewPassword.TabIndex = 82;
            this.textNewPassword.Text = "New Password";
            this.textNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNewPassword.Enter += new System.EventHandler(this.textNewPassword_Enter);
            this.textNewPassword.Leave += new System.EventHandler(this.textNewPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(123, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // changePasswordUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "changePasswordUC";
            this.Size = new System.Drawing.Size(1436, 985);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCheckBox cbShowPassword;
        private Guna.UI.WinForms.GunaLineTextBox textConfirmNewPassword;
        private Guna.UI.WinForms.GunaLineTextBox textCurrentPassword;
        private Guna.UI.WinForms.GunaLineTextBox textNewPassword;
        private Guna.UI.WinForms.GunaButton btnChange;
    }
}
