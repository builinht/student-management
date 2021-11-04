
namespace MyStoreWinApp
{
    partial class frmMark
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
            this.lbAssignment = new System.Windows.Forms.Label();
            this.lbPratical = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.Label();
            this.lbGPA = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.txtPractical = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.dgvMark = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cboCourseID = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMark)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(126, 92);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(69, 20);
            this.lbCourseID.TabIndex = 0;
            this.lbCourseID.Text = "CourseID";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(120, 136);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(75, 20);
            this.lbStudentID.TabIndex = 1;
            this.lbStudentID.Text = "StudentID";
            // 
            // lbAssignment
            // 
            this.lbAssignment.AutoSize = true;
            this.lbAssignment.Location = new System.Drawing.Point(120, 187);
            this.lbAssignment.Name = "lbAssignment";
            this.lbAssignment.Size = new System.Drawing.Size(86, 20);
            this.lbAssignment.TabIndex = 2;
            this.lbAssignment.Text = "Assignment";
            // 
            // lbPratical
            // 
            this.lbPratical.AutoSize = true;
            this.lbPratical.Location = new System.Drawing.Point(450, 89);
            this.lbPratical.Name = "lbPratical";
            this.lbPratical.Size = new System.Drawing.Size(65, 20);
            this.lbPratical.TabIndex = 3;
            this.lbPratical.Text = "Practical";
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Location = new System.Drawing.Point(450, 136);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(40, 20);
            this.lbFinal.TabIndex = 4;
            this.lbFinal.Text = "Final";
            // 
            // lbGPA
            // 
            this.lbGPA.AutoSize = true;
            this.lbGPA.Location = new System.Drawing.Point(450, 187);
            this.lbGPA.Name = "lbGPA";
            this.lbGPA.Size = new System.Drawing.Size(36, 20);
            this.lbGPA.TabIndex = 5;
            this.lbGPA.Text = "GPA";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(225, 136);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(125, 27);
            this.txtStudentID.TabIndex = 7;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(225, 187);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(125, 27);
            this.txtAssignment.TabIndex = 8;
            // 
            // txtPractical
            // 
            this.txtPractical.Location = new System.Drawing.Point(532, 89);
            this.txtPractical.Name = "txtPractical";
            this.txtPractical.Size = new System.Drawing.Size(125, 27);
            this.txtPractical.TabIndex = 9;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(532, 136);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(125, 27);
            this.txtFinal.TabIndex = 10;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(532, 187);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(125, 27);
            this.txtGPA.TabIndex = 11;
            // 
            // dgvMark
            // 
            this.dgvMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMark.Location = new System.Drawing.Point(31, 325);
            this.dgvMark.Name = "dgvMark";
            this.dgvMark.RowHeadersWidth = 51;
            this.dgvMark.RowTemplate.Height = 29;
            this.dgvMark.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMark.Size = new System.Drawing.Size(744, 188);
            this.dgvMark.TabIndex = 12;
            this.dgvMark.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMark_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(179, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(511, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(681, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(31, 262);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // cboCourseID
            // 
            this.cboCourseID.FormattingEnabled = true;
            this.cboCourseID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboCourseID.Location = new System.Drawing.Point(225, 92);
            this.cboCourseID.Name = "cboCourseID";
            this.cboCourseID.Size = new System.Drawing.Size(125, 28);
            this.cboCourseID.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(345, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 545);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboCourseID);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMark);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtPractical);
            this.Controls.Add(this.txtAssignment);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lbGPA);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.lbPratical);
            this.Controls.Add(this.lbAssignment);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.lbCourseID);
            this.Name = "frmMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark";
            this.Load += new System.EventHandler(this.frmMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourseID;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbAssignment;
        private System.Windows.Forms.Label lbPratical;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbGPA;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.TextBox txtPractical;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.DataGridView dgvMark;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cboCourseID;
        private System.Windows.Forms.Button btnSave;
    }
}