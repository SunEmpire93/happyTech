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
using System.IO;

namespace HappyTech
{
    public partial class EditorForm : Form
    {
        int currentPosition; // holds the position of the templates in the list
        string mode; //this tracks how the editor was generated, either feedback - if form created from dashform
        //or wasn't the last applicant
        //mode is "preview" if a document has been selected to edit from the previewForm
        //used to determine function of back button and is set in the constructors
        string previewAppName;
        

        /// <summary>
        ///  Constructor of the current form
        /// </summary>
        /// <param name="position">holds the current position of the template being showed</param>
        public EditorForm(int position)
        {
            mode = "feedback";
            currentPosition = position; // update the currentPosition
            InitializeComponent();
            loadListBox();

            /* Displays the applicant selected out of all the applicants
             * position + 1 as the iterator starts from 0 to n-1 */
            lbApplicants.Text = $"Applicant {position + 1} of {Applicant.applicants.Count}"; 
            
            // Takes the header of the template in the assigned position in the list
            //lbHeader.Text = Template.templates[position].Header;
            lblRecruiterVal.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            lblAppNameVal.Text = Applicant.applicants[position].AfullName;
            lblAppEmailVal.Text = Applicant.applicants[position].Aemail;
            lblAppJobVal.Text = Applicant.applicants[position].AJob;
            lblAppTempVal.Text = Template.templatesForApplicants[position].TempType;

            if (File.Exists(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + ".rtf"))
            {
                using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + Applicant.applicants[position].AfullName + ".rtf"))
                {
                    //this is supposed to find the saved feedback file and prefill richTextBox2 with the feedback
                    //however, this shows formatting code which is not ideal. formatting does not show if file opened in 
                    //word
                    richTextBox2.Text = sr.ReadToEnd();
                }
            }
        }

        public EditorForm(string applicantName, string appType, string appEmail, string appJob) // takes applicant name + type + email + job from previewForm
        { //As editorForm usually takes an arguement of the applicant's position in the application list
            //this wont work if you are editing one applicant's feedback from the previewForm screen
            //so overloaded constructor is making a specific type of editorform for this purpose
            mode = "preview";
            //currentPosition = Template.templates.Count - 1; //so that next button will always go to prevForm
            previewAppName = applicantName;
            InitializeComponent();
            loadListBox();
            lbApplicants.Text = $"Previewing: {applicantName}";

            //lbHeader.Text = Recruiter.GetInstance().Name + Recruiter.GetInstance().Surname +
            //    applicantName + appType;

            lblRecruiterVal.Text = Recruiter.GetInstance().Name + " " + Recruiter.GetInstance().Surname;
            lblAppNameVal.Text = applicantName;
            lblAppEmailVal.Text = appEmail;
            lblAppJobVal.Text = appJob;
            lblAppTempVal.Text = appType;
            //makes header from recruiter instsnce and passed in applicant details
            //recruiter, app, type
            //Template.templates[position].GetHeader();
            // richTextBox2.Text = read in the text in the saved .rtf filename "recruitername applicantname".rtf


            try
            {
                using (StreamReader sr = new StreamReader(Recruiter.GetInstance().Name + applicantName + ".rtf"))

                {
                    //this is supposed to find the saved feedback file and prefill richTextBox2 with the feedback
                    //however, this shows formatting code which is not ideal. formatting does not show if file opened in 
                    //word
                    richTextBox2.Text = sr.ReadToEnd();
                }
            }
            catch (Exception)
            { 
                // user has the file open

            }

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            
            if (mode == "feedback")
            {
                if (currentPosition > 0)
                {
                    this.Hide();
                    EditorForm f = EditorClass.NextForm("backward", currentPosition);
                    f.Show();
                }
                else if (currentPosition == 0)
                {
                   //  Template.templatesForApplicants.Clear();
                    this.Hide();
                    ConfApplDetailsForm cadf = new ConfApplDetailsForm(false);
                    cadf.Show();
                }
            }
            else if (mode == "preview")
            {
                this.Hide();
                previewForm pf = new previewForm();
                pf.Show();
            }
          
        }

        private void btNext2_Click(object sender, EventArgs e)
        {
            if (mode == "feedback")
            {
                // save template - should be into the Editor Class
                using (StreamWriter sw = new StreamWriter(Recruiter.GetInstance().Name + Applicant.applicants[currentPosition].AfullName + ".rtf"))
                {

                    sw.WriteLine(richTextBox2.Text);
                    if (!(richTextBox1.Text == ""))
                    {
                        sw.WriteLine("\r\nComments:\r\n");
                        sw.WriteLine(richTextBox1.Text);
                    }

                }

                
                if (currentPosition < Template.templatesForApplicants.Count - 1)
                {
                    this.Hide();
                    EditorForm f = EditorClass.NextForm("forward", currentPosition);
                    f.Show();
                }
                else if (currentPosition >= Template.templatesForApplicants.Count - 1)
                {
                    this.Hide();
                    previewForm pf = new previewForm();
                    pf.Show();
                }
            }
            else if (mode == "preview")
            {
                using (StreamWriter sw = new StreamWriter(Recruiter.GetInstance().Name + previewAppName + ".rtf"))
                {

                    sw.WriteLine(richTextBox2.Text);

                }

                this.Hide();
                previewForm pf = new previewForm();
                pf.Show();
            }
            

            

            //saves the feedback doc to debug folder when next button is clicked

           // richTextBox2.SaveFile(Recruiter.GetInstance().Name + Applicant.applicants[currentPosition].AfullName + ".txt");


            
        }
        private void loadListBox()
        {

            listBox.CheckOnClick = true;
            // Code.codeList.Clear();
            // Code.fillCodeList();
            //only populate listbox with codes where
            //section id is in personalsection with selected template
            Sections.listSection();
            //Sections.FillSectionPerTemplate(Template.templatesForApplicants[currentPosition].Id);
            int tempId = Template.templatesForApplicants[currentPosition].Id;
            //have template id so can get personalSection sections
            string psSections = $"SELECT section_ID FROM PersonalSection Where '{tempId}' IN (template_ID)";
            DataSet ds1 = Connection.GetDbConn().getDataSet(psSections);
            DataRow dRow1;
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
               
                //for each section in personal section, need to add all codes
                dRow1 = ds1.Tables[0].Rows[i];
                string sectionId = dRow1.ItemArray.GetValue(0).ToString();
                
                string getCodes = $"SELECT codeShort FROM Codes WHERE sectionNo = '{sectionId}'";
                DataSet ds2 = Connection.GetDbConn().getDataSet(getCodes);
                DataRow dRow2;
                for (int j = 0; j <ds2.Tables[0].Rows.Count; j++)
                {
                    try
                    {
                        dRow2 = ds2.Tables[0].Rows[j];
                        Console.WriteLine(dRow2.ItemArray.GetValue(0).ToString());
                        listBox.Items.Add(dRow2.ItemArray.GetValue(0).ToString());
                        foreach (string code in Applicant.applicants[currentPosition].selectedAppCodes)
                        {
                            if (dRow2.ItemArray.GetValue(0).ToString() == code)
                            {
                                listBox.SetItemChecked(listBox.Items.Count - 1, true);
                            }
                        }
                        
                    }
                    catch { }//just in case there is a section that has no codes attached
                    
                }

               
            }
            

               /* DataSet ds = Connection.GetDbConn().getDataSet()
            for (int i = 0; i < Sections.sectionPerTemplate.Count; i++)
            {
                //Code.codeList[i].GetSectionName().Trim()}:
                //listBox.Items.Add($"{Code.codeList[i].CodeName}");
                listBox.Items.Add($"{Sections.sectionPerTemplate[i].name}");
            }*/

            if (mode == "preview")
            {
                //richTextBox1.Hide();
                //lbComBox.Hide();
                //panel2.Width = 623;
                //richTextBox2.Width = 623;
            }

        }

        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Code.selectedCodes.Clear();
            Applicant.applicants[currentPosition].selectedAppCodes.Clear();
            richTextBox2.Text = "";
            foreach (string code in listBox.CheckedItems)
            {
                //get the code short of the selected list item
                string codeShortLookup = code;
                codeShortLookup = codeShortLookup.Replace(" ", "");
                string query = $"SELECT codeParagraph FROM Codes WHERE codeShort = '{codeShortLookup}'";
                DataSet ds = Connection.GetDbConn().getDataSet(query);
                DataRow dRow = ds.Tables[0].Rows[0];
                //goes to the db, returns the first row (the codeparagraph) stores in variable
                string paragraphToAdd = dRow.ItemArray.GetValue(0).ToString();
                Code.selectedCodes.Add(paragraphToAdd);
                Applicant.applicants[currentPosition].selectedAppCodes.Add(code);
            }

            foreach (string code in Code.selectedCodes)
            {
                richTextBox2.AppendText(code + "\n\n");

            }
        }
    }
}