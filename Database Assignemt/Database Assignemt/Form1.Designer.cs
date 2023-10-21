namespace Database_Assignemt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBack = new System.Windows.Forms.Button();
            this.grpDur = new System.Windows.Forms.GroupBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lbldays = new System.Windows.Forms.Label();
            this.rbnDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblsave = new System.Windows.Forms.Label();
            this.lblDl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblUp = new System.Windows.Forms.Label();
            this.cmbPID = new System.Windows.Forms.ComboBox();
            this.lbltype = new System.Windows.Forms.TextBox();
            this.cmbCli = new System.Windows.Forms.ComboBox();
            this.grpDur.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Database_Assignemt.Properties.Resources.Graphicloads_Polygon_Previous_4_256;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(21, 455);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 57);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpDur
            // 
            this.grpDur.BackColor = System.Drawing.Color.Transparent;
            this.grpDur.Controls.Add(this.txtDuration);
            this.grpDur.Controls.Add(this.lbldays);
            this.grpDur.Controls.Add(this.rbnDay);
            this.grpDur.ForeColor = System.Drawing.Color.Transparent;
            this.grpDur.Location = new System.Drawing.Point(129, 225);
            this.grpDur.Name = "grpDur";
            this.grpDur.Size = new System.Drawing.Size(157, 109);
            this.grpDur.TabIndex = 1;
            this.grpDur.TabStop = false;
            this.grpDur.Enter += new System.EventHandler(this.grpDur_Enter);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(15, 62);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(50, 23);
            this.txtDuration.TabIndex = 4;
            this.txtDuration.Visible = false;
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.BackColor = System.Drawing.Color.Transparent;
            this.lbldays.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.ForeColor = System.Drawing.Color.Honeydew;
            this.lbldays.Location = new System.Drawing.Point(85, 65);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(41, 16);
            this.lbldays.TabIndex = 10;
            this.lbldays.Text = "Days";
            this.lbldays.Visible = false;
            // 
            // rbnDay
            // 
            this.rbnDay.AutoSize = true;
            this.rbnDay.BackColor = System.Drawing.Color.Transparent;
            this.rbnDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbnDay.ForeColor = System.Drawing.Color.Honeydew;
            this.rbnDay.Location = new System.Drawing.Point(21, 24);
            this.rbnDay.Name = "rbnDay";
            this.rbnDay.Size = new System.Drawing.Size(49, 20);
            this.rbnDay.TabIndex = 3;
            this.rbnDay.Text = "Day";
            this.rbnDay.UseVisualStyleBackColor = false;
            this.rbnDay.CheckedChanged += new System.EventHandler(this.rbnDay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Production Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(29, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "PID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(180, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(55, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(129, 185);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(146, 23);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(54, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Duration";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Database_Assignemt.Properties.Resources.Custom_Icon_Design_Flatastic_2_Data_add_256;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(157, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 57);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundImage = global::Database_Assignemt.Properties.Resources.Graphicloads_Long_Shadow_Documents_Document_remove_256;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(286, 455);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(44, 57);
            this.btnDel.TabIndex = 10;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEx
            // 
            this.btnEx.BackColor = System.Drawing.Color.Transparent;
            this.btnEx.BackgroundImage = global::Database_Assignemt.Properties.Resources.Graphicloads_Polygon_Cross_3_256;
            this.btnEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEx.FlatAppearance.BorderSize = 0;
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Location = new System.Drawing.Point(312, 12);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(41, 53);
            this.btnEx.TabIndex = 12;
            this.btnEx.UseVisualStyleBackColor = false;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Database_Assignemt.Properties.Resources.Ampeross_Qetto_2_Search_256__1_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(312, 237);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 45);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "--SELECT--",
            "Short Film",
            "Short Marketing",
            "Advertisement",
            "Introdution Film",
            "Training Film"});
            this.cmbType.Location = new System.Drawing.Point(129, 357);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(134, 23);
            this.cmbType.TabIndex = 5;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(62, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(18, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "  ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblsave
            // 
            this.lblsave.AutoSize = true;
            this.lblsave.BackColor = System.Drawing.Color.Transparent;
            this.lblsave.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsave.ForeColor = System.Drawing.Color.Honeydew;
            this.lblsave.Location = new System.Drawing.Point(154, 515);
            this.lblsave.Name = "lblsave";
            this.lblsave.Size = new System.Drawing.Size(39, 16);
            this.lblsave.TabIndex = 17;
            this.lblsave.Text = "Save";
            // 
            // lblDl
            // 
            this.lblDl.AutoSize = true;
            this.lblDl.BackColor = System.Drawing.Color.Transparent;
            this.lblDl.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDl.ForeColor = System.Drawing.Color.Honeydew;
            this.lblDl.Location = new System.Drawing.Point(283, 515);
            this.lblDl.Name = "lblDl";
            this.lblDl.Size = new System.Drawing.Size(50, 16);
            this.lblDl.TabIndex = 18;
            this.lblDl.Text = "Delete";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(309, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Search";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Honeydew;
            this.label13.Location = new System.Drawing.Point(24, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Back";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(69, 121);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(89, 23);
            this.txtPID.TabIndex = 21;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(241, 122);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(89, 23);
            this.txtClient.TabIndex = 22;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = global::Database_Assignemt.Properties.Resources.Flat_Icons_com_Flat_Pencil_256;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(312, 330);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(41, 45);
            this.btnUp.TabIndex = 9;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.BackColor = System.Drawing.Color.Transparent;
            this.lblUp.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUp.ForeColor = System.Drawing.Color.Honeydew;
            this.lblUp.Location = new System.Drawing.Point(309, 388);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(56, 16);
            this.lblUp.TabIndex = 24;
            this.lblUp.Text = "Update";
            // 
            // cmbPID
            // 
            this.cmbPID.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPID.FormattingEnabled = true;
            this.cmbPID.Items.AddRange(new object[] {
            "--SELECT--",
            "Short Film",
            "Short Marketing",
            "Advertisement",
            "Introdution Film",
            "Training Film"});
            this.cmbPID.Location = new System.Drawing.Point(74, 122);
            this.cmbPID.Name = "cmbPID";
            this.cmbPID.Size = new System.Drawing.Size(84, 23);
            this.cmbPID.TabIndex = 1;
            this.cmbPID.Visible = false;
            this.cmbPID.SelectedIndexChanged += new System.EventHandler(this.cmbPID_SelectedIndexChanged);
            // 
            // lbltype
            // 
            this.lbltype.Location = new System.Drawing.Point(140, 357);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(110, 23);
            this.lbltype.TabIndex = 27;
            this.lbltype.Visible = false;
            this.lbltype.TextChanged += new System.EventHandler(this.lbltype_TextChanged);
            // 
            // cmbCli
            // 
            this.cmbCli.FormattingEnabled = true;
            this.cmbCli.Location = new System.Drawing.Point(240, 121);
            this.cmbCli.Name = "cmbCli";
            this.cmbCli.Size = new System.Drawing.Size(90, 24);
            this.cmbCli.TabIndex = 6;
            this.cmbCli.SelectedIndexChanged += new System.EventHandler(this.cmbCli_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Database_Assignemt.Properties.Resources.abstract_classic_blue_background_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 555);
            this.ControlBox = false;
            this.Controls.Add(this.cmbCli);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.cmbPID);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDl);
            this.Controls.Add(this.lblsave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDur);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDur.ResumeLayout(false);
            this.grpDur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpDur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.RadioButton rbnDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblsave;
        private System.Windows.Forms.Label lblDl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.ComboBox cmbPID;
        private System.Windows.Forms.TextBox lbltype;
        private System.Windows.Forms.ComboBox cmbCli;
    }
}

