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

    public partial class frmCourseManagement : Form
    {
        tblCourseRepository courseRepository = new tblCourseRepository();
        BindingSource source;
        tblCourse course;
        public frmCourseManagement()
        {
            InitializeComponent();
        }
        public frmCourseManagement(tblCourse course)
        {
            this.course = course;
            InitializeComponent();
        }
        /// <summary>
        /// ///vô bài xóa đi hàm isAdmin
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
         public bool isAdmin(UserObject member)
        {

            if (member.UserEmail.Contains("@fstore.com"))
            {

                return true;
            }
            else return false;
        }
        
        private void frmCourseManagement_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void LoadCourseList()
        {
            List<tblCourse> courses = new List<tblCourse>();
            courses = (List<tblCourse>)courseRepository.GettblCourses();
            try
            {
                source = new BindingSource();
                source.DataSource = courses;
                dgvCourseList.DataSource = null;
                dgvCourseList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load tblCourse");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCourseList();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }
        private tblCourse GettblCourse()
        {
            tblCourse courses = (tblCourse)dgvCourseList.CurrentRow.DataBoundItem;
            return courses;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                 
                frmCourseDetail frm = new frmCourseDetail
                {
                    Text = "Update Course",
                    InsertOrUpdate = true,
                    CourseInfo = GettblCourse(),
                    courseRepository = courseRepository
                };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCourseList();
                source.Position = source.Count - 1;
            
        }
    }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
                try
                {
                    var course = GettblCourses();
                    courseRepository.DeletetblCourse(course.courseID);
                    LoadCourseList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Course");
                }
            }
        private tblCourse GettblCourses()
        {
            tblCourse course = (tblCourse)dgvCourseList.CurrentRow.DataBoundItem;
            return course;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Missing input !", "Error");
            }
            else
            {
                List<tblCourse> list = (List<tblCourse>)courseRepository.GettblCourses();
                list = list.FindAll(pro => pro.courseName.ToString().Contains(txtSearch.Text));
                try
                {
                    source = new BindingSource();
                    source.DataSource = list;
                    dgvCourseList.DataSource = null;
                    dgvCourseList.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search tblCourse");
                }
            }

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmCourseDetail frm = new frmCourseDetail()
            {
                Text = "Add tblCourse",
                InsertOrUpdate = false,
                courseRepository = courseRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCourseList();
                source.Position = source.Count - 1;
            }
            frm.Show();
        }
    }
}
