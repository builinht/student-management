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
    public partial class frmMajorManagement : Form
    {
        MajorRepository majorRepository = new MajorRepository();
        BindingSource source;
        public frmMajorManagement()
        {
            InitializeComponent();
        }

        public void LoadMajorList()
        {
            var majors = majorRepository.GetMajors();
            try
            {
                source = new BindingSource();
                source.DataSource = majors;

                txtMajorID.DataBindings.Clear();
                txtMajorName.DataBindings.Clear();

                txtMajorID.DataBindings.Add("Text", source, "majorID");
                txtMajorName.DataBindings.Add("Text", source, "majorName");

                dgvMajorList.DataSource = null;
                dgvMajorList.DataSource = source;
                if(majors.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load major list");
            }

        }

        private void ClearText()
        {
            txtMajorID.Text = string.Empty;
            txtMajorName.Text = string.Empty;
        }
        private MajorObject GetMajorObject()
        {
            MajorObject major = null;
            try
            {
                major = new MajorObject
                {
                    majorID = txtMajorID.Text,
                    majorName = txtMajorName.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car");
            }
            return major;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMajorList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMajorDetail frmMajorDetail = new frmMajorDetail
            {
                Text = "Add major",
                InsertOrUpdate = false,
                MajorRepository = majorRepository
            };
            if(frmMajorDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMajorList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    var member = GetMajorObject();
                    majorRepository.DeleteMajor(member.majorID);
                    LoadMajorList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a major");
                }
            }
        }

        private void frmMajorManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMajorList.CellDoubleClick += dgvMajorList_CellDoubleClick;
        }

        private void dgvMajorList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMajorDetail frmMajorDetail = new frmMajorDetail
            {
                Text = "Update major",
                InsertOrUpdate = true,
                MajorInfo = GetMajorObject(),
                MajorRepository = majorRepository
            };
            if(frmMajorDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMajorList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                if (txtSearch.Text.Equals(""))
                {
                    MessageBox.Show("You have not entered!", "Error");
                }
                else
                {
                    List<MajorObject> list = (List<MajorObject>)majorRepository.GetMajors();
                    list = list.FindAll(m => m.majorName.ToLower().ToString().Contains(txtSearch.Text.ToLower()));
                    try
                    {
                        source = new BindingSource();
                        source.DataSource = list;
                        dgvMajorList.DataSource = null;
                        dgvMajorList.DataSource = source;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Search Major");
                    }
                }
            }
            else
            {
                MessageBox.Show("You have not entered!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
            }
        }
    }
}
