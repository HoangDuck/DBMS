
namespace BaiGiuXeVer2.Forms.Manager
{
    partial class showCalenderStaff
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
            this.calendarUC1 = new BaiGiuXeVer2.Forms.Staff.StaffUC.calendarUC();
            this.SuspendLayout();
            // 
            // calendarUC1
            // 
            this.calendarUC1.Location = new System.Drawing.Point(0, 1);
            this.calendarUC1.Name = "calendarUC1";
            this.calendarUC1.Size = new System.Drawing.Size(1077, 800);
            this.calendarUC1.TabIndex = 0;
            // 
            // showCalenderStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 788);
            this.Controls.Add(this.calendarUC1);
            this.Name = "showCalenderStaff";
            this.Text = "Calender Staff";
            this.ResumeLayout(false);

        }

        #endregion

        private Staff.StaffUC.calendarUC calendarUC1;
    }
}