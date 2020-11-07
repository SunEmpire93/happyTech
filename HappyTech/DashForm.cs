﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class DashForm : Form
    {
        public DashForm()
        {
            InitializeComponent();
            lbName.Text = Recruiter.GetInstance().GetName();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recruiter.DestroyRecruiInstance();
            LoginForm f1 = new LoginForm();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((rbCV.Checked == true) || (rbInterview.Checked == true) ||
               (rbTinterview.Checked == true) || (rbAC.Checked == true)) && 
               ((tbAName.Text.Length > 0) && (tbAJob.Text.Length > 0) && 
               (tbAEmail.Text.Length > 0)))
            {
                string queryString = Constants.insertApplicant(tbAName.Text, tbAEmail.Text, tbAJob.Text);
                Connection.GetDbConn().CreateCommand(queryString);
                Applicant applicant = new Applicant(tbAName.Text, tbAEmail.Text, tbAJob.Text);
                Applicant.applicants.Add(applicant);
                this.Hide();
                ConfApplDetailsForm f3 = new ConfApplDetailsForm();
                f3.Show();
            }
            else
            {
                lbError.Text = "All the fields must be inserted";
                lbError.Visible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rbAC_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
