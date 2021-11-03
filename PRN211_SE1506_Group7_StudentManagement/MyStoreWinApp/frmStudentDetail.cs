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
    public partial class frmStudentDetail : Form
    {
        public frmStudentDetail()
        {
            InitializeComponent();
        }
        public IStudentRepository StudentRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public StudentObject StudentInfo { get; set; }
        private void frmStudentDetail_Load(object sender, EventArgs e)
        {
            txtStudentID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtStudentID.Text = StudentInfo.StudentID.ToString();
                txtName.Text = StudentInfo.StudentName.ToString();
                dtpBirthdate.Text = StudentInfo.BirthDate.ToString();
                cboGender.SelectedItem = StudentInfo.StudentGender.ToString();
                txtAddress.Text = StudentInfo.StudentAddress.ToString();
                txtPhone.Text = StudentInfo.StudentPhone.ToString();
                txtEmail.Text = StudentInfo.StudentEmail.ToString();
                txtBirthPlace.Text = StudentInfo.BirthPlace.ToString();
                txtMajor.Text = StudentInfo.MajorId.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Equals("") || 
                txtAddress.Text.Equals("") || 
                txtPhone.Text.Equals("") || 
                txtEmail.Text.Equals("") || 
                txtBirthPlace.Text.Equals("")||
                txtMajor.Text.Equals(""))
            {
                MessageBox.Show("Missing input !", "Error");
            }
            else
            {
                try
                {
                    var gender = 0;
                    if (cboGender.SelectedItem == "Male")
                    {
                        gender = 1;
                    }
                    else { gender = 2; }
                    var student = new StudentObject
                    {
                        StudentID = txtStudentID.Text,
                        StudentName = txtName.Text,
                        BirthDate = dtpBirthdate.Value,
                        StudentGender = gender,
                        StudentAddress = txtAddress.Text,
                        StudentPhone = txtPhone.Text,
                        StudentEmail = txtEmail.Text,
                        BirthPlace = txtBirthPlace.Text,
                        MajorId = txtMajor.Text
                    };
                    if(InsertOrUpdate == false)
                    {
                        StudentRepository.InsertStudent(student);
                    }
                    else
                    {
                        StudentRepository.UpdateStudent(student);
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new student" : "Update student");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
        
        
    }
}
