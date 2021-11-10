
namespace MyStoreWinApp
{
    partial class frmCourseDetail
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
            this.lbSubjectID = new System.Windows.Forms.Label();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.cboSubjectID = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(95, 88);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(73, 20);
            this.lbCourseID.TabIndex = 0;
            this.lbCourseID.Text = "Course ID";
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Location = new System.Drawing.Point(95, 149);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(77, 20);
            this.lbSubjectID.TabIndex = 1;
            this.lbSubjectID.Text = "Subject ID";
            // 
            // lbCourseName
            // 
            this.lbCourseName.AutoSize = true;
            this.lbCourseName.Location = new System.Drawing.Point(95, 204);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(94, 20);
            this.lbCourseName.TabIndex = 2;
            this.lbCourseName.Text = "CourseName";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(218, 81);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(151, 27);
            this.txtCourseID.TabIndex = 3;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(218, 204);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(151, 27);
            this.txtCourseName.TabIndex = 4;
            // 
            // cboSubjectID
            // 
            this.cboSubjectID.FormattingEnabled = true;
            this.cboSubjectID.Items.AddRange(new object[] {
            "MAE101",
            "IOT201",
            "SSG103",
            "SWR203",
            "NWC202"});
            this.cboSubjectID.Location = new System.Drawing.Point(218, 141);
            this.cboSubjectID.Name = "cboSubjectID";
            this.cboSubjectID.Size = new System.Drawing.Size(151, 28);
            this.cboSubjectID.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(121, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(307, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCourseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 379);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboSubjectID);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lbCourseName);
            this.Controls.Add(this.lbSubjectID);
            this.Controls.Add(this.lbCourseID);
            this.Name = "frmCourseDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddtblCourse";
            this.Load += new System.EventHandler(this.CourseDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourseID;
        private System.Windows.Forms.Label lbSubjectID;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.ComboBox cboSubjectID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}