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

namespace SalesWinApp
{
    public partial class frmCourseDetail : Form
    {
        public frmCourseDetail()
        {
            InitializeComponent();
        }
        public ItblCourseRepository courseRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public tblCourse CourseInfo { get; set; }
        private void frmCourseDetail_Load(object sender, EventArgs e)
        {
            txtCourseID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtCourseID.Text = CourseInfo.courseID.ToString();
                cboCourseName.Text = CourseInfo.courseName.ToString();
                cboCourseName.Text = CourseInfo.subjectID.ToString();


            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var eugu = cboSubjectID;
            if (txtCourseID.Text.Equals("") || cboCourseName.Text.Equals("") || cboSubjectID.Text.Equals(""))
            {
                MessageBox.Show("Missing input !", "Error");
            }
            else
            {
                try
                {
                    var courses = new tblCourse
                    {
                        courseID = Int32.Parse(txtCourseID.Text),
                        courseName = cboCourseName.Text,
                        subjectID = cboSubjectID.Text

                    };
                    if (InsertOrUpdate == false)
                    {
                        courseRepository.InserttblCourse(courses);
                    }
                    else
                    {
                        courseRepository.UpdatetblCourse(courses);
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new Course" : "Update Course");
                }
            }
        }

       
        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void lbSubjectID_Click(object sender, EventArgs e)
        {

        }
    }
}
