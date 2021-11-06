
namespace SalesWinApp
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
            this.cboSubjectID = new System.Windows.Forms.ComboBox();
            this.cboCourseName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbSubjectID = new System.Windows.Forms.Label();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.lbCourseID = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboSubjectID
            // 
            this.cboSubjectID.FormattingEnabled = true;
            this.cboSubjectID.Items.AddRange(new object[] {
            "IIP301",
            "MAE101",
            "MKT201"});
            this.cboSubjectID.Location = new System.Drawing.Point(259, 249);
            this.cboSubjectID.Name = "cboSubjectID";
            this.cboSubjectID.Size = new System.Drawing.Size(436, 28);
            this.cboSubjectID.TabIndex = 18;
            // 
            // cboCourseName
            // 
            this.cboCourseName.FormattingEnabled = true;
            this.cboCourseName.Items.AddRange(new object[] {
            "Marketing",
            "Math",
            "Internaltional Payment"});
            this.cboCourseName.Location = new System.Drawing.Point(259, 166);
            this.cboCourseName.Name = "cboCourseName";
            this.cboCourseName.Size = new System.Drawing.Size(436, 28);
            this.cboCourseName.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(601, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(259, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Location = new System.Drawing.Point(106, 257);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(77, 20);
            this.lbSubjectID.TabIndex = 13;
            this.lbSubjectID.Text = "Subject ID";
            this.lbSubjectID.Click += new System.EventHandler(this.lbSubjectID_Click);
            // 
            // lbCourseName
            // 
            this.lbCourseName.AutoSize = true;
            this.lbCourseName.Location = new System.Drawing.Point(106, 174);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(98, 20);
            this.lbCourseName.TabIndex = 12;
            this.lbCourseName.Text = "Course Name";
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(106, 93);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(73, 20);
            this.lbCourseID.TabIndex = 11;
            this.lbCourseID.Text = "Course ID";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(259, 88);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(436, 27);
            this.txtCourseID.TabIndex = 19;
            // 
            // frmCourseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.cboSubjectID);
            this.Controls.Add(this.cboCourseName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbSubjectID);
            this.Controls.Add(this.lbCourseName);
            this.Controls.Add(this.lbCourseID);
            this.Name = "frmCourseDetail";
            this.Text = "frmCourseDetail";
            this.Load += new System.EventHandler(this.frmCourseDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSubjectID;
        private System.Windows.Forms.ComboBox cboCourseName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbSubjectID;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label lbCourseID;
        private System.Windows.Forms.TextBox txtCourseID;
    }
}