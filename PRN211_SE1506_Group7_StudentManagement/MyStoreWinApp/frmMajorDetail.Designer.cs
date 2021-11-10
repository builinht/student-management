
namespace MyStoreWinApp
{
    partial class frmMajorDetail
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMajorID
            // 
            this.lbMajorID.AutoSize = true;
            this.lbMajorID.Location = new System.Drawing.Point(93, 80);
            this.lbMajorID.Name = "lbMajorID";
            this.lbMajorID.Size = new System.Drawing.Size(67, 20);
            this.lbMajorID.TabIndex = 0;
            this.lbMajorID.Text = "Major ID";
            // 
            // lbMajorName
            // 
            this.lbMajorName.AutoSize = true;
            this.lbMajorName.Location = new System.Drawing.Point(93, 136);
            this.lbMajorName.Name = "lbMajorName";
            this.lbMajorName.Size = new System.Drawing.Size(92, 20);
            this.lbMajorName.TabIndex = 1;
            this.lbMajorName.Text = "Major Name";
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(209, 80);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(125, 27);
            this.txtMajorID.TabIndex = 2;
            // 
            // txtMajorName
            // 
            this.txtMajorName.Location = new System.Drawing.Point(209, 136);
            this.txtMajorName.Name = "txtMajorName";
            this.txtMajorName.Size = new System.Drawing.Size(125, 27);
            this.txtMajorName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(78, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(259, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMajorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 322);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMajorName);
            this.Controls.Add(this.txtMajorID);
            this.Controls.Add(this.lbMajorName);
            this.Controls.Add(this.lbMajorID);
            this.Name = "frmMajorDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMajorDetail";
            this.Load += new System.EventHandler(this.frmMajorDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMajorID;
        private System.Windows.Forms.Label lbMajorName;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.TextBox txtMajorName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}