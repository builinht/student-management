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

        private void frmMajorManagement_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void LoadMajorList()
        {
            List<MajorObject> majors = new List<MajorObject>();
            majors = (List<MajorObject>)majorRepository.GettblMajors();
            try
            {
                source = new BindingSource();
                source.DataSource = majors;

                dgvMajorList.DataSource = null;
                dgvMajorList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Major");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMajorList();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }

        private MajorObject GettblMajor()
        {
            MajorObject majors = (MajorObject)dgvMajorList.CurrentRow.DataBoundItem;
            return majors;
        }

        private void dgvMajorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMajor frm = new frmMajor
            {
                Text = "Update Major",
                InsertOrUpdate = true,
                MajorInfo = GettblMajor(),
                MajorRepository = majorRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMajorList();
                source.Position = source.Count - 1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMajor frm = new frmMajor
            {
                Text = "Add Major",
                InsertOrUpdate = false,
                MajorInfo = GettblMajor(),
                MajorRepository = majorRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMajorList();
                source.Position = source.Count - 1;
            }
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var majors = GettblMajor();
                majorRepository.DeletetblMajor(majors.MajorId);
                LoadMajorList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Major");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Missing input !", "Error");
            }
            else
            {
                List<MajorObject> list = (List<MajorObject>)majorRepository.GettblMajors();
                list = list.FindAll(pro => pro.NameMajor.ToString().Contains(txtSearch.Text));
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
    }
}
