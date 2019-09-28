namespace Employee_Management
{
    partial class AttendanceUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Attendance = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAttendanceId = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblEnterLeftTime = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblInTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblLeftTme = new System.Windows.Forms.Label();
            this.lblArrivedTime = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.lblSearchByDate = new System.Windows.Forms.Label();
            this.lblSearchByEmpId = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AttendId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(282, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Attendance";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Attendance);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 165);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 343);
            this.tabControl1.TabIndex = 16;
            // 
            // Attendance
            // 
            this.Attendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Attendance.Controls.Add(this.pictureBox1);
            this.Attendance.Controls.Add(this.panel1);
            this.Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance.Location = new System.Drawing.Point(4, 22);
            this.Attendance.Name = "Attendance";
            this.Attendance.Padding = new System.Windows.Forms.Padding(3);
            this.Attendance.Size = new System.Drawing.Size(672, 317);
            this.Attendance.TabIndex = 0;
            this.Attendance.Text = "Attendance";
            this.Attendance.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
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
            this.panel1.Location = new System.Drawing.Point(353, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 214);
            this.panel1.TabIndex = 2;
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
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(45, 35);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
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
            this.comboMonth.Size = new System.Drawing.Size(133, 28);
            this.comboMonth.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(124, 35);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(133, 26);
            this.txtYear.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.Color.Black;
            this.lblMonth.Location = new System.Drawing.Point(45, 83);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(54, 20);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Month";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insert Attendance";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblAttendanceId);
            this.panel2.Controls.Add(this.lblEmployeeId);
            this.panel2.Controls.Add(this.lblEnterLeftTime);
            this.panel2.Controls.Add(this.txtEmployeeId);
            this.panel2.Controls.Add(this.lblInTime);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblLeftTme);
            this.panel2.Controls.Add(this.lblArrivedTime);
            this.panel2.Location = new System.Drawing.Point(118, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 274);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // lblAttendanceId
            // 
            this.lblAttendanceId.AutoSize = true;
            this.lblAttendanceId.Location = new System.Drawing.Point(94, 9);
            this.lblAttendanceId.Name = "lblAttendanceId";
            this.lblAttendanceId.Size = new System.Drawing.Size(0, 18);
            this.lblAttendanceId.TabIndex = 12;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.White;
            this.lblEmployeeId.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeId.Location = new System.Drawing.Point(47, 36);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(93, 18);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "Employee Id:";
            // 
            // lblEnterLeftTime
            // 
            this.lblEnterLeftTime.AutoSize = true;
            this.lblEnterLeftTime.ForeColor = System.Drawing.Color.Black;
            this.lblEnterLeftTime.Location = new System.Drawing.Point(182, 165);
            this.lblEnterLeftTime.Name = "lblEnterLeftTime";
            this.lblEnterLeftTime.Size = new System.Drawing.Size(130, 18);
            this.lblEnterLeftTime.TabIndex = 11;
            this.lblEnterLeftTime.Text = "Enter left time later";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(185, 30);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(200, 24);
            this.txtEmployeeId.TabIndex = 6;
            // 
            // lblInTime
            // 
            this.lblInTime.AutoSize = true;
            this.lblInTime.BackColor = System.Drawing.Color.DarkGray;
            this.lblInTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInTime.ForeColor = System.Drawing.Color.Black;
            this.lblInTime.Location = new System.Drawing.Point(182, 121);
            this.lblInTime.Name = "lblInTime";
            this.lblInTime.Size = new System.Drawing.Size(2, 20);
            this.lblInTime.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(47, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(27, 225);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(335, 33);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblLeftTme
            // 
            this.lblLeftTme.AutoSize = true;
            this.lblLeftTme.BackColor = System.Drawing.Color.White;
            this.lblLeftTme.ForeColor = System.Drawing.Color.Black;
            this.lblLeftTme.Location = new System.Drawing.Point(46, 165);
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
            this.lblArrivedTime.Location = new System.Drawing.Point(46, 121);
            this.lblArrivedTime.Name = "lblArrivedTime";
            this.lblArrivedTime.Size = new System.Drawing.Size(94, 18);
            this.lblArrivedTime.TabIndex = 3;
            this.lblArrivedTime.Text = "Arrived Time:";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.dateTimePickerSearch);
            this.tabPage3.Controls.Add(this.lblSearchByDate);
            this.tabPage3.Controls.Add(this.lblSearchByEmpId);
            this.tabPage3.Controls.Add(this.btnViewAll);
            this.tabPage3.Controls.Add(this.txtSearch);
            this.tabPage3.Controls.Add(this.dataGridView);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(672, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Attendanace";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearch.Location = new System.Drawing.Point(368, 17);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerSearch.TabIndex = 15;
            // 
            // lblSearchByDate
            // 
            this.lblSearchByDate.AutoSize = true;
            this.lblSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByDate.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByDate.Location = new System.Drawing.Point(319, 21);
            this.lblSearchByDate.Name = "lblSearchByDate";
            this.lblSearchByDate.Size = new System.Drawing.Size(43, 18);
            this.lblSearchByDate.TabIndex = 14;
            this.lblSearchByDate.Text = "Date:";
            // 
            // lblSearchByEmpId
            // 
            this.lblSearchByEmpId.AutoSize = true;
            this.lblSearchByEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByEmpId.ForeColor = System.Drawing.Color.Black;
            this.lblSearchByEmpId.Location = new System.Drawing.Point(20, 17);
            this.lblSearchByEmpId.Name = "lblSearchByEmpId";
            this.lblSearchByEmpId.Size = new System.Drawing.Size(93, 18);
            this.lblSearchByEmpId.TabIndex = 13;
            this.lblSearchByEmpId.Text = "Employee Id:";
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(13, 274);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(646, 27);
            this.btnViewAll.TabIndex = 11;
            this.btnViewAll.Text = "VIEW ALL";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(119, 17);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendId,
            this.EmpId,
            this.Date,
            this.ArrivedTime,
            this.LeftTime,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Location = new System.Drawing.Point(13, 51);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Size = new System.Drawing.Size(646, 201);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // AttendId
            // 
            this.AttendId.DataPropertyName = "AttendID";
            this.AttendId.HeaderText = "AttendId";
            this.AttendId.Name = "AttendId";
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(587, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Employee_Management.Properties.Resources.WhatsApp_Image_2019_08_27_at_11_251;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 159);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // AttendanceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "AttendanceUserControl";
            this.Size = new System.Drawing.Size(683, 508);
            this.Load += new System.EventHandler(this.AttendanceUserControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.Attendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Attendance;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAttendanceId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblEnterLeftTime;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblInTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblLeftTme;
        private System.Windows.Forms.Label lblArrivedTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Label lblSearchByDate;
        private System.Windows.Forms.Label lblSearchByEmpId;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftTime;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
