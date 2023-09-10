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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }               

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\market_db.mdf;Integrated Security=True;Connect Timeout=30");

        // For data grid view
        SqlDataAdapter adpt;
        SqlDataReader dr;
        DataTable dt;
        SqlCommand cmd;

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            fillcombo1();   //To fill combo box1 with category names which in Category_Table1
            fillcombo2();   //To fill combo box2 with category names which in Category_Table1
            display_data_grid_view(); // data grid view method   
        }

        //************************OTHER   BUTTONS********************************************************************************************************************************  

        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void btn_category_Click(object sender, EventArgs e)
        {
            Categories_Form cat = new Categories_Form();
            cat.Show();
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
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Product_Table1 WHERE Product_Category ='" + cmb_refresh_category.SelectedValue + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_products.DataSource = dt;
        }
        

        //************************OTHER   METHODS********************************************************************************************************************************    

        public void clear()
        {
            txt_name.Text = "";
            txt_price.Text = "";
            txt_quantity.Text = "";
        }

        public void display_data_grid_view()    //For the Data Grid View newly created method
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Product_Table1 ", con);
                adpt.Fill(dt);
                dgv_products.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgv_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_products.SelectedRows[0].Cells[1].Value.ToString();
            txt_quantity.Text = dgv_products.SelectedRows[0].Cells[2].Value.ToString();
            txt_price.Text = dgv_products.SelectedRows[0].Cells[3].Value.ToString();
            cmb_category.Text = dgv_products.SelectedRows[0].Cells[4].Value.ToString();
        }



        //Thid method will bind the combobox with the database
        private void fillcombo1()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Category_Name FROM Category_Table1", con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cmb_category", typeof(string));
            dt.Load(dr);
            cmb_category.ValueMember = "Category_Name";
            cmb_category.DataSource = dt;
            con.Close();
        }
        private void fillcombo2()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Category_Name FROM Category_Table1", con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cmb_refresh_category", typeof(string));
            dt.Load(dr);
            cmb_refresh_category.ValueMember = "Category_Name";
            cmb_refresh_category.DataSource = dt;
            con.Close();
        }
        
        

        //***********************************ADD********EDIT********DELETE**************************************************************************  

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Product_Table1 (Product_Name,Product_Quantity,Product_Price,Product_Category) VALUES('" + txt_name.Text + "'," +
                    "'" + txt_quantity.Text + "','" + txt_price.Text + "','" + cmb_category.SelectedValue.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product Added Successfully");

                display_data_grid_view(); // data grid view method
                clear();                  // data clear method        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "" || txt_price.Text == "" || txt_quantity.Text == "")
                {
                    MessageBox.Show("Missing Product Information");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Product_Table1 SET Product_Price = '" + txt_price.Text + "'," +
                        "Product_Quantity = '" + txt_quantity.Text + "' WHERE Product_Name = '" + txt_name.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product Edit Success");

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
                if (txt_name.Text == "" || txt_price.Text == "" || txt_quantity.Text == "")
                {
                    MessageBox.Show("Select Product to Delete");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Product_Table1 WHERE Product_Name = '" + txt_name.Text + "'", con);
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

