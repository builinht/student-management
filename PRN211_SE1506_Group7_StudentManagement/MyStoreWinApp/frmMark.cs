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
    public partial class frmMark : Form
    {
        MarkRepository markRepository = new MarkRepository();
        BindingSource source;
        DataTable dtMark;
        public frmMark()
        {
            InitializeComponent();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvMark_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void cboCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmMark_Load(object sender, EventArgs e)
        {

        }

        
    }
}
