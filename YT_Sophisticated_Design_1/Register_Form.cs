using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YT_Sophisticated_Design_1
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }
        

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\market_db.mdf;Integrated Security=True;Connect Timeout=30");

        
        

        //*******************************************************************************************************************************************************************************  

        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login_Form log = new Login_Form();
            this.Hide();
            log.Show();
        }

        private void lbl_clear1_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void lbl_clear2_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_phoneNum.Text = "";
        }






        private void btn_register_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT (*) FROM Register_Table1 WHERE UserName = '" + txt_username.Text + "'";

            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count >0)
            {
                MessageBox.Show("Username is already taken");
            }
            else
            {
                cmd.CommandText = "INSERT INTO Register_Table1 (UserName,Password,Email,PhoneNum,BirthDay) VALUES ('" + txt_username.Text + "'," +
                    "'" + txt_password.Text + "','" + txt_email.Text + "','" + txt_phoneNum.Text + "','" + dtp_birthday.Value + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert Success");
            }
        }
    }
}
