
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
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.lbMajorID = new System.Windows.Forms.Label();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.dgvSubjectList = new System.Windows.Forms.DataGridView();
            this.btnNewSub = new System.Windows.Forms.Button();
            this.btnLoadSub = new System.Windows.Forms.Button();
            this.btnDeleteSub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Location = new System.Drawing.Point(62, 42);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(60, 15);
            this.lbSubjectID.TabIndex = 0;
            this.lbSubjectID.Text = "Subject ID";
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Location = new System.Drawing.Point(62, 84);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(81, 15);
            this.lbSubjectName.TabIndex = 1;
            this.lbSubjectName.Text = "Subject Name";
            // 
            // lbMajorID
            // 
            this.lbMajorID.AutoSize = true;
            this.lbMajorID.Location = new System.Drawing.Point(348, 42);
            this.lbMajorID.Name = "lbMajorID";
            this.lbMajorID.Size = new System.Drawing.Size(52, 15);
            this.lbMajorID.TabIndex = 2;
            this.lbMajorID.Text = "Major ID";
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(149, 39);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(100, 23);
            this.txtSubjectID.TabIndex = 3;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(149, 81);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(100, 23);
            this.txtSubjectName.TabIndex = 4;
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(420, 39);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(100, 23);
            this.txtMajorID.TabIndex = 5;
            // 
            // dgvSubjectList
            // 
            this.dgvSubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectList.Location = new System.Drawing.Point(12, 130);
            this.dgvSubjectList.Name = "dgvSubjectList";
            this.dgvSubjectList.RowTemplate.Height = 25;
            this.dgvSubjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvSubjectList.Size = new System.Drawing.Size(636, 203);
            this.dgvSubjectList.TabIndex = 6;
            this.dgvSubjectList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjectList_CellDoubleClick);
            // 
            // btnNewSub
            // 
            this.btnNewSub.Location = new System.Drawing.Point(566, 39);
            this.btnNewSub.Name = "btnNewSub";
            this.btnNewSub.Size = new System.Drawing.Size(75, 23);
            this.btnNewSub.TabIndex = 7;
            this.btnNewSub.Text = "New";
            this.btnNewSub.UseVisualStyleBackColor = true;
            this.btnNewSub.Click += new System.EventHandler(this.btnNewSub_Click);
            // 
            // btnLoadSub
            // 
            this.btnLoadSub.Location = new System.Drawing.Point(566, 68);
            this.btnLoadSub.Name = "btnLoadSub";
            this.btnLoadSub.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSub.TabIndex = 8;
            this.btnLoadSub.Text = "Load";
            this.btnLoadSub.UseVisualStyleBackColor = true;
            this.btnLoadSub.Click += new System.EventHandler(this.btnLoadSub_Click);
            // 
            // btnDeleteSub
            // 
            this.btnDeleteSub.Location = new System.Drawing.Point(566, 97);
            this.btnDeleteSub.Name = "btnDeleteSub";
            this.btnDeleteSub.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSub.TabIndex = 9;
            this.btnDeleteSub.Text = "Delete";
            this.btnDeleteSub.UseVisualStyleBackColor = true;
            this.btnDeleteSub.Click += new System.EventHandler(this.btnDeleteSub_Click);
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 343);
            this.Controls.Add(this.btnDeleteSub);
            this.Controls.Add(this.btnLoadSub);
            this.Controls.Add(this.btnNewSub);
            this.Controls.Add(this.dgvSubjectList);
            this.Controls.Add(this.txtMajorID);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.lbMajorID);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.lbSubjectID);
            this.Name = "frmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubjectID;
        private System.Windows.Forms.Label lbSubjectName;
        private System.Windows.Forms.Label lbMajorID;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.DataGridView dgvSubjectList;
        private System.Windows.Forms.Button btnNewSub;
        private System.Windows.Forms.Button btnLoadSub;
        private System.Windows.Forms.Button btnDeleteSub;
    }
}