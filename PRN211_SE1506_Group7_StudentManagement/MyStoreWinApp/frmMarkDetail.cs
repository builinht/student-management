﻿using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMarkDetail : Form
    {
        public frmMarkDetail()
        {
            InitializeComponent();
        }

        public IMarkRepository MarkRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MarkObject MarkInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAssignment.Text.Equals("") ||
                    txtFinal.Text.Equals("") ||
                    txtPractical.Text.Equals("") ||
                    txtStudentID.Text.Equals(""))
                {
                    MessageBox.Show("Missing input !", "Error");
                }
                else if (!Regex.Match(txtAssignment.Text, "^([0-9]|10)$").Success)
                {
                    MessageBox.Show("Invalid assignment grade", "Message");
                    txtAssignment.Focus();
                    return;
                }
                else if (!Regex.Match(txtFinal.Text, "^([0-9]|10)$").Success)
                {
                    MessageBox.Show("Invalid final grade", "Message");
                    txtFinal.Focus();
                    return;
                }
                else if (!Regex.Match(txtPractical.Text, "^([0-9]|10)$").Success)
                {
                    MessageBox.Show("Invalid practical grade", "Message");
                    txtPractical.Focus();
                    return;
                }
                else
                {
                    var mark = new MarkObject
                    {
                        courseID = int.Parse(cboCourseID.Text),
                        studentID = txtStudentID.Text,
                        Assignment = double.Parse(txtAssignment.Text),
                        Practical = double.Parse(txtPractical.Text),
                        Final = double.Parse(txtFinal.Text)
                    };
                    if (InsertOrUpdate == false)
                    {
                        MarkRepository.InsertMark(mark);
                    }
                    else
                    {
                        MarkRepository.UpdateMark(mark);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new mark" : "Update mark");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmMarkDetail_Load(object sender, EventArgs e)
        {
            cboCourseID.SelectedIndex = 0;
            txtStudentID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                cboCourseID.Text = MarkInfo.courseID.ToString();
                txtStudentID.Text = MarkInfo.studentID;
                txtAssignment.Text = MarkInfo.Assignment.ToString();
                txtPractical.Text = MarkInfo.Practical.ToString();
                txtFinal.Text = MarkInfo.Final.ToString();
            }
        }
    }
}
