
namespace MyStoreWinApp
{
    partial class frmStudentManagement
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
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.btnSMajor = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Location = new System.Drawing.Point(34, 179);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.RowHeadersWidth = 51;
            this.dgvStudentList.RowTemplate.Height = 29;
            this.dgvStudentList.Size = new System.Drawing.Size(1188, 259);
            this.dgvStudentList.TabIndex = 0;
            this.dgvStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentList_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(34, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSName
            // 
            this.btnSName.Location = new System.Drawing.Point(327, 54);
            this.btnSName.Name = "btnSName";
            this.btnSName.Size = new System.Drawing.Size(116, 29);
            this.btnSName.TabIndex = 3;
            this.btnSName.Text = "Search Name";
            this.btnSName.UseVisualStyleBackColor = true;
            this.btnSName.Click += new System.EventHandler(this.btnSName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(458, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(458, 105);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(155, 27);
            this.txtMajor.TabIndex = 5;
            // 
            // btnSMajor
            // 
            this.btnSMajor.Location = new System.Drawing.Point(327, 105);
            this.btnSMajor.Name = "btnSMajor";
            this.btnSMajor.Size = new System.Drawing.Size(116, 29);
            this.btnSMajor.TabIndex = 6;
            this.btnSMajor.Text = "Search Major";
            this.btnSMajor.UseVisualStyleBackColor = true;
            this.btnSMajor.Click += new System.EventHandler(this.btnSMajor_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(34, 132);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSMajor);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStudentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentManagement";
            this.Load += new System.EventHandler(this.frmStudentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Button btnSMajor;
        private System.Windows.Forms.Button btnLoad;
    }
}