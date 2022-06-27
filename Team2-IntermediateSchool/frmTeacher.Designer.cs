namespace Team2_IntermediateSchool
{
    partial class frmTeacher
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnAssignments = new System.Windows.Forms.Button();
            this.btnSeating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Location = new System.Drawing.Point(151, 178);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Location = new System.Drawing.Point(48, 35);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(141, 40);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Text = "&Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGrades.Location = new System.Drawing.Point(254, 35);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(141, 40);
            this.btnGrades.TabIndex = 2;
            this.btnGrades.Text = "&Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnAssignments
            // 
            this.btnAssignments.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAssignments.Location = new System.Drawing.Point(48, 119);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(141, 40);
            this.btnAssignments.TabIndex = 3;
            this.btnAssignments.Text = "Assig&nments";
            this.btnAssignments.UseVisualStyleBackColor = true;
            this.btnAssignments.Click += new System.EventHandler(this.btnAssignments_Click);
            // 
            // btnSeating
            // 
            this.btnSeating.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSeating.Location = new System.Drawing.Point(254, 119);
            this.btnSeating.Name = "btnSeating";
            this.btnSeating.Size = new System.Drawing.Size(141, 40);
            this.btnSeating.TabIndex = 4;
            this.btnSeating.Text = "&Seating Chart";
            this.btnSeating.UseVisualStyleBackColor = true;
            this.btnSeating.Click += new System.EventHandler(this.btnSeating_Click);
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(442, 247);
            this.Controls.Add(this.btnSeating);
            this.Controls.Add(this.btnAssignments);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnAssignments;
        private System.Windows.Forms.Button btnSeating;
    }
}