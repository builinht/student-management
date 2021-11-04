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
        MarkRepository markRepository = new MarkRepository();
        BindingSource source;
        public frmMark()
        {
            InitializeComponent();
        }

        private void ShowMark(DataGridView dgv)
        {
            dgv.DataSource = markRepository.GetMarks();
        }

        private void LoadCourseID(ComboBox cbo)
        {
            cbo.DataSource = markRepository.GetMarks();
            cbo.ValueMember = "courseID";
            cbo.DisplayMember = "CourseID";
        }

        private void frmMark_Load(object sender, EventArgs e)
        {
            ShowMark(dgvMark);
            LoadCourseID(cboCourseID);
            lockText();
        }

        private void SetNull()
        {
            cboCourseID.Text = "";
            txtStudentID.Text = "";
            txtAssignment.Text = "";
            txtPractical.Text = "";
            txtFinal.Text = "";
            txtFinal.Text = "";
        }

        private void lockText()
        {
            cboCourseID.Enabled = false;
            txtStudentID.Enabled = false;
            txtAssignment.Enabled = false;
            txtPractical.Enabled = false;
            txtFinal.Enabled = false;
            txtGPA.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void UnlockText()
        {
            cboCourseID.Enabled = true;
            txtStudentID.Enabled = true;
            txtAssignment.Enabled = true;
            txtPractical.Enabled = true;
            txtFinal.Enabled = true;
            txtGPA.Enabled = false;

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        bool add;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetNull();
            add = true;
            UnlockText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(add == true)
            {
                markRepository.InsertMark(int.Parse(cboCourseID.SelectedValue.ToString()), int.Parse(txtStudentID.Text), int.Parse(txtAssignment.Text), int.);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvMark_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
