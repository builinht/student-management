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
    public partial class frmCourseManagement : Form
    {
        ICourseRepository courseRepository = new CourseRepository();
        BindingSource source;
        public frmCourseManagement()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCourseList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCourseDetail frmCourseDetail = new frmCourseDetail
            {
                Text = "Add course",
                InsertOrUpdate = false,
                CourseRepository = courseRepository
            };
            if(frmCourseDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCourseList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    var course = GetCourseObject();
                    courseRepository.DeleteCourse(course.courseID);
                    LoadCourseList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a course");
                }
            }
        }

        private void frmCourseManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvCourseList.CellDoubleClick += dgvCourseList_CellDoubleClick;
        }

        private void ClearText()
        {
            txtCourseID.Text = string.Empty;
            txtSubjectID.Text = string.Empty;
            txtCourseName.Text = string.Empty;
        }

        private CourseObject GetCourseObject()
        {
            CourseObject course = null;
            try
            {
                course = new CourseObject
                {
                    courseID = int.Parse(txtCourseID.Text),
                    subjectID = txtSubjectID.Text,
                    courseName = txtCourseName.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get course");
            }
            return course;
        }

        private void LoadCourseList()
        {
            var courses = courseRepository.GetCourses();
            try
            {
                source = new BindingSource();
                source.DataSource = courses;

                txtCourseID.DataBindings.Clear();
                txtSubjectID.DataBindings.Clear();
                txtCourseName.DataBindings.Clear();

                txtCourseID.DataBindings.Add("Text", source, "courseID");
                txtSubjectID.DataBindings.Add("Text", source, "subjectID");
                txtCourseName.DataBindings.Add("Text", source, "courseName");

                dgvCourseList.DataSource = null;
                dgvCourseList.DataSource = source;
                if(courses.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load course list");
            }
        }

        private void dgvCourseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCourseDetail frmCourseDetail = new frmCourseDetail
            {
                Text = "Update course",
                InsertOrUpdate = true,
                CourseInfo = GetCourseObject(),
                CourseRepository = courseRepository
            };
            if(frmCourseDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCourseList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                if (txtCourseName.Text.Equals(""))
                {
                    MessageBox.Show("You have not entered!", "Error");
                }
                else
                {
                    List<CourseObject> list = (List<CourseObject>)courseRepository.GetCourses();
                    list = list.FindAll(m => m.courseName.ToLower().ToString().Contains(txtCourseName.Text.ToLower()));
                    try
                    {
                        source = new BindingSource();
                        source.DataSource = list;
                        dgvCourseList.DataSource = null;
                        dgvCourseList.DataSource = source;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Search Course");
                    }
                }
            }
            else
            {
                MessageBox.Show("You have not entered!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseName.Focus();   
            }
        }
    }
}
