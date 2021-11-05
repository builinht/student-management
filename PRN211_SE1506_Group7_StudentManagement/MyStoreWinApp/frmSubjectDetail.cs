using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject;

namespace MyStoreWinApp
{
    public partial class frmSubjectDetail : Form
    {
        public frmSubjectDetail()
        {
            InitializeComponent();
        }

        public ISubjectRepository SubjectRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public SubjectObject SubjectInfo { get; set; }

        private void frmSubjectDetail_Load(object sender, EventArgs e)
        {
            cboSubjectID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtSubjectName.Text = SubjectInfo.SubjectName.ToString();
                txtMajorID.Text = SubjectInfo.MajorID.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text.Equals("") ||
                txtMajorID.Text.Equals(""))
            {
                MessageBox.Show("Missing input !", "Error");
            }
            else
            {
                try
                {
                    var subject = new SubjectObject
                    {
                        SubjectName = txtSubjectName.Text,                  
                        MajorID = txtMajorID.Text
                    };
                    if (InsertOrUpdate == false)
                    {
                        SubjectRepository.InsertSubject(subject);
                    }
                    else
                    {
                        SubjectRepository.UpdateSubject(subject);
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new subject" : "Update subject");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
