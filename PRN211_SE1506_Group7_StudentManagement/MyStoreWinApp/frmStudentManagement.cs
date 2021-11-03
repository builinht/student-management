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
    public partial class frmStudentManagement : Form
    {
        StudentRepository studentRepository = new StudentRepository();
        BindingSource source;
        StudentObject student;
        public frmStudentManagement(StudentObject student)
        {
            InitializeComponent();
            List<StudentObject> students = new List<StudentObject>();
        }
        public void LoadStudentList()
        {
            List<StudentObject> students = new List<StudentObject>();
            students = (List<StudentObject>)studentRepository.GetStudents();
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            try
            {
                source = new BindingSource();
                source.DataSource = students;
                dgvStudentList.DataSource = null;
                dgvStudentList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load student");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var students = GetStudentObject();
                studentRepository.DeleteStudent(students.StudentID);
                LoadStudentList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete student");
            }
        }
        private StudentObject GetStudentObject()
        {
            StudentObject student = (StudentObject)dgvStudentList.CurrentRow.DataBoundItem;
            return student;
        }

        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStudentDetail frm = new frmStudentDetail
            {
                Text = "Update student",
                InsertOrUpdate = true,
                StudentInfo = GetStudentObject(),
                StudentRepository = studentRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //student = studentRepository.GetStudentByID(student.StudentID);
                LoadStudentList();
                source.Position = source.Count - 1;
            }
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStudentDetail frm = new frmStudentDetail
            {
                Text = "Add Student",
                InsertOrUpdate = false,
                StudentRepository = studentRepository
            };
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadStudentList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSName_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Missing input !", "Error");
            }
            else
            {
                List<StudentObject> list = (List<StudentObject>)studentRepository.GetStudents();
                list = list.Where(pro => pro.StudentName.ToString().Contains(txtName.Text)).ToList();
                try
                {
                    source = new BindingSource();
                    source.DataSource = list;
                    dgvStudentList.DataSource = null;
                    dgvStudentList.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Student");
                }
            }
        }

        private void btnSMajor_Click(object sender, EventArgs e)
        {
            if (txtMajor.Text.Equals(""))
            {
                MessageBox.Show("Missing input !", "Error");
            }
            else
            {
                List<StudentObject> list = (List<StudentObject>)studentRepository.GetStudents();
                list = list.Where(pro => pro.MajorId.ToString().Contains(txtMajor.Text)).ToList();
                try
                {
                    source = new BindingSource();
                    source.DataSource = list;
                    dgvStudentList.DataSource = null;
                    dgvStudentList.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Student");
                }
            }
        }
    }
}