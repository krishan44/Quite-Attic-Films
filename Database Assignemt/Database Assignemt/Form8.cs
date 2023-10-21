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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C64QD8D\SQLEXPRESS01;Initial Catalog=Quite_attic_films;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void login_Load(object sender, EventArgs e)
        {
            textUname.Focus();
        }
        string un, pw,ID;

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resx = MessageBox.Show("Are You Sure You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                un = textUname.Text;
                pw = textPw.Text;
                string quelog = "SELECT USID from users where Uname='" + un + "' AND Pw='" + pw + "'";
                conn.Open();
                adapter = new SqlDataAdapter(quelog, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd = new SqlCommand(quelog, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ID = reader.GetValue(0).ToString();

                    }
                    Main fm = new Main();
                    fm.Show();
                    this.Hide();
                    MessageBox.Show("Welcome to the Grifindo Management System","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Unauthorized Login", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    textPw.Clear();
                    textUname.Clear();
                }
                conn.Close();
            }
            catch (Exception loginERr)
            { MessageBox.Show("Error while login" + Environment.NewLine + loginERr); }

        }
    }
}
