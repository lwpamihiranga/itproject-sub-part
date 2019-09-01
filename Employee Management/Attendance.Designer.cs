namespace Employee_Management
{
    partial class Attendance
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
            System.Windows.Forms.TabPage tabView;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.lblSearchByDate = new System.Windows.Forms.Label();
            this.lblSearchByEmpId = new System.Windows.Forms.Label();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.txtLeftTime = new System.Windows.Forms.TextBox();
            this.txtArrivedTime = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblLeftTme = new System.Windows.Forms.Label();
            this.lblArrivedTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.ssss = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            tabView = new System.Windows.Forms.TabPage();
            tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabView
            // 
            tabView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabView.Controls.Add(this.dateTimePickerSearch);
            tabView.Controls.Add(this.lblSearchByDate);
            tabView.Controls.Add(this.lblSearchByEmpId);
            tabView.Controls.Add(this.btnGenReport);
            tabView.Controls.Add(this.btnViewAll);
            tabView.Controls.Add(this.btnSearch);
            tabView.Controls.Add(this.txtSearch);
            tabView.Controls.Add(this.dataGridView);
            tabView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabView.Location = new System.Drawing.Point(4, 27);
            tabView.Name = "tabView";
            tabView.Size = new System.Drawing.Size(672, 312);
            tabView.TabIndex = 2;
            tabView.Text = "View Attendance";
            tabView.UseVisualStyleBackColor = true;
            tabView.Click += new System.EventHandler(this.TabView_Click);
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearch.Location = new System.Drawing.Point(358, 19);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerSearch.TabIndex = 7;
            // 
            // lblSearchByDate
            // 
            this.lblSearchByDate.AutoSize = true;
            this.lblSearchByDate.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByDate.Location = new System.Drawing.Point(309, 23);
            this.lblSearchByDate.Name = "lblSearchByDate";
            this.lblSearchByDate.Size = new System.Drawing.Size(43, 18);
            this.lblSearchByDate.TabIndex = 6;
            this.lblSearchByDate.Text = "Date:";
            // 
            // lblSearchByEmpId
            // 
            this.lblSearchByEmpId.AutoSize = true;
            this.lblSearchByEmpId.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByEmpId.Location = new System.Drawing.Point(10, 19);
            this.lblSearchByEmpId.Name = "lblSearchByEmpId";
            this.lblSearchByEmpId.Size = new System.Drawing.Size(93, 18);
            this.lblSearchByEmpId.TabIndex = 5;
            this.lblSearchByEmpId.Text = "Employee Id:";
            // 
            // btnGenReport
            // 
            this.btnGenReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenReport.ForeColor = System.Drawing.Color.White;
            this.btnGenReport.Location = new System.Drawing.Point(333, 276);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(316, 27);
            this.btnGenReport.TabIndex = 4;
            this.btnGenReport.Text = "GENERATE REPORT";
            this.btnGenReport.UseVisualStyleBackColor = false;
            this.btnGenReport.Click += new System.EventHandler(this.BtnGenReport_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(13, 276);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(314, 27);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "VIEW ALL";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(577, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(109, 19);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.Date,
            this.ArrivedTime,
            this.LeftTime,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(3, 53);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Size = new System.Drawing.Size(646, 201);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpID";
            this.EmpId.HeaderText = "EmpId";
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            this.EmpId.Width = 75;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ArrivedTime
            // 
            this.ArrivedTime.DataPropertyName = "inTime";
            this.ArrivedTime.HeaderText = "Arrived Time";
            this.ArrivedTime.Name = "ArrivedTime";
            this.ArrivedTime.ReadOnly = true;
            this.ArrivedTime.Width = 125;
            // 
            // LeftTime
            // 
            this.LeftTime.DataPropertyName = "outTime";
            this.LeftTime.HeaderText = "Left Time";
            this.LeftTime.Name = "LeftTime";
            this.LeftTime.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "EDIT";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "DELETE";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(303, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAttendance);
            this.tabControl1.Controls.Add(this.tabInsert);
            this.tabControl1.Controls.Add(tabView);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 162);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 343);
            this.tabControl1.TabIndex = 10;
            // 
            // tabAttendance
            // 
            this.tabAttendance.BackColor = System.Drawing.Color.Transparent;
            this.tabAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAttendance.Controls.Add(this.pictureBox1);
            this.tabAttendance.Controls.Add(this.panel1);
            this.tabAttendance.Location = new System.Drawing.Point(4, 27);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttendance.Size = new System.Drawing.Size(672, 312);
            this.tabAttendance.TabIndex = 0;
            this.tabAttendance.Text = "Attendance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.comboMonth);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Location = new System.Drawing.Point(339, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 214);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(48, 141);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(209, 33);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(45, 35);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 18);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // comboMonth
            // 
            this.comboMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "02",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboMonth.Location = new System.Drawing.Point(124, 83);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(133, 26);
            this.comboMonth.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(124, 35);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(133, 24);
            this.txtYear.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.Color.Black;
            this.lblMonth.Location = new System.Drawing.Point(45, 83);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(50, 18);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Month";
            // 
            // tabInsert
            // 
            this.tabInsert.BackColor = System.Drawing.Color.Transparent;
            this.tabInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInsert.Controls.Add(this.txtLeftTime);
            this.tabInsert.Controls.Add(this.txtArrivedTime);
            this.tabInsert.Controls.Add(this.dateTimePicker1);
            this.tabInsert.Controls.Add(this.txtEmployeeId);
            this.tabInsert.Controls.Add(this.btnInsert);
            this.tabInsert.Controls.Add(this.lblLeftTme);
            this.tabInsert.Controls.Add(this.lblArrivedTime);
            this.tabInsert.Controls.Add(this.lblDate);
            this.tabInsert.Controls.Add(this.lblEmployeeId);
            this.tabInsert.Controls.Add(this.ssss);
            this.tabInsert.Location = new System.Drawing.Point(4, 27);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(672, 312);
            this.tabInsert.TabIndex = 1;
            this.tabInsert.Text = "Insert Attendance";
            // 
            // txtLeftTime
            // 
            this.txtLeftTime.Location = new System.Drawing.Point(287, 176);
            this.txtLeftTime.Name = "txtLeftTime";
            this.txtLeftTime.Size = new System.Drawing.Size(200, 24);
            this.txtLeftTime.TabIndex = 9;
            // 
            // txtArrivedTime
            // 
            this.txtArrivedTime.Location = new System.Drawing.Point(287, 138);
            this.txtArrivedTime.Name = "txtArrivedTime";
            this.txtArrivedTime.Size = new System.Drawing.Size(200, 24);
            this.txtArrivedTime.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(287, 54);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(200, 24);
            this.txtEmployeeId.TabIndex = 6;
            this.txtEmployeeId.TextChanged += new System.EventHandler(this.TxtEmployeeId_TextChanged);
            this.txtEmployeeId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmployeeId_Validating);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(152, 226);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(335, 33);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            this.btnInsert.Validated += new System.EventHandler(this.BtnInsert_Validated);
            // 
            // lblLeftTme
            // 
            this.lblLeftTme.AutoSize = true;
            this.lblLeftTme.BackColor = System.Drawing.Color.White;
            this.lblLeftTme.ForeColor = System.Drawing.Color.Black;
            this.lblLeftTme.Location = new System.Drawing.Point(149, 176);
            this.lblLeftTme.Name = "lblLeftTme";
            this.lblLeftTme.Size = new System.Drawing.Size(73, 18);
            this.lblLeftTme.TabIndex = 4;
            this.lblLeftTme.Text = "Left Time:";
            // 
            // lblArrivedTime
            // 
            this.lblArrivedTime.AutoSize = true;
            this.lblArrivedTime.BackColor = System.Drawing.Color.White;
            this.lblArrivedTime.ForeColor = System.Drawing.Color.Black;
            this.lblArrivedTime.Location = new System.Drawing.Point(149, 138);
            this.lblArrivedTime.Name = "lblArrivedTime";
            this.lblArrivedTime.Size = new System.Drawing.Size(94, 18);
            this.lblArrivedTime.TabIndex = 3;
            this.lblArrivedTime.Text = "Arrived Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(149, 93);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.White;
            this.lblEmployeeId.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeId.Location = new System.Drawing.Point(149, 57);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(93, 18);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "Employee Id:";
            // 
            // ssss
            // 
            this.ssss.BackColor = System.Drawing.Color.Transparent;
            this.ssss.Image = ((System.Drawing.Image)(resources.GetObject("ssss.Image")));
            this.ssss.Location = new System.Drawing.Point(93, 28);
            this.ssss.Name = "ssss";
            this.ssss.Size = new System.Drawing.Size(474, 260);
            this.ssss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ssss.TabIndex = 0;
            this.ssss.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 159);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(683, 508);
            this.Load += new System.EventHandler(this.Attendance_Load_1);
            tabView.ResumeLayout(false);
            tabView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabInsert.ResumeLayout(false);
            this.tabInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.TextBox txtLeftTime;
        private System.Windows.Forms.TextBox txtArrivedTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblLeftTme;
        private System.Windows.Forms.Label lblArrivedTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.PictureBox ssss;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Label lblSearchByDate;
        private System.Windows.Forms.Label lblSearchByEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftTime;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
