
namespace MyStoreWinApp
{
    partial class frmSubject
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
            this.lbMajorID = new System.Windows.Forms.Label();
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.btnLoadSubject = new System.Windows.Forms.Button();
            this.btnNewSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Location = new System.Drawing.Point(71, 13);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(60, 15);
            this.lbSubjectID.TabIndex = 0;
            this.lbSubjectID.Text = "Subject ID";
            // 
            // lbMajorID
            // 
            this.lbMajorID.AutoSize = true;
            this.lbMajorID.Location = new System.Drawing.Point(71, 51);
            this.lbMajorID.Name = "lbMajorID";
            this.lbMajorID.Size = new System.Drawing.Size(52, 15);
            this.lbMajorID.TabIndex = 1;
            this.lbMajorID.Text = "Major ID";
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Location = new System.Drawing.Point(281, 13);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(81, 15);
            this.lbSubjectName.TabIndex = 2;
            this.lbSubjectName.Text = "Subject Name";
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(146, 10);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(100, 23);
            this.txtSubjectID.TabIndex = 3;
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(146, 48);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(100, 23);
            this.txtMajorID.TabIndex = 4;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(368, 10);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(100, 23);
            this.txtSubjectName.TabIndex = 5;
            // 
            // dgvSubject
            // 
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Location = new System.Drawing.Point(12, 134);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.RowTemplate.Height = 25;
            this.dgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubject.Size = new System.Drawing.Size(709, 164);
            this.dgvSubject.TabIndex = 6;
            // 
            // btnLoadSubject
            // 
            this.btnLoadSubject.Location = new System.Drawing.Point(539, 51);
            this.btnLoadSubject.Name = "btnLoadSubject";
            this.btnLoadSubject.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSubject.TabIndex = 7;
            this.btnLoadSubject.Text = "Load";
            this.btnLoadSubject.UseVisualStyleBackColor = true;
            this.btnLoadSubject.Click += new System.EventHandler(this.btnLoadSubject_Click);
            // 
            // btnNewSubject
            // 
            this.btnNewSubject.Location = new System.Drawing.Point(539, 13);
            this.btnNewSubject.Name = "btnNewSubject";
            this.btnNewSubject.Size = new System.Drawing.Size(75, 23);
            this.btnNewSubject.TabIndex = 8;
            this.btnNewSubject.Text = "New";
            this.btnNewSubject.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(539, 90);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSubject.TabIndex = 9;
            this.btnDeleteSubject.Text = "Delete";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 310);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnNewSubject);
            this.Controls.Add(this.btnLoadSubject);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.txtMajorID);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.lbMajorID);
            this.Controls.Add(this.lbSubjectID);
            this.Name = "frmSubject";
            this.Text = "frmSubject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubjectID;
        private System.Windows.Forms.Label lbMajorID;
        private System.Windows.Forms.Label lbSubjectName;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.Button btnLoadSubject;
        private System.Windows.Forms.Button btnNewSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
    }
}