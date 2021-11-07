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
        SubjectObject subject;

        public frmSubject()
        {
            InitializeComponent();
            List<SubjectObject> subjects = new List<SubjectObject>();
        }

        public void LoadSubjectList()
        {
            List<SubjectObject> subjects = new List<SubjectObject>();
            subjects = (List<SubjectObject>)subjectRepository.GetSubjects();
            btnDeleteSub.Enabled = true;
            btnNewSub.Enabled = true;
            try
            {
                source = new BindingSource();
                source.DataSource = subject;

                txtSubjectID.DataBindings.Clear();
                txtSubjectName.DataBindings.Clear();
                txtMajorID.DataBindings.Clear();

                txtSubjectID.DataBindings.Add("Text", source, "subjectID");
                txtSubjectName.DataBindings.Add("Text", source, "subjectName");
                txtMajorID.DataBindings.Add("Text", source, "major");

                dgvSubjectList.DataSource = null;
                dgvSubjectList.DataSource = source;

                if (subjects.Count() == 0)
                {
                    ClearText();
                    btnDeleteSub.Enabled = false;
                }
                else
                {
                    btnDeleteSub.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load subject");
            }
        }

        private void ClearText()
        {
            txtSubjectID.Text = string.Empty;
            txtSubjectName.Text = string.Empty;
            txtMajorID.Text = string.Empty;
        }


        private void btnLoadSub_Click(object sender, EventArgs e)
        {
            LoadSubjectList();
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            try
            {
                var subjects = GetSubjectObject();
                subjectRepository.DeleteSubject(subject.SubjectID);
                LoadSubjectList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete subject");
            }
        }
        private SubjectObject GetSubjectObject()
        {
            SubjectObject subject = (SubjectObject)dgvSubjectList.CurrentRow.DataBoundItem;
            return subject;
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            btnDeleteSub.Enabled = false;
            btnNewSub.Enabled = false;
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
    }
}
