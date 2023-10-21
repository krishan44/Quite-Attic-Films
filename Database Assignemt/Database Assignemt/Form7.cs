using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace Database_Assignemt
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C64QD8D\SQLEXPRESS01;Initial Catalog=Quite_attic_films;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void Form7_Load(object sender, EventArgs e)
        { 
            btnDel.Visible = false;
            btnUp.Visible = false;
            cmbPyID.Visible = false;
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
                textPyID.Focus();

            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }
        double hrRate, hrWrk, Tot;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string quesave = "insert into Pay(PyID,Hr_Rate,Hr_Worked,Total,SID) values('" + textPyID.Text + "','" + textHrRate.Text + "','" + textHrWrk.Text+ "','" + textTot.Text + "','" + cmbSID.SelectedItem.ToString() + "')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Pay ID " + "" + textPyID.Text + "" + "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();
                

            }
            catch (Exception Save_Error)
            {

                MessageBox.Show("Error While Saving" + Environment.NewLine + Save_Error);
            }
        }
        private void makuwa() {

            textPyID.Text = "";
            cmbSID.SelectedIndex = 0;
            textHrWrk.Text = "";
            textHrRate.Text = "";
            textTot.Text = "";
        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnDel.Visible = true;
            btnDel.Visible = true;
            button1.Visible = false;
            textPyID.Visible = false;
            cmbPyID.Visible = true;
            btnUp.Visible = true;

            try
            {
                string que = "select PyId from pay";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbPyID.Items.Clear();
                cmbPyID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbPyID.Items.Add(dr["PyID"]);
                }
                cmbPyID.SelectedIndex = 0;
                
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void cmbPyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPyID.SelectedIndex > 0)
                {
                    string ged = cmbPyID.SelectedItem.ToString();
                    string quedata = "SELECT * from pay where PyId='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        textHrRate.Text = Rd.GetValue(1).ToString();
                        textHrWrk.Text = Rd.GetValue(2).ToString();
                        cmbSID.SelectedItem = Rd.GetValue(4).ToString();
                        textTot.Text = Rd.GetValue(3).ToString();

                    }


                    conn.Close();
                }
                else
                {
                    textHrRate.Text = "";
                    textHrWrk.Text = "";
                    cmbSID.SelectedItem = 0;
                    textTot.Text = "";

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
                string queUp = "Update Pay set Hr_Rate='" + textHrRate.Text + "',Hr_Worked='" + textHrWrk.Text + "',total='" + textTot.Text + "',SID='" + cmbSID.SelectedItem.ToString() + "' Where PyID='" + cmbPyID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Pay ID" + "" + cmbPyID.SelectedItem.ToString() + "" + "successfully Upadated to the Database....!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();

                cmbPyID.SelectedIndex = 0;

                textHrRate.Focus();



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
                DialogResult resDel = MessageBox.Show("Are you Sure you want to Delete Pay: " + cmbPyID.SelectedItem.ToString() + " Record From Database????", "Confirm to Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "Delete from pay where PyID='" + cmbPyID.SelectedItem.ToString() + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(" Payment" + cmbPyID.SelectedItem.ToString() + "" + "Successfully Deleted From the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makuwa();
                    cmbPyID.SelectedIndex = 0;
                    textHrRate.Focus();
                }


            }
            catch (Exception DelErr)

            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + DelErr);

            }
            try
            {
                string que = "select PyId from pay";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbPyID.Items.Clear();
                cmbPyID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbPyID.Items.Add(dr["PyID"]);
                }
                cmbPyID.SelectedIndex = 0;

            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main fr = new Main();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textHrRate.Text))
            {
                MessageBox.Show("Not Enough Details to Calculate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textHrWrk.Text))
            {
                MessageBox.Show("Not Enough Details to Calculate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!double.TryParse(textHrRate.Text, out hrRate) || !double.TryParse(textHrWrk.Text, out hrWrk))
            {
                MessageBox.Show("Invalid Credentials","Not Valid",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hrRate = double.Parse(textHrRate.Text);
                hrWrk = double.Parse(textHrWrk.Text);
                Tot = hrRate * hrWrk;

                textTot.Text = Tot.ToString();
            }
        }
    }
}
