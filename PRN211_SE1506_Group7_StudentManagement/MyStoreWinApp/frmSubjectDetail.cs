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
            txtSubjectID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtSubjectID.Text = SubjectInfo.subjectID;
                txtMajorID.Text = SubjectInfo.majorID;
                txtSubjectName.Text = SubjectInfo.subjectName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var subject = new SubjectObject
                {
                    subjectID = txtSubjectID.Text,
                    majorID = txtMajorID.Text,
                    subjectName = txtSubjectName.Text,
                };
                if(InsertOrUpdate == false)
                {
                    SubjectRepository.InsertSubject(subject);
                }
                else
                {
                    SubjectRepository.UpdateSubject(subject);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
