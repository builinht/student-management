﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject;

namespace MyStoreWinApp
{
    public partial class frmSubject : Form
    {

        SubjectRepository subjectRepository = new SubjectRepository();
        BindingSource source;
        SubjectObject subject;

        public frmSubject(SubjectObject subject)
        {
            InitializeComponent();
            List<SubjectObject> subjects = new List<SubjectObject>();
        }

        public void LoadSubjectList()
        {
            List<SubjectObject> subjects = new List<SubjectObject>();
            subjects = (List<SubjectObject>)subjectRepository.GetSubjects();
            btnDeleteSubject.Enabled = true;
            btnNewSubject.Enabled = true;
            try
            {
                source = new BindingSource();
                source.DataSource = subject;
                dgvSubject.DataSource = null;
                dgvSubject.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load subject");
            }
        }

        private void btnLoadSubject_Click(object sender, EventArgs e)
        {
            LoadSubjectList();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                var subjects = GetSubjectObject();
                subjectRepository.DeleteSubject(subject.SubjectID);
                LoadSubjectList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete subject");
            }
        }
        private SubjectObject GetSubjectObject()
        {
            SubjectObject subject = (SubjectObject)dgvSubject.CurrentRow.DataBoundItem;
            return subject;
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            btnDeleteSubject.Enabled = false;
            btnNewSubject.Enabled = false;
        }
    }
}