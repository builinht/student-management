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
    public partial class frmMajor : Form
    {
        public IMajorRepository tblMajorRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MajorObject MajorInfo { get; set; }
        public frmMajor()
        {
            InitializeComponent();
        }

        private void frmMajor_Load(object sender, EventArgs e)
        {
            cboMajorID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                cboMajorID.Text = MajorInfo.MajorId.ToString();
                cboMajorName.Text = MajorInfo.NameMajor.ToString();
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var eugu = cboMajorID;
            if (cboMajorID.Text.Equals("") || cboMajorName.Text.Equals("") )
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
                        tblMajorRepository.InserttblMajor(majors);
                    }
                    else
                    {
                        tblMajorRepository.UpdatetblMajor(majors);
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
    }
}
