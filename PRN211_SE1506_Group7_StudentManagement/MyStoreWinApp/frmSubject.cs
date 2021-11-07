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
    public partial class frmSubject : Form
    {
        SubjectRepository subjectRepository = new SubjectRepository();
        BindingSource source;
        
        public frmSubject()
        {
            InitializeComponent();
        }

        public void LoadSubjectList()
        {
            var subjects = subjectRepository.GetSubjects();
            try
            {
                source = new BindingSource();
                source.DataSource = subjects;

                txtSubjectID.DataBindings.Clear();
                txtMajorID.DataBindings.Clear();
                txtSubjectName.DataBindings.Clear();

                txtSubjectID.DataBindings.Add("Text", source, "subjectID");
                txtMajorID.DataBindings.Add("Text", source, "majorID");
                txtSubjectName.DataBindings.Add("Text", source, "subjectName");

                dgvSubjectList.DataSource = null;
                dgvSubjectList.DataSource = source;
                if(subjects.Count() == 0)
                {
                    ClearTetx();
                    btnDeleteSub.Enabled = false;
                }
                else
                {
                    btnDeleteSub.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load subject list");
            }
        }

        private void btnLoadSub_Click(object sender, EventArgs e)
        {
            LoadSubjectList();
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    var subject = GetSubjectObject();
                    subjectRepository.DeleteSubject(subject.subjectID);
                    LoadSubjectList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a subject");
                }
            }
        }
        private SubjectObject GetSubjectObject()
        {
            SubjectObject subject = null;
            try
            {
                subject = new SubjectObject
                {
                    subjectID = txtSubjectID.Text,
                    subjectName = txtSubjectName.Text,
                    majorID = txtMajorID.Text
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Get subject");
            }
            return subject;
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            btnDeleteSub.Enabled = false;
            dgvSubjectList.CellDoubleClick += dgvSubjectList_CellDoubleClick;
        }

        private void dgvSubjectList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSubjectDetail frm = new frmSubjectDetail
            {
                Text = "Update subject",
                InsertOrUpdate = true,
                SubjectInfo = GetSubjectObject(),
                SubjectRepository = subjectRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            { 
                LoadSubjectList();
                source.Position = source.Count - 1;
            }
        }

        private void btnNewSub_Click(object sender, EventArgs e)
        {
            frmSubjectDetail frm = new frmSubjectDetail
            {
                Text = "Add Subject",
                InsertOrUpdate = false,
                SubjectRepository = subjectRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadSubjectList();
                source.Position = source.Count - 1;
            }
        }

        private void ClearTetx()
        {
            txtSubjectID.Text = string.Empty;
            txtSubjectName.Text = string.Empty;
            txtMajorID.Text = string.Empty;
        }
    }
}
