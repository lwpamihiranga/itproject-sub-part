namespace Employee_Management
{
    partial class Update
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
            this.txtUpdateLeftTime = new System.Windows.Forms.TextBox();
            this.txtUpdateArrivedTime = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateTimePickerUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateEmployeeId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.ssss = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ssss)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUpdateLeftTime
            // 
            this.txtUpdateLeftTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateLeftTime.Location = new System.Drawing.Point(215, 209);
            this.txtUpdateLeftTime.Name = "txtUpdateLeftTime";
            this.txtUpdateLeftTime.Size = new System.Drawing.Size(242, 24);
            this.txtUpdateLeftTime.TabIndex = 30;
            // 
            // txtUpdateArrivedTime
            // 
            this.txtUpdateArrivedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateArrivedTime.Location = new System.Drawing.Point(215, 174);
            this.txtUpdateArrivedTime.Name = "txtUpdateArrivedTime";
            this.txtUpdateArrivedTime.Size = new System.Drawing.Size(242, 24);
            this.txtUpdateArrivedTime.TabIndex = 29;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(81, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(376, 26);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePickerUpdate
            // 
            this.dateTimePickerUpdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUpdate.Location = new System.Drawing.Point(215, 134);
            this.dateTimePickerUpdate.Name = "dateTimePickerUpdate";
            this.dateTimePickerUpdate.Size = new System.Drawing.Size(242, 24);
            this.dateTimePickerUpdate.TabIndex = 27;
            // 
            // txtUpdateEmployeeId
            // 
            this.txtUpdateEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateEmployeeId.Location = new System.Drawing.Point(215, 96);
            this.txtUpdateEmployeeId.Name = "txtUpdateEmployeeId";
            this.txtUpdateEmployeeId.Size = new System.Drawing.Size(242, 24);
            this.txtUpdateEmployeeId.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Please update the reqired fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Left Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Arrived Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date:";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.White;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(95, 95);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(93, 18);
            this.lblEmployeeId.TabIndex = 21;
            this.lblEmployeeId.Text = "Employee Id:";
            // 
            // ssss
            // 
            this.ssss.BackColor = System.Drawing.Color.Transparent;
            this.ssss.Image = global::Employee_Management.Properties.Resources.frame2;
            this.ssss.Location = new System.Drawing.Point(34, 65);
            this.ssss.Name = "ssss";
            this.ssss.Size = new System.Drawing.Size(472, 265);
            this.ssss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ssss.TabIndex = 20;
            this.ssss.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUpdateLeftTime);
            this.Controls.Add(this.txtUpdateArrivedTime);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dateTimePickerUpdate);
            this.Controls.Add(this.txtUpdateEmployeeId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.ssss);
            this.Name = "Update";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.ssss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpdateLeftTime;
        private System.Windows.Forms.TextBox txtUpdateArrivedTime;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdate;
        private System.Windows.Forms.TextBox txtUpdateEmployeeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.PictureBox ssss;
        private System.Windows.Forms.Button button1;
    }
}