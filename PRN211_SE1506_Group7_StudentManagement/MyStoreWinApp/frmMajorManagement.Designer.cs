
namespace MyStoreWinApp
{
    partial class frmMajorManagement
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
            this.lbMajorID = new System.Windows.Forms.Label();
            this.lbMajorName = new System.Windows.Forms.Label();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.txtMajorName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMajorList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajorList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMajorID
            // 
            this.lbMajorID.AutoSize = true;
            this.lbMajorID.Location = new System.Drawing.Point(77, 59);
            this.lbMajorID.Name = "lbMajorID";
            this.lbMajorID.Size = new System.Drawing.Size(63, 20);
            this.lbMajorID.TabIndex = 0;
            this.lbMajorID.Text = "MajorID";
            // 
            // lbMajorName
            // 
            this.lbMajorName.AutoSize = true;
            this.lbMajorName.Location = new System.Drawing.Point(77, 123);
            this.lbMajorName.Name = "lbMajorName";
            this.lbMajorName.Size = new System.Drawing.Size(92, 20);
            this.lbMajorName.TabIndex = 1;
            this.lbMajorName.Text = "Major Name";
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(173, 59);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(125, 27);
            this.txtMajorID.TabIndex = 2;
            // 
            // txtMajorName
            // 
            this.txtMajorName.Location = new System.Drawing.Point(173, 120);
            this.txtMajorName.Name = "txtMajorName";
            this.txtMajorName.Size = new System.Drawing.Size(125, 27);
            this.txtMajorName.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(498, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(125, 27);
            this.txtSearch.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(77, 191);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(309, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(529, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(386, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMajorList
            // 
            this.dgvMajorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMajorList.Location = new System.Drawing.Point(60, 252);
            this.dgvMajorList.Name = "dgvMajorList";
            this.dgvMajorList.RowHeadersWidth = 51;
            this.dgvMajorList.RowTemplate.Height = 29;
            this.dgvMajorList.Size = new System.Drawing.Size(563, 174);
            this.dgvMajorList.TabIndex = 9;
            this.dgvMajorList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMajorList_CellDoubleClick);
            // 
            // frmMajorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.dgvMajorList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtMajorName);
            this.Controls.Add(this.txtMajorID);
            this.Controls.Add(this.lbMajorName);
            this.Controls.Add(this.lbMajorID);
            this.Name = "frmMajorManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMajorManagement";
            this.Load += new System.EventHandler(this.frmMajorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMajorID;
        private System.Windows.Forms.Label lbMajorName;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.TextBox txtMajorName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMajorList;
    }
}