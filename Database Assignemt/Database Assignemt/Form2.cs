using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace Database_Assignemt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C64QD8D\SQLEXPRESS01;Initial Catalog=Quite_attic_films;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string quesave = "insert into Client(CID,cFname,cLname,cCompany,Email,ConNo) values('" + textCID.Text + "','" + textFname.Text + "','" + textLname.Text + "','" + textComp.Text + "','" + textEmail.Text + "','"+textCon.Text+"')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Client ID " + "" + textFname.Text + "" + "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();

            }
            catch (Exception Save_Error)
            {

                MessageBox.Show("Error While Saving" + Environment.NewLine + Save_Error);
            }
        }
        private void makuwa()
        {
            textCID.Text = "";
            textComp.Text = "";
            textEmail.Text = "";
            textFname.Text = "";
            textLname.Text = "";
            textCon.Text = "";
            textCID.Focus();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {      
            textCID.Visible = false;
            btnSave.Visible = false;
            cmbCID.Visible = true;
            btnDel.Visible = true;
            btnUp.Visible = true;   
            btnCl.Visible = false;
            try
            {
                string que = "select CID from Client";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbCID.Items.Clear();
                cmbCID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbCID.Items.Add(dr["CID"]);
                }
                cmbCID.SelectedIndex = 0;

            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void cmbCID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCID.SelectedIndex > 0)
                {
                    string ged = cmbCID.SelectedItem.ToString();
                    string quedata = "SELECT * from Client where CID='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        textFname.Text = Rd.GetValue(1).ToString();
                        textLname.Text = Rd.GetValue(2).ToString();
                        textComp.Text = Rd.GetValue(3).ToString();
                        textEmail.Text = Rd.GetValue(4).ToString();
                        textCon.Text = Rd.GetValue(5).ToString();
                    }
                   

                    conn.Close();
                }
                else
                {
                    textFname.Text = "";
                    textLname.Text = "";
                    textComp.Text = "";
                    textEmail.Text = "";
                    textCon.Text = "";
                    cmbCID.SelectedIndex = 0;
                }




            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);
            }
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            makuwa();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnUp.Visible = false;
            btnDel.Visible = false;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string queUp = "Update Client set cFname='" + textFname.Text + "',cLname='" + textLname.Text + "',cCompany='" + textComp.Text + "',Email='"+textEmail.Text+"',ConNo='"+textCon.Text+"'Where CID='" + cmbCID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Client ID" + "" + cmbCID.SelectedItem.ToString() + "" + "successfully Upadated to the Database....!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();

                cmbCID.SelectedIndex = 0;
                
                textFname.Focus();



            }
            catch (Exception UpdateErr)
            {
                MessageBox.Show("Error While Updating Data" + Environment.NewLine + UpdateErr);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Are you Sure you want to Delete Production: " + textFname.Text + " Record From Database????", "Confirm to Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "Delete from Client where CID='" + cmbCID.SelectedItem.ToString() + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Client" + textFname.Text + "" + "Successfully Deleted From the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makuwa();
                    cmbCID.SelectedIndex = 0;
                    textFname.Focus();
                }


            }
            catch (Exception DelErr)

            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + DelErr);

            }
            try
            {
                string que = "select CID from Client";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbCID.Items.Clear();
                cmbCID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbCID.Items.Add(dr["CID"]);
                }
                cmbCID.SelectedIndex = 0;

            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }
    }
    
}
