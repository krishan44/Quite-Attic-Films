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
namespace Database_Assignemt
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C64QD8D\SQLEXPRESS01;Initial Catalog=Quite_attic_films;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            textLID.Visible = false;
            cmbLID.Visible = true;
            btnUp.Visible = true;
            btnDel.Visible = true;
            btnSave.Visible = false;
            try
            {
                string que = "select LID from Location";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbLID.Items.Clear();
                cmbLID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbLID.Items.Add(dr["LID"]);
                }
                cmbLID.SelectedIndex = 0;

            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnDel.Visible = false;
            btnUp.Visible = false;
            cmbLID.Visible=false;
            cmbType.SelectedIndex = 0;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                string quesave = "insert into Location(LID,loName,conNo,type,prodution_ID) values('" + textLID.Text + "','" + textLname.Text + "','" + textCon.Text + "','" + cmbType.SelectedItem.ToString() + "','" + cmbPID.SelectedItem.ToString() + "')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Location ID " + "" + textLname.Text + "" + "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            textCon.Text = "";
            textLID.Text = "";
            textLname.Text = "";
            cmbType.SelectedIndex = 0;  
            cmbPID.SelectedIndex = 0;   

        }

        private void cmbLID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbLID.SelectedIndex > 0)
                {
                    string ged = cmbLID.SelectedItem.ToString();
                    string quedata = "SELECT * from Location where LID='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        textLname.Text = Rd.GetValue(1).ToString();
                        textCon.Text = Rd.GetValue(2).ToString();
                        cmbType.SelectedItem = Rd.GetValue(3).ToString();
                        cmbPID.SelectedItem = Rd.GetValue(4).ToString();
                       
                    }


                    conn.Close();
                }
                else
                {
                    textLname.Text = "";
                    textCon.Text = "";
                    cmbType.SelectedItem = 0;
                 
                    cmbPID.SelectedIndex = 0;
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
                string queUp = "Update Location set loName='" + textLname.Text + "',conNo='" + textCon.Text + "',type='" +cmbType.SelectedItem.ToString() + "',Prodution_ID='" +cmbPID.SelectedItem.ToString() + "' Where LID='" + cmbLID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Client ID" + "" + cmbLID.SelectedItem.ToString() + "" + "successfully Upadated to the Database....!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makuwa();

                cmbLID.SelectedIndex = 0;

                textLname.Focus();



            }
            catch (Exception UpdateErr)
            {
                MessageBox.Show("Error While Updating Data" + Environment.NewLine + UpdateErr);

            }
            try
            {
                string que = "select LID from Location";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbLID.Items.Clear();
                cmbLID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbLID.Items.Add(dr["LID"]);
                }
                cmbLID.SelectedIndex = 0;

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
                DialogResult resDel = MessageBox.Show("Are you Sure you want to Delete Location: " + textLname.Text + " Record From Database????", "Confirm to Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "Delete from Location where LID='" + cmbLID.SelectedItem.ToString() + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(" Location" + textLname.Text + "" + "Successfully Deleted From the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makuwa();
                    cmbLID.SelectedIndex = 0;
                    textLname.Focus();
                }


            }
            catch (Exception DelErr)

            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + DelErr);

            }
            try
            {
                string que = "select LID from Location";
                conn.Open();
                adapter = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbLID.Items.Clear();
                cmbLID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbLID.Items.Add(dr["LID"]);
                }
                cmbLID.SelectedIndex = 0;

            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form5 frm=new Form5();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main frmm = new Main();
            frmm.Show();
            this.Hide();
        }
    }
}
