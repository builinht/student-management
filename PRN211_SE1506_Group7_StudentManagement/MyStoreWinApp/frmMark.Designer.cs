
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
            this.lbPractical = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.txtPractical = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.dgvMark = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMark)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(65, 69);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(69, 20);
            this.lbCourseID.TabIndex = 0;
            this.lbCourseID.Text = "CourseID";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(65, 119);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(75, 20);
            this.lbStudentID.TabIndex = 1;
            this.lbStudentID.Text = "StudentID";
            // 
            // lbAssignment
            // 
            this.lbAssignment.AutoSize = true;
            this.lbAssignment.Location = new System.Drawing.Point(407, 76);
            this.lbAssignment.Name = "lbAssignment";
            this.lbAssignment.Size = new System.Drawing.Size(86, 20);
            this.lbAssignment.TabIndex = 2;
            this.lbAssignment.Text = "Assignment";
            // 
            // lbPractical
            // 
            this.lbPractical.AutoSize = true;
            this.lbPractical.Location = new System.Drawing.Point(407, 122);
            this.lbPractical.Name = "lbPractical";
            this.lbPractical.Size = new System.Drawing.Size(65, 20);
            this.lbPractical.TabIndex = 3;
            this.lbPractical.Text = "Practical";
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Location = new System.Drawing.Point(407, 173);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(40, 20);
            this.lbFinal.TabIndex = 4;
            this.lbFinal.Text = "Final";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(151, 69);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(125, 27);
            this.txtCourseID.TabIndex = 6;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(151, 119);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(125, 27);
            this.txtStudentID.TabIndex = 7;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(511, 73);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(125, 27);
            this.txtAssignment.TabIndex = 8;
            // 
            // txtPractical
            // 
            this.txtPractical.Location = new System.Drawing.Point(511, 119);
            this.txtPractical.Name = "txtPractical";
            this.txtPractical.Size = new System.Drawing.Size(125, 27);
            this.txtPractical.TabIndex = 9;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(511, 166);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(125, 27);
            this.txtFinal.TabIndex = 10;
            // 
            // dgvMark
            // 
            this.dgvMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMark.Location = new System.Drawing.Point(37, 277);
            this.dgvMark.Name = "dgvMark";
            this.dgvMark.ReadOnly = true;
            this.dgvMark.RowHeadersWidth = 51;
            this.dgvMark.RowTemplate.Height = 29;
            this.dgvMark.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMark.Size = new System.Drawing.Size(721, 188);
            this.dgvMark.TabIndex = 12;
            this.dgvMark.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMark_CellDoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(65, 223);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(529, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(343, 489);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvMark);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtPractical);
            this.Controls.Add(this.txtAssignment);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.lbPractical);
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
        private System.Windows.Forms.Label lbPractical;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.TextBox txtPractical;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.DataGridView dgvMark;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}