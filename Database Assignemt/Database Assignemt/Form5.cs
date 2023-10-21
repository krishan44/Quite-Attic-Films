using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace Database_Assignemt
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C64QD8D\SQLEXPRESS01;Initial Catalog=Quite_attic_films;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        string category;
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if(rbnAct.Checked==true) { category = "Actor"; }
                else if (rbnStaff.Checked==true) { category = "Staff"; }
                else if(rbnCam.Checked==true) { category = "Camera Crew"; }
                else if(rbnPro.Checked==true) { category = "Producer"; }
                else if(rbnVoice.Checked==true) { category = "Voice Actor"; }


                string quesave = "insert into staff(SID,Fname,Lname,NIC,Email,conNo,Type,Prodution_ID) values('" + textSID.Text + "','" + textFname.Text + "','" + textLname.Text + "','" + textNIC.Text + "','" + textEmail.Text + "','" + textCon.Text + "','" + category + "','" + cmbPID.SelectedItem.ToString() + "')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Staff Member " + "" + textFname.Text + "" + "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();
                cmbPID.SelectedIndex = 0;
                textSID.Focus();
                

            }
            catch (Exception Save_Error)
            {

                MessageBox.Show("Error While Saving" + Environment.NewLine + Save_Error);
            }
        }
        private void makuwa()
        {
            textCon.Text = "";
            textEmail.Text = "";
            textFname.Text = "";
            textLname.Text = "";
            textSID.Text = "";
            textNIC.Text = "";
            rbnAct.Checked = false;
            rbnCam.Checked = false;
            rbnPro.Checked = false;
            rbnStaff.Checked = false;
            rbnVoice.Checked = false;
           
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            btnDel.Visible = false;
            btnUp.Visible = false;
            cmbSID.Visible = false;
            try
            {
                string que = "select PID from production";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbPID.Items.Clear();
                cmbPID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbPID.Items.Add(dr["PID"]);
                }
                cmbPID.SelectedIndex = 0;
                
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnDel.Visible = true;
            textSID.Visible = false;
            btnUp.Visible = true;
            cmbSID.Visible = true;
            try
            {
                string que = "select SID from staff";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbSID.Items.Clear();
                cmbSID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSID.Items.Add(dr["SID"]);
                }
                cmbSID.SelectedIndex = 0;

            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }
        string job;
        private void cmbSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSID.SelectedIndex > 0)
                {
                    string ged = cmbSID.SelectedItem.ToString();
                    string quedata = "SELECT * from staff where SID='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        textFname.Text = Rd.GetValue(1).ToString();
                        textLname.Text = Rd.GetValue(2).ToString();
                        textNIC.Text = Rd.GetValue(3).ToString();
                        textEmail.Text = Rd.GetValue(4).ToString();
                        textCon.Text = Rd.GetValue(5).ToString();
                        job= Rd.GetValue(6).ToString();
                        if (job.Equals("Actor")) { rbnAct.Checked = true; }
                        else if (job.Equals("Staff")) { rbnStaff.Checked = true; }
                        else if(job.Equals("Camera Crew")) { rbnCam.Checked = true; }
                        else if (job.Equals("Producer")) { rbnPro.Checked = true; }
                        else if (job.Equals("Voice Actor")) { rbnVoice.Checked = true; }
                        cmbPID.SelectedItem = Rd.GetValue(7).ToString();

                    }


                    conn.Close();
                }
                else
                {
                    makuwa();
                }




            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbnAct.Checked == true) { category = "Actor"; }
                else if (rbnStaff.Checked == true) { category = "Staff"; }
                else if (rbnCam.Checked == true) { category = "Camera Crew"; }
                else if (rbnPro.Checked == true) { category = "Producer"; }
                else if (rbnVoice.Checked == true) { category = "Voice Actor"; }


                string queUp = "Update staff set Fname='" + textFname.Text + "',Lname='" + textLname.Text + "',NIC='" + textNIC.Text+ "',Email='" +textEmail.Text + "',ConNo='" +textCon.Text + "',Type='" +category + "',Prodution_ID='" + cmbPID.SelectedItem.ToString() + "' Where SID='" + cmbSID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Staff ID" + "" + cmbSID.SelectedItem.ToString() + "" + "successfully Upadated to the Database....!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();

                cmbSID.SelectedIndex = 0;

                textFname.Focus();



            }
            catch (Exception UpdateErr)
            {
                MessageBox.Show("Error While Updating Data" + Environment.NewLine + UpdateErr);

            }
            try
            {
                string que = "select SID from staff";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbSID.Items.Clear();
                cmbSID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSID.Items.Add(dr["SID"]);
                }
                cmbSID.SelectedIndex = 0;

            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Are you Sure you want to Delete Staff ID: " + cmbSID.SelectedItem.ToString() + " Record From Database????", "Confirm to Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "Delete from  staff where SId='" + cmbSID.SelectedItem.ToString() + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(" Staff" + cmbSID.SelectedItem.ToString() + "" + "Successfully Deleted From the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makuwa();
                    cmbSID.SelectedIndex = 0;
                    textFname.Focus();
                }
                cmbPID.SelectedIndex = 0;

            }
            catch (Exception DelErr)

            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + DelErr);

            }
            try
            {
                string que = "select SID from staff";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbSID.Items.Clear();
                cmbSID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSID.Items.Add(dr["SID"]);
                }
                cmbSID.SelectedIndex = 0;

            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void BtnPrv_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
    
    
}
