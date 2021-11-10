
namespace MyStoreWinApp
{
    partial class frmCourseManagement
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
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCourseList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(89, 69);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(73, 20);
            this.lbCourseID.TabIndex = 0;
            this.lbCourseID.Text = "Course ID";
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Location = new System.Drawing.Point(89, 123);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(77, 20);
            this.lbSubjectID.TabIndex = 1;
            this.lbSubjectID.Text = "Subject ID";
            // 
            // lbCourseName
            // 
            this.lbCourseName.AutoSize = true;
            this.lbCourseName.Location = new System.Drawing.Point(89, 181);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(98, 20);
            this.lbCourseName.TabIndex = 2;
            this.lbCourseName.Text = "Course Name";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(193, 69);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(125, 27);
            this.txtCourseID.TabIndex = 3;
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(193, 123);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(125, 27);
            this.txtSubjectID.TabIndex = 4;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(193, 181);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(125, 27);
            this.txtCourseName.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(497, 123);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(125, 27);
            this.txtSearch.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(99, 231);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(537, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCourseList
            // 
            this.dgvCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseList.Location = new System.Drawing.Point(89, 290);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.RowHeadersWidth = 51;
            this.dgvCourseList.RowTemplate.Height = 29;
            this.dgvCourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseList.Size = new System.Drawing.Size(556, 188);
            this.dgvCourseList.TabIndex = 10;
            this.dgvCourseList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourseList_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(383, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmCourseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 531);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCourseList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lbCourseName);
            this.Controls.Add(this.lbSubjectID);
            this.Controls.Add(this.lbCourseID);
            this.Name = "frmCourseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseManagement";
            this.Load += new System.EventHandler(this.frmCourseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourseID;
        private System.Windows.Forms.Label lbSubjectID;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.Button btnSearch;
    }
}