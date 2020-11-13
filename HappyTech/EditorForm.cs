﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class EditorForm : Form
    {
        int currentPosition;
        string codeDisplay = "{0, -10}{1,-20}";


        public EditorForm(int position)
        {
            currentPosition = position;
            InitializeComponent();
            lbApplicants.Text = "Applicant " + (position + 1).ToString() +
                                " out of " + Applicant.applicants.Count;
            lbHeader.Text = Template.templates[position].GetHeader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditorForm f;
            if (currentPosition > 0)
            {
                f = EditorClass.NextForm(0, currentPosition);
                this.Hide();
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditorForm f;
            if (currentPosition < Template.templates.Count - 1)
            {
                f = EditorClass.NextForm(1, currentPosition);
                this.Hide();
                f.Show();
            }
            else
            {

            }
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {

            checklistAllCodes.Items.Add(String.Format(codeDisplay, "G-EXP", "You have shown a good level of experience."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "B-EXP", "You have shown a poor level of experience."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.Items.Add(String.Format(codeDisplay, "T-EST", "This is a test code. Paragraph to follow."));
            checklistAllCodes.CheckOnClick = true;
            checklistSelectedCodes.CheckOnClick = true;
        }
        private void checklistSelectedCodes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                e.NewValue = CheckState.Checked;
                checklistAllCodes.Items.Add(checklistSelectedCodes.Items[e.Index].ToString());
                checklistSelectedCodes.Items.Remove(checklistSelectedCodes.Items[e.Index]);
                checklistAllCodes.SetItemChecked(checklistAllCodes.Items.Count - 1, false);
            }
        }

        private void checklistAllCodes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
                checklistSelectedCodes.Items.Add(checklistAllCodes.Items[e.Index].ToString());
                checklistAllCodes.Items.Remove(checklistAllCodes.Items[e.Index]);
                checklistSelectedCodes.SetItemChecked(checklistSelectedCodes.Items.Count - 1, true);
            }
        }
    }
}
