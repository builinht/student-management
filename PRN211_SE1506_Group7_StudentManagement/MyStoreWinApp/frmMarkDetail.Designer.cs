
namespace MyStoreWinApp
{
    partial class frmMarkDetail
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
            this.lbCourseID = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.Label();
            this.lbAssignment = new System.Windows.Forms.Label();
            this.lbPractical = new System.Windows.Forms.Label();
            this.cboCourseID = new System.Windows.Forms.ComboBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.txtPractical = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(52, 91);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(69, 20);
            this.lbCourseID.TabIndex = 0;
            this.lbCourseID.Text = "CourseID";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(52, 146);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(75, 20);
            this.lbStudentID.TabIndex = 1;
            this.lbStudentID.Text = "StudentID";
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Location = new System.Drawing.Point(368, 191);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(40, 20);
            this.lbFinal.TabIndex = 2;
            this.lbFinal.Text = "Final";
            // 
            // lbAssignment
            // 
            this.lbAssignment.AutoSize = true;
            this.lbAssignment.Location = new System.Drawing.Point(362, 91);
            this.lbAssignment.Name = "lbAssignment";
            this.lbAssignment.Size = new System.Drawing.Size(86, 20);
            this.lbAssignment.TabIndex = 3;
            this.lbAssignment.Text = "Assignment";
            // 
            // lbPractical
            // 
            this.lbPractical.AutoSize = true;
            this.lbPractical.Location = new System.Drawing.Point(368, 142);
            this.lbPractical.Name = "lbPractical";
            this.lbPractical.Size = new System.Drawing.Size(65, 20);
            this.lbPractical.TabIndex = 4;
            this.lbPractical.Text = "Practical";
            // 
            // cboCourseID
            // 
            this.cboCourseID.FormattingEnabled = true;
            this.cboCourseID.Location = new System.Drawing.Point(149, 94);
            this.cboCourseID.Name = "cboCourseID";
            this.cboCourseID.Size = new System.Drawing.Size(151, 28);
            this.cboCourseID.TabIndex = 6;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(149, 146);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(125, 27);
            this.txtStudentID.TabIndex = 7;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(475, 191);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(125, 27);
            this.txtFinal.TabIndex = 8;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(475, 84);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(125, 27);
            this.txtAssignment.TabIndex = 9;
            // 
            // txtPractical
            // 
            this.txtPractical.Location = new System.Drawing.Point(475, 139);
            this.txtPractical.Name = "txtPractical";
            this.txtPractical.Size = new System.Drawing.Size(125, 27);
            this.txtPractical.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(449, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMarkDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPractical);
            this.Controls.Add(this.txtAssignment);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.cboCourseID);
            this.Controls.Add(this.lbPractical);
            this.Controls.Add(this.lbAssignment);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.lbCourseID);
            this.Name = "frmMarkDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkDetail";
            this.Load += new System.EventHandler(this.frmMarkDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourseID;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbAssignment;
        private System.Windows.Forms.Label lbPractical;
        private System.Windows.Forms.ComboBox cboCourseID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.TextBox txtPractical;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}