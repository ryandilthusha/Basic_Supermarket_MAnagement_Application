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
    public partial class Categories_Form : Form
    {
        public Categories_Form()
        {
            InitializeComponent();

            display_data_grid_view();   // Data Grid view from the start
        }

        SqlCommand cmd;
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\market_db.mdf;Integrated Security=True;Connect Timeout=30");


        // For data grid view
        SqlDataAdapter adpt;        
        DataTable dt;        

        private void Categories_Form_Load(object sender, EventArgs e)
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

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            Seller_Form sell = new Seller_Form();
            sell.Show();
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
            txt_name.Text = "";
            txt_description.Text = "";
        } 
        

        public void display_data_grid_view()    //For the Data Grid View newly created method
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Category_Table1 ", con);
                adpt.Fill(dt);
                dgv_categories.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Data Grid View Cell Double Click Event for Update
        private void dgv_categories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_categories.SelectedRows[0].Cells[1].Value.ToString();
            txt_description.Text = dgv_categories.SelectedRows[0].Cells[2].Value.ToString();
        }


        //***********************************ADD********EDIT********DELETE**************************************************************************  

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Category_Table1 (Category_Name,Category_Description) VALUES('" + txt_name.Text + "','" + txt_description.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Added Successfully");

                display_data_grid_view(); // data grid view method
                clear();                  // data clear method
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "" || txt_description.Text == "")
                {
                    MessageBox.Show("Missing Category Information");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Category_Table1 SET Category_Description = '" + txt_description.Text + "' WHERE Category_Name = '" + txt_name.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category Edit Success");

                    display_data_grid_view(); // data grid view method
                    clear();                  // data clear method
                }
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
                if (txt_name.Text == "")
                {
                    MessageBox.Show("Select Category to Delete");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Category_Table1 WHERE Category_Name ='" + txt_name.Text + "' AND Category_Description ='" + txt_description.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    con.Close();

                    display_data_grid_view(); // data grid view method       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      
    }
}
