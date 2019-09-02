namespace Employee_Management
{
    partial class AttendanceReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceReport));
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerSearchReport = new System.Windows.Forms.DateTimePicker();
            this.lblSearchByDateReport = new System.Windows.Forms.Label();
            this.lblSearchByEmpIdReport = new System.Windows.Forms.Label();
            this.btnSearchReport = new System.Windows.Forms.Button();
            this.txtSearchReport = new System.Windows.Forms.TextBox();
            this.panelReport = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panelReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.EmployeeId,
            this.ArrivedTime,
            this.LeftTime});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReport.Location = new System.Drawing.Point(39, 66);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(636, 215);
            this.dataGridViewReport.TabIndex = 0;
            this.dataGridViewReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewReport_CellContentClick);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmpID";
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            // 
            // ArrivedTime
            // 
            this.ArrivedTime.DataPropertyName = "inTime";
            this.ArrivedTime.HeaderText = "Arrived Time";
            this.ArrivedTime.Name = "ArrivedTime";
            this.ArrivedTime.ReadOnly = true;
            // 
            // LeftTime
            // 
            this.LeftTime.DataPropertyName = "outTime";
            this.LeftTime.HeaderText = "Left Time";
            this.LeftTime.Name = "LeftTime";
            this.LeftTime.ReadOnly = true;
            // 
            // dateTimePickerSearchReport
            // 
            this.dateTimePickerSearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearchReport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearchReport.Location = new System.Drawing.Point(384, 32);
            this.dateTimePickerSearchReport.Name = "dateTimePickerSearchReport";
            this.dateTimePickerSearchReport.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerSearchReport.TabIndex = 12;
            // 
            // lblSearchByDateReport
            // 
            this.lblSearchByDateReport.AutoSize = true;
            this.lblSearchByDateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByDateReport.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByDateReport.Location = new System.Drawing.Point(335, 36);
            this.lblSearchByDateReport.Name = "lblSearchByDateReport";
            this.lblSearchByDateReport.Size = new System.Drawing.Size(43, 18);
            this.lblSearchByDateReport.TabIndex = 11;
            this.lblSearchByDateReport.Text = "Date:";
            // 
            // lblSearchByEmpIdReport
            // 
            this.lblSearchByEmpIdReport.AutoSize = true;
            this.lblSearchByEmpIdReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByEmpIdReport.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByEmpIdReport.Location = new System.Drawing.Point(36, 32);
            this.lblSearchByEmpIdReport.Name = "lblSearchByEmpIdReport";
            this.lblSearchByEmpIdReport.Size = new System.Drawing.Size(93, 18);
            this.lblSearchByEmpIdReport.TabIndex = 10;
            this.lblSearchByEmpIdReport.Text = "Employee Id:";
            // 
            // btnSearchReport
            // 
            this.btnSearchReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchReport.Image")));
            this.btnSearchReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchReport.Location = new System.Drawing.Point(603, 30);
            this.btnSearchReport.Name = "btnSearchReport";
            this.btnSearchReport.Size = new System.Drawing.Size(72, 30);
            this.btnSearchReport.TabIndex = 9;
            this.btnSearchReport.UseVisualStyleBackColor = false;
            this.btnSearchReport.Click += new System.EventHandler(this.BtnSearchReport_Click);
            // 
            // txtSearchReport
            // 
            this.txtSearchReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchReport.ForeColor = System.Drawing.Color.Black;
            this.txtSearchReport.Location = new System.Drawing.Point(138, 30);
            this.txtSearchReport.Multiline = true;
            this.txtSearchReport.Name = "txtSearchReport";
            this.txtSearchReport.Size = new System.Drawing.Size(169, 22);
            this.txtSearchReport.TabIndex = 8;
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReport.Controls.Add(this.btnViewAll);
            this.panelReport.Controls.Add(this.dateTimePickerSearchReport);
            this.panelReport.Controls.Add(this.dataGridViewReport);
            this.panelReport.Controls.Add(this.txtSearchReport);
            this.panelReport.Controls.Add(this.lblSearchByDateReport);
            this.panelReport.Controls.Add(this.btnSearchReport);
            this.panelReport.Controls.Add(this.lblSearchByEmpIdReport);
            this.panelReport.Location = new System.Drawing.Point(38, 43);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(726, 363);
            this.panelReport.TabIndex = 13;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(39, 305);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(636, 27);
            this.btnViewAll.TabIndex = 13;
            this.btnViewAll.Text = "VIEW ALL";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // AttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReport);
            this.Name = "AttendanceReport";
            this.Text = "AttendanceReport";
            this.Load += new System.EventHandler(this.AttendanceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchReport;
        private System.Windows.Forms.Label lblSearchByDateReport;
        private System.Windows.Forms.Label lblSearchByEmpIdReport;
        private System.Windows.Forms.Button btnSearchReport;
        private System.Windows.Forms.TextBox txtSearchReport;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Button btnViewAll;
    }
}