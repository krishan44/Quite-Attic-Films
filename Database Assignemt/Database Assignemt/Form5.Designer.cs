namespace Database_Assignemt
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.BtnPrv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCat = new System.Windows.Forms.GroupBox();
            this.rbnVoice = new System.Windows.Forms.RadioButton();
            this.rbnAct = new System.Windows.Forms.RadioButton();
            this.rbnPro = new System.Windows.Forms.RadioButton();
            this.rbnCam = new System.Windows.Forms.RadioButton();
            this.rbnStaff = new System.Windows.Forms.RadioButton();
            this.textSID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textFname = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPID = new System.Windows.Forms.ComboBox();
            this.cmbSID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCon = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPrv
            // 
            this.BtnPrv.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrv.BackgroundImage = global::Database_Assignemt.Properties.Resources.Graphicloads_Polygon_Previous_41;
            this.BtnPrv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrv.FlatAppearance.BorderSize = 0;
            this.BtnPrv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrv.Location = new System.Drawing.Point(49, 551);
            this.BtnPrv.Name = "BtnPrv";
            this.BtnPrv.Size = new System.Drawing.Size(89, 65);
            this.BtnPrv.TabIndex = 17;
            this.BtnPrv.UseVisualStyleBackColor = false;
            this.BtnPrv.Click += new System.EventHandler(this.BtnPrv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Management";
            // 
            // grpCat
            // 
            this.grpCat.Controls.Add(this.rbnVoice);
            this.grpCat.Controls.Add(this.rbnAct);
            this.grpCat.Controls.Add(this.rbnPro);
            this.grpCat.Controls.Add(this.rbnCam);
            this.grpCat.Controls.Add(this.rbnStaff);
            this.grpCat.Location = new System.Drawing.Point(389, 291);
            this.grpCat.Name = "grpCat";
            this.grpCat.Size = new System.Drawing.Size(279, 145);
            this.grpCat.TabIndex = 2;
            this.grpCat.TabStop = false;
            // 
            // rbnVoice
            // 
            this.rbnVoice.AutoSize = true;
            this.rbnVoice.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnVoice.Location = new System.Drawing.Point(20, 112);
            this.rbnVoice.Name = "rbnVoice";
            this.rbnVoice.Size = new System.Drawing.Size(128, 27);
            this.rbnVoice.TabIndex = 11;
            this.rbnVoice.TabStop = true;
            this.rbnVoice.Text = "Voice Actor";
            this.rbnVoice.UseVisualStyleBackColor = true;
            // 
            // rbnAct
            // 
            this.rbnAct.AutoSize = true;
            this.rbnAct.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAct.Location = new System.Drawing.Point(156, 74);
            this.rbnAct.Name = "rbnAct";
            this.rbnAct.Size = new System.Drawing.Size(75, 27);
            this.rbnAct.TabIndex = 10;
            this.rbnAct.TabStop = true;
            this.rbnAct.Text = "Actor";
            this.rbnAct.UseVisualStyleBackColor = true;
            // 
            // rbnPro
            // 
            this.rbnPro.AutoSize = true;
            this.rbnPro.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPro.Location = new System.Drawing.Point(20, 74);
            this.rbnPro.Name = "rbnPro";
            this.rbnPro.Size = new System.Drawing.Size(115, 27);
            this.rbnPro.TabIndex = 9;
            this.rbnPro.TabStop = true;
            this.rbnPro.Text = "Productor";
            this.rbnPro.UseVisualStyleBackColor = true;
            // 
            // rbnCam
            // 
            this.rbnCam.AutoSize = true;
            this.rbnCam.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCam.Location = new System.Drawing.Point(108, 29);
            this.rbnCam.Name = "rbnCam";
            this.rbnCam.Size = new System.Drawing.Size(151, 27);
            this.rbnCam.TabIndex = 8;
            this.rbnCam.TabStop = true;
            this.rbnCam.Text = "Camera Crew";
            this.rbnCam.UseVisualStyleBackColor = true;
            // 
            // rbnStaff
            // 
            this.rbnStaff.AutoSize = true;
            this.rbnStaff.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnStaff.Location = new System.Drawing.Point(20, 29);
            this.rbnStaff.Name = "rbnStaff";
            this.rbnStaff.Size = new System.Drawing.Size(70, 27);
            this.rbnStaff.TabIndex = 7;
            this.rbnStaff.TabStop = true;
            this.rbnStaff.Text = "Staff";
            this.rbnStaff.UseVisualStyleBackColor = true;
            // 
            // textSID
            // 
            this.textSID.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSID.Location = new System.Drawing.Point(31, 118);
            this.textSID.Name = "textSID";
            this.textSID.Size = new System.Drawing.Size(144, 23);
            this.textSID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Staff ID";
            // 
            // textLname
            // 
            this.textLname.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLname.Location = new System.Drawing.Point(295, 203);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(221, 23);
            this.textLname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(291, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // textNIC
            // 
            this.textNIC.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNIC.Location = new System.Drawing.Point(126, 263);
            this.textNIC.MaxLength = 12;
            this.textNIC.Name = "textNIC";
            this.textNIC.Size = new System.Drawing.Size(221, 23);
            this.textNIC.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(46, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // textFname
            // 
            this.textFname.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFname.Location = new System.Drawing.Point(31, 203);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(221, 23);
            this.textFname.TabIndex = 2;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(127, 327);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(221, 23);
            this.textEmail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(27, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(394, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(282, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Production ID";
            // 
            // cmbPID
            // 
            this.cmbPID.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPID.FormattingEnabled = true;
            this.cmbPID.Location = new System.Drawing.Point(286, 118);
            this.cmbPID.Name = "cmbPID";
            this.cmbPID.Size = new System.Drawing.Size(144, 24);
            this.cmbPID.TabIndex = 15;
            // 
            // cmbSID
            // 
            this.cmbSID.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSID.FormattingEnabled = true;
            this.cmbSID.Location = new System.Drawing.Point(50, 117);
            this.cmbSID.Name = "cmbSID";
            this.cmbSID.Size = new System.Drawing.Size(144, 24);
            this.cmbSID.TabIndex = 16;
            this.cmbSID.SelectedIndexChanged += new System.EventHandler(this.cmbSID_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(27, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Contact Number";
            // 
            // textCon
            // 
            this.textCon.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCon.Location = new System.Drawing.Point(31, 428);
            this.textCon.MaxLength = 10;
            this.textCon.Name = "textCon";
            this.textCon.Size = new System.Drawing.Size(221, 23);
            this.textCon.TabIndex = 6;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Database_Assignemt.Properties.Resources.Graphicloads_100_Flat_2_Arrow_next_256;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(700, 542);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 65);
            this.btnNext.TabIndex = 16;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Database_Assignemt.Properties.Resources.Custom_Icon_Design_Flatastic_2_Data_add_256;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(700, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 65);
            this.btnSave.TabIndex = 12;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = global::Database_Assignemt.Properties.Resources.Flat_Icons_com_Flat_Pencil_256;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(700, 263);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(89, 65);
            this.btnUp.TabIndex = 14;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundImage = global::Database_Assignemt.Properties.Resources.Graphicloads_Long_Shadow_Documents_Document_remove_256;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(700, 384);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(89, 65);
            this.btnDel.TabIndex = 15;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Database_Assignemt.Properties.Resources.Ampeross_Qetto_2_Search_256__1_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(364, 551);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 65);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::Database_Assignemt.Properties.Resources.pngtree_aesthetic_background_pink_pastel_image_866344;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 666);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.textCon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSID);
            this.Controls.Add(this.cmbPID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textLname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSID);
            this.Controls.Add(this.grpCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPrv);
            this.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.grpCat.ResumeLayout(false);
            this.grpCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPrv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCat;
        private System.Windows.Forms.TextBox textSID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbnCam;
        private System.Windows.Forms.RadioButton rbnStaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbnVoice;
        private System.Windows.Forms.RadioButton rbnAct;
        private System.Windows.Forms.RadioButton rbnPro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPID;
        private System.Windows.Forms.ComboBox cmbSID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textCon;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
    }
}