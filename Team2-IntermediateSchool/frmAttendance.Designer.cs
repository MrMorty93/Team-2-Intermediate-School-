namespace Team2_IntermediateSchool
{
    partial class frmAttendance
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
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.gbxAttendance = new System.Windows.Forms.GroupBox();
            this.rdoPresent = new System.Windows.Forms.RadioButton();
            this.rdoAbsent = new System.Windows.Forms.RadioButton();
            this.rdoLate = new System.Windows.Forms.RadioButton();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.gbxAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(12, 41);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.Size = new System.Drawing.Size(240, 150);
            this.dgvClass.TabIndex = 0;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(286, 41);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(369, 320);
            this.dgvStudents.TabIndex = 1;
            // 
            // gbxAttendance
            // 
            this.gbxAttendance.Controls.Add(this.rdoLate);
            this.gbxAttendance.Controls.Add(this.rdoAbsent);
            this.gbxAttendance.Controls.Add(this.rdoPresent);
            this.gbxAttendance.Location = new System.Drawing.Point(689, 41);
            this.gbxAttendance.Name = "gbxAttendance";
            this.gbxAttendance.Size = new System.Drawing.Size(200, 225);
            this.gbxAttendance.TabIndex = 2;
            this.gbxAttendance.TabStop = false;
            this.gbxAttendance.Text = "Status";
            // 
            // rdoPresent
            // 
            this.rdoPresent.AutoSize = true;
            this.rdoPresent.Location = new System.Drawing.Point(57, 48);
            this.rdoPresent.Name = "rdoPresent";
            this.rdoPresent.Size = new System.Drawing.Size(92, 28);
            this.rdoPresent.TabIndex = 3;
            this.rdoPresent.TabStop = true;
            this.rdoPresent.Text = "Present";
            this.rdoPresent.UseVisualStyleBackColor = true;
            // 
            // rdoAbsent
            // 
            this.rdoAbsent.AutoSize = true;
            this.rdoAbsent.Location = new System.Drawing.Point(57, 110);
            this.rdoAbsent.Name = "rdoAbsent";
            this.rdoAbsent.Size = new System.Drawing.Size(87, 28);
            this.rdoAbsent.TabIndex = 4;
            this.rdoAbsent.TabStop = true;
            this.rdoAbsent.Text = "Absent";
            this.rdoAbsent.UseVisualStyleBackColor = true;
            // 
            // rdoLate
            // 
            this.rdoLate.AutoSize = true;
            this.rdoLate.Location = new System.Drawing.Point(57, 172);
            this.rdoLate.Name = "rdoLate";
            this.rdoLate.Size = new System.Drawing.Size(63, 28);
            this.rdoLate.TabIndex = 5;
            this.rdoLate.TabStop = true;
            this.rdoLate.Text = "Late";
            this.rdoLate.UseVisualStyleBackColor = true;
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(731, 272);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(122, 57);
            this.btnMark.TabIndex = 6;
            this.btnMark.Text = "&Mark Attendance";
            this.btnMark.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(812, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 55);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmAttendance
            // 
            this.AcceptButton = this.btnMark;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(931, 442);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.gbxAttendance);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.dgvClass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.gbxAttendance.ResumeLayout(false);
            this.gbxAttendance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox gbxAttendance;
        private System.Windows.Forms.RadioButton rdoLate;
        private System.Windows.Forms.RadioButton rdoAbsent;
        private System.Windows.Forms.RadioButton rdoPresent;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnClose;
    }
}