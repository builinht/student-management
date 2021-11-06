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
    public partial class frmMajor : Form
    {
        public IMajorRepository MajorRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MajorObject MajorInfo { get; set; }
        public frmMajor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboMajorID.Text.Equals("") || cboMajorName.Text.Equals(""))
            {
                MessageBox.Show("Missing input !", "Error");
            }
            else
            {
                try
                {
                    var majors = new MajorObject
                    {
                        MajorId = cboMajorID.Text,
                        NameMajor = cboMajorName.Text

                    };
                    if (InsertOrUpdate == false)
                    {
                        MajorRepository.InserttblMajor(majors);
                    }
                    else
                    {
                        MajorRepository.UpdatetblMajor(majors);
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new Major" : "Update Major");
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmMajor_Load(object sender, EventArgs e)
        {
            cboMajorID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                cboMajorID.Text = MajorInfo.MajorId.ToString();
                cboMajorName.Text = MajorInfo.NameMajor.ToString();
            }
        }
    }
}
