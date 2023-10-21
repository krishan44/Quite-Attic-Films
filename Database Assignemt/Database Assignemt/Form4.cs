using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Database_Assignemt
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C64QD8D\SQLEXPRESS01;Initial Catalog=Quite_attic_films;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void Form4_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
            cmbPrId.Visible = false;
            btnDel.Visible = false;
            btnUp.Visible = false;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string quesave = "insert into Property(PrID,PrName,PrType,Description,Prodution_ID) values('" + textPrId.Text + "','" + textPrName.Text + "','" + cmbType.SelectedItem.ToString() + "','" + textDes.Text + "','" + cmbPID.SelectedItem.ToString() + "')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Property ID " + "" + textPrId.Text + "" + "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();
                cmbPID.SelectedIndex = 0;

            }
            catch (Exception Save_Error)
            {

                MessageBox.Show("Error While Saving" + Environment.NewLine + Save_Error);
            }

        }
        private void makuwa()
        {
            cmbPID.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            textDes.Text = "";
            textPrName.Text = "";
            textPrId.Text = "";


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbPrId.Visible = true;
            textPrId.Visible= false;
            btnSave.Visible = false;
            try
            {
                string que = "select PrId from Property";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbPrId.Items.Clear();
                cmbPrId.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbPrId.Items.Add(dr["PrID"]);
                }
                cmbPrId.SelectedIndex = 0;
                btnDel.Visible = true;
                btnUp.Visible = true;
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }


        }

        private void cmbPrId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPrId.SelectedIndex > 0)
                {
                    string ged = cmbPrId.SelectedItem.ToString();
                    string quedata = "SELECT * from Property where PrId='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        textPrName.Text = Rd.GetValue(1).ToString();
                        cmbType.SelectedItem = Rd.GetValue(2).ToString();
                        cmbPID.SelectedItem = Rd.GetValue(4).ToString();
                        textDes.Text = Rd.GetValue(3).ToString();

                    }


                    conn.Close();
                }
                else
                {
                    textPrName.Text = "";
                    textDes.Text = "";
                    cmbType.SelectedIndex = 0;
                    cmbPID.SelectedIndex = 0;
                    cmbPrId.SelectedIndex = 0;
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
                string queUp = "Update Property set PrName='" + textPrName.Text + "',prType='" + cmbType.SelectedItem.ToString() + "',Description='" + textDes.Text + "',Prodution_ID='" + cmbPID.SelectedItem.ToString() + "' Where PrID='" + cmbPrId.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Property ID" + "" + cmbPrId.SelectedItem.ToString() + "" + "successfully Upadated to the Database....!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();

                cmbPrId.SelectedIndex = 0;

                textPrName.Focus();

               

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
                DialogResult resDel = MessageBox.Show("Are you Sure you want to Delete Production: " + cmbPrId.SelectedItem.ToString() + " Record From Database????", "Confirm to Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "Delete from  Property where PrId='" + cmbPrId.SelectedItem.ToString() + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(" Property" + cmbPrId.SelectedItem.ToString() + "" + "Successfully Deleted From the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makuwa();
                    cmbPrId.SelectedIndex = 0;
                    textPrName.Focus();
                }


            }
            catch (Exception DelErr)

            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + DelErr);

            }
            try
            {
                string que = "select PrId from Property";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbPrId.Items.Clear();
                cmbPrId.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbPrId.Items.Add(dr["PrID"]);
                }
                cmbPrId.SelectedIndex = 0;
                btnDel.Visible = true;
                btnUp.Visible = true;
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();

        }

        private void cmbPID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
