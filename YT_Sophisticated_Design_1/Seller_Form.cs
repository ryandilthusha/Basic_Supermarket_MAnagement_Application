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
    public partial class Seller_Form : Form
    {
        public Seller_Form()
        {
            InitializeComponent();

            display_data_grid_view();   // Data Grid view from the start
        }       

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\market_db.mdf;Integrated Security=True;Connect Timeout=30");

        // for data grid view
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;

        private void Seller_Form_Test_Load(object sender, EventArgs e)
        {
            display_data_grid_view(); // data grid view method          
        }

        //************************OTHER   BUTTONS********************************************************************************************************************************  

        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }                     

        private void btn_products_Click(object sender, EventArgs e)
        {
            ProductsForm prod = new ProductsForm();
            prod.Show();
            this.Hide();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            Categories_Form cat = new Categories_Form();
            cat.Show();
            this.Hide();
        }

        private void btn_selling_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller_Selling sell = new Seller_Selling();
            sell.Show();
        }

        private void pic_box_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form log = new Login_Form();
            log.Show();
        }

        //************************OTHER   METHODS********************************************************************************************************************************    

        public void clear()
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";
            txt_phone.Text = "";
        }


        public void display_data_grid_view()    //For the Data Grid View newly created method
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Register_Table1 ", con);
                adpt.Fill(dt);
                dgv_seller.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_seller_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_seller.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Register_Table1 WHERE Id = '" + ID + "'";

            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {
                txt_username.Text = DR1.GetValue(1).ToString();
                txt_password.Text = DR1.GetValue(2).ToString();
                txt_email.Text = DR1.GetValue(3).ToString();
                txt_phone.Text = DR1.GetValue(4).ToString();

                dtp_birthday.Value = DateTime.Parse(DR1.GetValue(5).ToString());
            }
            DR1.Close();
            con.Close();
        }



        //***********************************ADD********EDIT********DELETE**************************************************************************  

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Register_Table1 (UserName,Password,Email,PhoneNum,BirthDay) VALUES('" + txt_username.Text + "'," +
                    "'" + txt_password.Text + "','" + txt_email.Text + "','" + txt_phone.Text + "','" + dtp_birthday.Value + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Seller Added Successfully");

                display_data_grid_view(); // data grid view method
                clear();                  // data clear method              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();                    // This should be add. Else error will occur sometimes.
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text == "" || txt_password.Text == "" || txt_email.Text == "" || txt_phone.Text == "")
                {
                    MessageBox.Show("Missing Seller Information");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Register_Table1 SET Password = '" + txt_password.Text + "'," +
                        "Email = '" + txt_email.Text + "',PhoneNum = '" + txt_phone.Text + "' WHERE UserName = '" + txt_username.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Seller Edit Success");

                    display_data_grid_view(); // data grid view method
                    clear();                  // data clear method
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text == "" || txt_password.Text == "" || txt_email.Text == "" || txt_phone.Text == "")
                {
                    MessageBox.Show("Select Seller to Delete");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Seller_Table1 WHERE UserName = '" + txt_username.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Success");
                    con.Close();

                    display_data_grid_view(); // data grid view method
                    clear();                  // data clear method
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }                      
    }
}
