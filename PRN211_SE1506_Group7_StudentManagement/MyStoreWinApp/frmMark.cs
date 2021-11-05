using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMark : Form
    {
        IMarkRepository markRepository = new MarkRepository();
        BindingSource source;
        public frmMark()
        {
            InitializeComponent();
        }

        private void frmMark_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMark.CellDoubleClick += dgvMark_CellDoubleClick;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMarkList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMarkDetail frmMarkDetail = new frmMarkDetail
            {
                Text = "Add mark",
                InsertOrUpdate = false,
                MarkRepository = markRepository
            };
            if(frmMarkDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMarkList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    var mark = GetMarkObject();
                    markRepository.DeleteMark(mark.courseID, mark.studentID);
                    LoadMarkList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete mark");
                }
            }
        }

        private MarkObject GetMarkObject()
        {
            MarkObject mark = null;
            try
            {
                mark = new MarkObject
                {
                    courseID = int.Parse(txtCourseID.Text),
                    studentID = txtStudentID.Text,
                    Assignment = double.Parse(txtAssignment.Text),
                    Practical = double.Parse(txtPractical.Text),
                    Final = double.Parse(txtFinal.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get mark");
            }
            return mark;
        }
        public void LoadMarkList()
        {
            var marks = markRepository.GetMarks();
            try
            {
                source = new BindingSource();
                source.DataSource = marks;

                txtCourseID.DataBindings.Clear();
                txtStudentID.DataBindings.Clear();
                txtAssignment.DataBindings.Clear();
                txtPractical.DataBindings.Clear();
                txtFinal.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "courseID");
                txtStudentID.DataBindings.Add("Text", source, "studentID");
                txtAssignment.DataBindings.Add("Text", source, "Assignment");
                txtPractical.DataBindings.Add("Text", source, "Practical");
                txtFinal.DataBindings.Add("Text", source, "Final");

                dgvMark.DataSource = null;
                dgvMark.DataSource = source;
                if (marks.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load mark list");
            }
        }

        private void ClearText()
        {
            txtCourseID.Text = string.Empty;
            txtStudentID.Text = string.Empty;
            txtAssignment.Text = string.Empty;
            txtPractical.Text = string.Empty;
            txtFinal.Text = string.Empty;
        }

        private void dgvMark_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMarkDetail frmMarkDetail = new frmMarkDetail
            {
                Text = "Update mark",
                InsertOrUpdate = true,
                MarkInfo = GetMarkObject(),
                MarkRepository = markRepository
            };
            if(frmMarkDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMarkList();
                source.Position = source.Count - 1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
