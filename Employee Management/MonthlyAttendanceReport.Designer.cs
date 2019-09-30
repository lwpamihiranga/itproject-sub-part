namespace Employee_Management
{
    partial class MonthlyAttendanceReport
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
            this.dataGridViewMonth = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMonth
            // 
            this.dataGridViewMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonth.Location = new System.Drawing.Point(43, 34);
            this.dataGridViewMonth.Name = "dataGridViewMonth";
            this.dataGridViewMonth.Size = new System.Drawing.Size(706, 292);
            this.dataGridViewMonth.TabIndex = 0;
            // 
            // MonthlyAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMonth);
            this.Name = "MonthlyAttendanceReport";
            this.Text = "MonthlyAttendanceReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMonth;
    }
}