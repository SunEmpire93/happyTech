﻿namespace HappyTech
{
    partial class DashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLogout = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbHello = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUploadDoc = new System.Windows.Forms.Label();
            this.rbCV = new System.Windows.Forms.RadioButton();
            this.rbTinterview = new System.Windows.Forms.RadioButton();
            this.rbInterview = new System.Windows.Forms.RadioButton();
            this.lbDocType = new System.Windows.Forms.Label();
            this.tbAName = new System.Windows.Forms.TextBox();
            this.lbAName = new System.Windows.Forms.Label();
            this.lbAJob = new System.Windows.Forms.Label();
            this.lbAEmail = new System.Windows.Forms.Label();
            this.tbAJob = new System.Windows.Forms.TextBox();
            this.tbAEmail = new System.Windows.Forms.TextBox();
            this.rbAC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbJobPos = new System.Windows.Forms.Label();
            this.codesViewBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
=======
            this.btBack = new System.Windows.Forms.Button();
>>>>>>> main
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(655, 44);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(80, 24);
            this.btLogout.TabIndex = 0;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // btConfirm
            // 
            this.next.Location = new System.Drawing.Point(614, 349);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 1;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.Location = new System.Drawing.Point(12, 93);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(76, 18);
            this.lbHello.TabIndex = 6;
            this.lbHello.Text = "Welcome,";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(85, 93);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 18);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "[username]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(390, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 158);
            this.panel1.TabIndex = 10;
            // 
            // lbUploadDoc
            // 
            this.lbUploadDoc.AutoSize = true;
            this.lbUploadDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUploadDoc.Location = new System.Drawing.Point(143, 178);
            this.lbUploadDoc.Name = "lbUploadDoc";
            this.lbUploadDoc.Size = new System.Drawing.Size(129, 16);
            this.lbUploadDoc.TabIndex = 11;
            this.lbUploadDoc.Text = "Applicant Details";
            // 
            // rbCV
            // 
            this.rbCV.AutoSize = true;
            this.rbCV.Location = new System.Drawing.Point(482, 229);
            this.rbCV.Name = "rbCV";
            this.rbCV.Size = new System.Drawing.Size(39, 17);
            this.rbCV.TabIndex = 12;
            this.rbCV.TabStop = true;
            this.rbCV.Text = "CV";
            this.rbCV.UseVisualStyleBackColor = true;
            // 
            // rbTinterview
            // 
            this.rbTinterview.AutoSize = true;
            this.rbTinterview.Location = new System.Drawing.Point(590, 260);
            this.rbTinterview.Name = "rbTinterview";
            this.rbTinterview.Size = new System.Drawing.Size(118, 17);
            this.rbTinterview.TabIndex = 13;
            this.rbTinterview.TabStop = true;
            this.rbTinterview.Text = "Technical Interview";
            this.rbTinterview.UseVisualStyleBackColor = true;
            // 
            // rbInterview
            // 
            this.rbInterview.AutoSize = true;
            this.rbInterview.Location = new System.Drawing.Point(482, 260);
            this.rbInterview.Name = "rbInterview";
            this.rbInterview.Size = new System.Drawing.Size(68, 17);
            this.rbInterview.TabIndex = 14;
            this.rbInterview.TabStop = true;
            this.rbInterview.Text = "Interview";
            this.rbInterview.UseVisualStyleBackColor = true;
            // 
            // lbDocType
            // 
            this.lbDocType.AutoSize = true;
            this.lbDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocType.Location = new System.Drawing.Point(507, 178);
            this.lbDocType.Name = "lbDocType";
<<<<<<< HEAD
            this.lbDocType.Size = new System.Drawing.Size(120, 16);
=======
            this.lbDocType.Size = new System.Drawing.Size(114, 16);
