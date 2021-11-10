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
    public partial class frmCourseDetail : Form
    {
        public frmCourseDetail()
        {
            InitializeComponent();
        }

        public ICourseRepository CourseRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public CourseObject CourseInfo { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var course = new CourseObject
                {
                    courseID = int.Parse(txtCourseID.Text),
                    subjectID = cboSubjectID.Text,
                    courseName = txtCourseName.Text
                };
                if (InsertOrUpdate == false)
                {
                    CourseRepository.InsertCourse(course);
                }
                else
                {
                    CourseRepository.UpdateCourse(course);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new course" : "Update a course");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void CourseDetail_Load(object sender, EventArgs e)
        {
            cboSubjectID.SelectedIndex = 0;
            txtCourseID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtCourseID.Text = CourseInfo.courseID.ToString();
                cboSubjectID.Text = CourseInfo.subjectID.Trim();
                txtCourseName.Text = CourseInfo.courseName;
            }
        }
    }
}
