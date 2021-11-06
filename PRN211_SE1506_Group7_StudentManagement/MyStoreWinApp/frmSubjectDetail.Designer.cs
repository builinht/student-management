
namespace MyStoreWinApp
{
    partial class frmSubjectDetail
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
            this.lbSubjectID = new System.Windows.Forms.Label();
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.lbMajorID = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Location = new System.Drawing.Point(70, 45);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(77, 20);
            this.lbSubjectID.TabIndex = 0;
            this.lbSubjectID.Text = "Subject ID";
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Location = new System.Drawing.Point(70, 93);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(102, 20);
            this.lbSubjectName.TabIndex = 1;
            this.lbSubjectName.Text = "Subject Name";
            // 
            // lbMajorID
            // 
            this.lbMajorID.AutoSize = true;
            this.lbMajorID.Location = new System.Drawing.Point(70, 147);
            this.lbMajorID.Name = "lbMajorID";
            this.lbMajorID.Size = new System.Drawing.Size(67, 20);
            this.lbMajorID.TabIndex = 2;
            this.lbMajorID.Text = "Major ID";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(192, 89);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(114, 27);
            this.txtSubjectName.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(80, 207);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(231, 205);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(192, 143);
            this.txtMajorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(114, 27);
            this.txtMajorID.TabIndex = 8;
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(192, 41);
            this.txtSubjectID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(114, 27);
            this.txtSubjectID.TabIndex = 9;
            // 
            // frmSubjectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 303);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.txtMajorID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.lbMajorID);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.lbSubjectID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSubjectDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject Detail";
            this.Load += new System.EventHandler(this.frmSubjectDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubjectID;
        private System.Windows.Forms.Label lbSubjectName;
        private System.Windows.Forms.Label lbMajorID;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.TextBox txtSubjectID;
    }
}