>>>>>>> main
            this.lbDocType.TabIndex = 15;
            this.lbDocType.Text = "Template Type";
            // 
            // tbAName
            // 
            this.tbAName.Location = new System.Drawing.Point(130, 228);
            this.tbAName.Name = "tbAName";
            this.tbAName.Size = new System.Drawing.Size(145, 20);
            this.tbAName.TabIndex = 16;
            // 
            // lbAName
            // 
            this.lbAName.AutoSize = true;
            this.lbAName.Location = new System.Drawing.Point(52, 228);
            this.lbAName.Name = "lbAName";
            this.lbAName.Size = new System.Drawing.Size(58, 13);
            this.lbAName.TabIndex = 17;
            this.lbAName.Text = "Full Name*";
            // 
            // lbAJob
            // 
            this.lbAJob.AutoSize = true;
            this.lbAJob.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAJob.Location = new System.Drawing.Point(52, 319);
            this.lbAJob.Name = "lbAJob";
            this.lbAJob.Size = new System.Drawing.Size(68, 13);
            this.lbAJob.TabIndex = 18;
            this.lbAJob.Text = "Job Position*";
            // 
            // lbAEmail
            // 
            this.lbAEmail.AutoSize = true;
            this.lbAEmail.Location = new System.Drawing.Point(52, 276);
            this.lbAEmail.Name = "lbAEmail";
            this.lbAEmail.Size = new System.Drawing.Size(36, 13);
            this.lbAEmail.TabIndex = 19;
            this.lbAEmail.Text = "Email*";
            // 
            // tbAJob
            // 
            this.tbAJob.Location = new System.Drawing.Point(130, 316);
            this.tbAJob.Name = "tbAJob";
            this.tbAJob.Size = new System.Drawing.Size(145, 20);
            this.tbAJob.TabIndex = 20;
            // 
            // tbAEmail
            // 
            this.tbAEmail.Location = new System.Drawing.Point(130, 273);
            this.tbAEmail.Name = "tbAEmail";
            this.tbAEmail.Size = new System.Drawing.Size(145, 20);
            this.tbAEmail.TabIndex = 21;
            // 
            // rbAC
            // 
            this.rbAC.AutoSize = true;
            this.rbAC.Location = new System.Drawing.Point(590, 229);
            this.rbAC.Name = "rbAC";
            this.rbAC.Size = new System.Drawing.Size(115, 17);
            this.rbAC.TabIndex = 22;
            this.rbAC.TabStop = true;
            this.rbAC.Text = "Assessment Centre";
            this.rbAC.UseVisualStyleBackColor = true;
            this.rbAC.CheckedChanged += new System.EventHandler(this.rbAC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "HAPPY-TECH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dashboard";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Maroon;
            this.lbError.Location = new System.Drawing.Point(355, 375);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(75, 13);
            this.lbError.TabIndex = 26;
            this.lbError.Text = "Error Message";
            this.lbError.Visible = false;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(162, 365);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 27;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Visible = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // codesViewBtn
            // 
            this.codesViewBtn.Location = new System.Drawing.Point(547, 117);
            this.codesViewBtn.Name = "codesViewBtn";
            this.codesViewBtn.Size = new System.Drawing.Size(183, 23);
            this.codesViewBtn.TabIndex = 29;
            this.codesViewBtn.Text = "View, add or edit tags and codes";
            this.codesViewBtn.UseVisualStyleBackColor = true;
            this.codesViewBtn.Click += new System.EventHandler(this.codesViewBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.codesViewBtn);
            this.Controls.Add(this.lbJobPos);
            this.Controls.Add(this.comboBox1);
=======
            this.Controls.Add(this.btBack);
>>>>>>> main
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAC);
            this.Controls.Add(this.tbAEmail);
            this.Controls.Add(this.tbAJob);
            this.Controls.Add(this.lbAEmail);
            this.Controls.Add(this.lbAJob);
            this.Controls.Add(this.lbAName);
            this.Controls.Add(this.tbAName);
            this.Controls.Add(this.lbDocType);
            this.Controls.Add(this.rbInterview);
            this.Controls.Add(this.rbTinterview);
            this.Controls.Add(this.rbCV);
            this.Controls.Add(this.lbUploadDoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUploadDoc;
        private System.Windows.Forms.RadioButton rbCV;
        private System.Windows.Forms.RadioButton rbTinterview;
        private System.Windows.Forms.RadioButton rbInterview;
        private System.Windows.Forms.Label lbDocType;
        private System.Windows.Forms.TextBox tbAName;
        private System.Windows.Forms.Label lbAName;
        private System.Windows.Forms.Label lbAJob;
        private System.Windows.Forms.Label lbAEmail;
        private System.Windows.Forms.TextBox tbAJob;
        private System.Windows.Forms.TextBox tbAEmail;
        private System.Windows.Forms.RadioButton rbAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbError;
<<<<<<< HEAD
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbJobPos;
        private System.Windows.Forms.Button codesViewBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
=======
        private System.Windows.Forms.Button btBack;
>>>>>>> main
    }
}