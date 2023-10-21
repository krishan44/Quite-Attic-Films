using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Database_Assignemt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C64QD8D\SQLEXPRESS01;Initial Catalog=Quite_attic_films;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        //genarating auto Id's
        private void Auto()
        {
           /* try
            {
                string AuId = ""; //AuId is just a variable
                int pid = 0;
                string que = "SELECT PID from Production"; //production table primary Key
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable AuTbl = new DataTable();
                adapter.Fill(AuTbl);
                conn.Close();

                if (AuTbl.Rows.Count >= 0)
                {
                    string maxi = "SELECT MAX(prSerial) from Production";
                    conn.Open();
                    cmd = new SqlCommand(maxi, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();

                    while (Rd.Read())
                    {
                        //pid = int.Parse(Rd.GetValue(0).ToString());

                    }

                    conn.Close();
                    pid = pid + 1;

                }
                else
                {
                    pid = 1;

                }
                if (pid < 10) { AuId = "PID-00000" + pid; } // rangeing the PID cases into place
                else if (pid < 100) { AuId = "PID-0000" + pid; }
                else if (pid < 1000) { AuId = "PID-000" + pid; }
                else if (pid < 10000) { AuId = "PID-00" + pid; }
                else if (pid < 100000) { AuId = "PID-0" + pid; }
                else if (pid < 1000000) { AuId = "PID-" + pid; }


                txtPID.Text = AuId;

            }
            catch (Exception AutoLoadErr)
            {
                MessageBox.Show("Error while Loading PID auto....!" + Environment.NewLine + AutoLoadErr);

            }*/




        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnDel.Visible = false;
            btnUp.Visible = false;
            lblUp.Visible = false;
            
            lblDl.Visible = false;

            txtPID.Focus();
            cmbType.SelectedIndex = 0;
            try
            {
                string que = "select CID from Client";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbCli.Items.Clear();
                cmbCli.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbCli.Items.Add(dr["CID"]);
                }
                cmbCli.SelectedIndex = 0;

            }
            catch (Exception LoadErr)
            {
                MessageBox.Show("Error While Loading" + Environment.NewLine + LoadErr);

            }
            txtname.Focus();
        }
        private void label9_Click(object sender, EventArgs e)                    
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string quesave = "insert into Production(PID,pName,Duration,pType,Customer_ID) values('" + txtPID.Text + "','" + txtname.Text + "','" + txtDuration.Text + "','" + cmbType.SelectedItem.ToString() + "','" + cmbCli.SelectedItem.ToString() + "')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Prodution ID "+"" + txtname.Text +""+ "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (Exception Save_Error)
            {

                MessageBox.Show("Error While Saving" + Environment.NewLine + Save_Error);
            }
            cmbType.SelectedIndex = 0;

            makuwa();
            cmbType.SelectedIndex = 0;
            txtPID.Text = "";
        }
        private void makuwa()
        {
            
            txtname.Text = "";
            txtClient.Text = "";
            txtDuration.Text = "";
            txtDuration.Visible= false;
            rbnDay.Checked = false; 
            lbldays.Visible = false;
           // lblMonths.Visible = false;
            cmbType.SelectedIndex = 1;
            txtPID.Focus();
        }

        private void grpDur_Enter(object sender, EventArgs e)
        {
        
            }

        private void rbnDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnDay.Checked == true)
            {
                lbldays.Visible = true;
                txtDuration.Visible = true;
                txtDuration.Focus();
            }
            else lbldays.Visible = false;
            txtDuration.Text = "";


        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblsave.Visible = false;
            btnSave.Visible = false;
            btnUp.Visible = true;
            btnDel.Visible = true;
            lblUp.Visible = true;  
            btnUp.Visible = true;  
            txtClient.Visible = false;
            lblDl.Visible = true;
            txtPID.Visible = false;
            cmbPID.Visible = true;
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
            try
            {
                string que = "select CID from Client";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbCli.Items.Clear();
                cmbCli.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbCli.Items.Add(dr["CID"]);
                }
                cmbCli.SelectedIndex = 0;

            }
            catch (Exception LoadErr)
            {
                MessageBox.Show("Error While Loading" + Environment.NewLine + LoadErr);

            }
        }

        private void cmbPID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {   lbltype.Visible = true;
                rbnDay.Checked = true;
                txtDuration.Visible = true;
                txtClient.Visible = true;
                txtClient.Enabled = true;
                cmbType.Visible = false;
                lbltype.Enabled = true;
                cmbCli.Visible = false;
                if (cmbPID.SelectedIndex > 0)
                {
                    string ged =cmbPID.SelectedItem.ToString();
                    string quedata = "SELECT * from production where PID='" + ged + "'";
                    conn.Open();    
                    cmd= new SqlCommand(quedata, conn);
                    SqlDataReader Rd= cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        txtClient.Text = Rd.GetValue(4).ToString();
                        txtname.Text = Rd.GetValue(1).ToString();
                        txtDuration.Text = Rd.GetValue(2).ToString();
                        lbltype.Text=Rd.GetValue(3).ToString(); 
                    }
                    txtClient.Enabled=false;
                   
                    conn.Close();
                }
                else
                {
                    //rbnMnth.Enabled = false;
                    cmbPID.SelectedIndex = 0;
                    cmbType.SelectedIndex = 0;
                    txtname.Text = "";
                    txtDuration.Text = "";
                    lbltype.Text = "";
                    txtClient.Text = "";
                }




            }catch(Exception SearchErr)
            {
                MessageBox.Show("Error While Searching"+Environment.NewLine + SearchErr);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try {
                string queUp = "Update Production set pName='" + txtname.Text + "',Duration='" + txtDuration.Text + "',pType='" + cmbType.SelectedItem.ToString() + "'Where PID='"+cmbPID.SelectedItem.ToString() +"'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Prodution ID"+"" + cmbPID.SelectedItem.ToString() + "" + "successfully Upadated to the Database....!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();

                cmbPID.SelectedIndex = 0;       
                cmbCli.SelectedIndex = 0;
                txtname.Focus();



            }
            catch (Exception UpdateErr)
            {
                MessageBox.Show("Error While Updating Data"+Environment.NewLine+UpdateErr);

            }

        }

        private void cmbCli_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Are you Sure you want to Delete Production: " + txtname.Text + " Record From Database????", "Confirm to Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resDel == DialogResult.Yes)
                {
                    string queDel = "Delete from Production where PID='" + cmbPID.SelectedItem.ToString() + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Production" + txtname.Text + "" + "Successfully Deleted From the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makuwa();
                    cmbPID.SelectedIndex = 0;
                    txtname.Focus() ;
                }


            }catch (Exception DelErr)
            
            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + DelErr);

            }
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

        private void btnEx_Click(object sender, EventArgs e)
        {
            DialogResult resX=MessageBox.Show("Are you sure, You want to Exit!!!","Confirm to Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resX == DialogResult.Yes)
            {
                this.Close();
            }
        
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void lbltype_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
