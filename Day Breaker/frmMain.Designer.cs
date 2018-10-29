namespace Day_Breaker
{
    partial class frmMain
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
            this.lblKilometersAYear = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtKilometersAYear = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.lblKilometersPerDay = new System.Windows.Forms.Label();
            this.txtKilometersPerDay = new System.Windows.Forms.Label();
            this.txtPlannedKilometersPerDay = new System.Windows.Forms.Label();
            this.lblPlannedKilometersPerDay = new System.Windows.Forms.Label();
            this.txtCurrentKilometersCount = new System.Windows.Forms.TextBox();
            this.lblCurrentKilometersCount = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblShouldBeKilometersCount = new System.Windows.Forms.Label();
            this.txtShouldBeKilometersCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKilometersAYear
            // 
            this.lblKilometersAYear.AutoSize = true;
            this.lblKilometersAYear.Location = new System.Drawing.Point(12, 9);
            this.lblKilometersAYear.Name = "lblKilometersAYear";
            this.lblKilometersAYear.Size = new System.Drawing.Size(90, 13);
            this.lblKilometersAYear.TabIndex = 0;
            this.lblKilometersAYear.Text = "Kilometers A Year";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(634, 81);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 34);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtKilometersAYear
            // 
            this.txtKilometersAYear.Location = new System.Drawing.Point(108, 6);
            this.txtKilometersAYear.Name = "txtKilometersAYear";
            this.txtKilometersAYear.Size = new System.Drawing.Size(96, 20);
            this.txtKilometersAYear.TabIndex = 2;
            this.txtKilometersAYear.Text = "25000";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(73, 86);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 3;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 86);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(334, 86);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(395, 86);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 20);
            this.dtEnd.TabIndex = 5;
            // 
            // lblKilometersPerDay
            // 
            this.lblKilometersPerDay.AutoSize = true;
            this.lblKilometersPerDay.Location = new System.Drawing.Point(12, 170);
            this.lblKilometersPerDay.Name = "lblKilometersPerDay";
            this.lblKilometersPerDay.Size = new System.Drawing.Size(96, 13);
            this.lblKilometersPerDay.TabIndex = 7;
            this.lblKilometersPerDay.Text = "Kilometers Per Day";
            // 
            // txtKilometersPerDay
            // 
            this.txtKilometersPerDay.AutoSize = true;
            this.txtKilometersPerDay.Location = new System.Drawing.Point(204, 170);
            this.txtKilometersPerDay.Name = "txtKilometersPerDay";
            this.txtKilometersPerDay.Size = new System.Drawing.Size(22, 13);
            this.txtKilometersPerDay.TabIndex = 8;
            this.txtKilometersPerDay.Text = "xxx";
            // 
            // txtPlannedKilometersPerDay
            // 
            this.txtPlannedKilometersPerDay.AutoSize = true;
            this.txtPlannedKilometersPerDay.Location = new System.Drawing.Point(204, 206);
            this.txtPlannedKilometersPerDay.Name = "txtPlannedKilometersPerDay";
            this.txtPlannedKilometersPerDay.Size = new System.Drawing.Size(22, 13);
            this.txtPlannedKilometersPerDay.TabIndex = 10;
            this.txtPlannedKilometersPerDay.Text = "xxx";
            // 
            // lblPlannedKilometersPerDay
            // 
            this.lblPlannedKilometersPerDay.AutoSize = true;
            this.lblPlannedKilometersPerDay.Location = new System.Drawing.Point(12, 206);
            this.lblPlannedKilometersPerDay.Name = "lblPlannedKilometersPerDay";
            this.lblPlannedKilometersPerDay.Size = new System.Drawing.Size(138, 13);
            this.lblPlannedKilometersPerDay.TabIndex = 9;
            this.lblPlannedKilometersPerDay.Text = "Planned Kilometers Per Day";
            // 
            // txtCurrentKilometersCount
            // 
            this.txtCurrentKilometersCount.Location = new System.Drawing.Point(485, 6);
            this.txtCurrentKilometersCount.Name = "txtCurrentKilometersCount";
            this.txtCurrentKilometersCount.Size = new System.Drawing.Size(96, 20);
            this.txtCurrentKilometersCount.TabIndex = 12;
            // 
            // lblCurrentKilometersCount
            // 
            this.lblCurrentKilometersCount.AutoSize = true;
            this.lblCurrentKilometersCount.Location = new System.Drawing.Point(334, 9);
            this.lblCurrentKilometersCount.Name = "lblCurrentKilometersCount";
            this.lblCurrentKilometersCount.Size = new System.Drawing.Size(123, 13);
            this.lblCurrentKilometersCount.TabIndex = 11;
            this.lblCurrentKilometersCount.Text = "Current Kilometers Count";
            // 
            // txtDays
            // 
            this.txtDays.AutoSize = true;
            this.txtDays.Location = new System.Drawing.Point(204, 134);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(22, 13);
            this.txtDays.TabIndex = 14;
            this.txtDays.Text = "xxx";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(12, 134);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 13;
            this.lblDays.Text = "Days";
            // 
            // lblShouldBeKilometersCount
            // 
            this.lblShouldBeKilometersCount.AutoSize = true;
            this.lblShouldBeKilometersCount.Location = new System.Drawing.Point(334, 42);
            this.lblShouldBeKilometersCount.Name = "lblShouldBeKilometersCount";
            this.lblShouldBeKilometersCount.Size = new System.Drawing.Size(138, 13);
            this.lblShouldBeKilometersCount.TabIndex = 15;
            this.lblShouldBeKilometersCount.Text = "Should Be Kilometers Count";
            // 
            // txtShouldBeKilometersCount
            // 
            this.txtShouldBeKilometersCount.AutoSize = true;
            this.txtShouldBeKilometersCount.Location = new System.Drawing.Point(494, 42);
            this.txtShouldBeKilometersCount.Name = "txtShouldBeKilometersCount";
            this.txtShouldBeKilometersCount.Size = new System.Drawing.Size(22, 13);
            this.txtShouldBeKilometersCount.TabIndex = 16;
            this.txtShouldBeKilometersCount.Text = "xxx";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 420);
            this.Controls.Add(this.txtShouldBeKilometersCount);
            this.Controls.Add(this.lblShouldBeKilometersCount);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtCurrentKilometersCount);
            this.Controls.Add(this.lblCurrentKilometersCount);
            this.Controls.Add(this.txtPlannedKilometersPerDay);
            this.Controls.Add(this.lblPlannedKilometersPerDay);
            this.Controls.Add(this.txtKilometersPerDay);
            this.Controls.Add(this.lblKilometersPerDay);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.txtKilometersAYear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblKilometersAYear);
            this.Name = "frmMain";
            this.Text = "Day Breaker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKilometersAYear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtKilometersAYear;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblKilometersPerDay;
        private System.Windows.Forms.Label txtKilometersPerDay;
        private System.Windows.Forms.Label txtPlannedKilometersPerDay;
        private System.Windows.Forms.Label lblPlannedKilometersPerDay;
        private System.Windows.Forms.TextBox txtCurrentKilometersCount;
        private System.Windows.Forms.Label lblCurrentKilometersCount;
        private System.Windows.Forms.Label txtDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblShouldBeKilometersCount;
        private System.Windows.Forms.Label txtShouldBeKilometersCount;
    }
}

