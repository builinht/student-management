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
    public partial class frmMajorDetail : Form
    {
        public frmMajorDetail()
        {
            InitializeComponent();
        }

        public IMajorRepository MajorRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MajorObject MajorInfo { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var major = new MajorObject
                {
                    
                    majorID = txtMajorID.Text,
                    majorName = txtMajorName.Text
                };
                if (InsertOrUpdate == false)
                {
                    MajorRepository.InsertMajor(major);
                }
                else
                {
                    MajorRepository.UpdateMajor(major);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new major" : "Update a major");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmMajorDetail_Load(object sender, EventArgs e)
        {
            txtMajorID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtMajorID.Text = MajorInfo.majorID;
                txtMajorName.Text = MajorInfo.majorName;
            }
        }
    }
}
