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

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
                txtGPA.DataBindings.Clear();

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
    }
}
