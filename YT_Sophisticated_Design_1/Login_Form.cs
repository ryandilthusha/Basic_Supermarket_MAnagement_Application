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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        public static string SellerName = "";  //To fetch seller name to Selling form --> step1

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\market_db.mdf;Integrated Security=True;Connect Timeout=30");

        private void Login_Form_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        //*******************************************************************************************************************************************************************************  

        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register_Form reg = new Register_Form();
            this.Hide();
            reg.Show();
        }


        //*******************************************************************************************************************************************************************************  

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Enter the UserName and Password");
            }
            else if (txt_username.Text == "")
            {
                MessageBox.Show("Enter the User Name");
            }
            else if (txt_password.Text == "")
            {
                MessageBox.Show("Enter the Password");
            }
            
            else
            {
                // ADMIN LOGIN CODE with defined Username and Password

                if (cmb_role.SelectedIndex > -1)
                {
                    if (cmb_role.SelectedItem.ToString() == "ADMIN")
                    {
                        if (txt_username.Text == "Admin" && txt_password.Text == "Admin")
                        {
                            SellerName = txt_username.Text;         //To fetch seller name to Selling form --> step2
                            ProductsForm product = new ProductsForm();
                            this.Hide();
                            product.Show();
                        }
                        else
                        {
                            MessageBox.Show("If you are ADMIN, please enter correct Username and Password");
                        }
                    }
                    else
                    {
                        // SELLLER LOGIN CODE with defined Username and Password in the DATABASE

                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT COUNT(*) FROM Register_Table1 WHERE UserName = '" + txt_username.Text + "' AND Password = '" + txt_password.Text + "'";

                        Int32 count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (cmb_role.SelectedItem.ToString() == "SELLER")
                        {
                            if (count > 0)
                            {
                                SellerName = txt_username.Text;         //To fetch seller name to Selling form --> step2
                                Seller_Selling selling = new Seller_Selling();
                                this.Hide();
                                selling.Show();
                            }
                            else
                            {
                                MessageBox.Show("If you are SELLER, please enter correct Username and Password");
                            }
                        }
                    }
                }                 
            }
        }        
    }
}
