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
    public partial class Seller_Selling : Form
    {
        public Seller_Selling()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\market_db.mdf;Integrated Security=True;Connect Timeout=30");

        // for data grid view
        SqlDataAdapter adpt;
        SqlDataReader dr;
        DataTable dt;
        SqlCommand cmd;

        private void Seller_Selling_Load(object sender, EventArgs e)
        {

            display_data_grid_view();

            display_data_grid_view_BILLS();

            fillcombo1();                       //To fill combo box with category names which in Category_Table1

            date_lbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

            lbl_seller.Text = Login_Form.SellerName;        //To fetch seller name from Login Form to Selling Form --> step3    (Direct Link with Login Form)

        }

        //************************OTHER   BUTTONS********************************************************************************************************************************  
        
        private void lbl_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Product_Name, Product_Price FROM Product_Table1 WHERE Product_Category ='" + cmb_refresh_category.SelectedValue + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_products.DataSource = dt;
        }

        private void pic_box_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form log = new Login_Form();
            log.Show();
        }



        //Print Document Button coding
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SUPER MARKET", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + dgv_bill.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + dgv_bill.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + dgv_bill.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amounte: " + dgv_bill.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));

            e.Graphics.DrawString("Thank You!", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(230, 230));
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
          


        //************************OTHER   METHODS********************************************************************************************************************************    

        public void clear()
        {
            txt_billid.Text = "";
            txt_product.Text = "";
            txt_price.Text = "";
            txt_quantity.Text = "";
        }

        public void display_data_grid_view()    //For the Data Grid View newly created method
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT Product_Name, Product_Price FROM Product_Table1 ", con);
                adpt.Fill(dt);
                dgv_products.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void display_data_grid_view_BILLS()    //For Bills the Data Grid View --> newly created method
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Bill_Table", con);
                adpt.Fill(dt);
                dgv_bill.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_product.Text = dgv_products.SelectedRows[0].Cells[0].Value.ToString();             
            txt_price.Text = dgv_products.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void fillcombo1()
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


        int finaltotal = 0;   //This put here because otherwise this will caught into same loop which takes finaltotal as 0 everytime.

        private void btn_add_product_Click(object sender, EventArgs e)
        {           

            if (txt_product.Text == "" || txt_quantity.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int n = 0;
                int total = Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_quantity.Text);
                //Final total = 0 didn't mention here. because everytime when seller add products, the final total will be 0 everytime.

                //Create table in Data Grid View
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv_order);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txt_product.Text;
                newRow.Cells[2].Value = txt_price.Text;
                newRow.Cells[3].Value = txt_quantity.Text;
                newRow.Cells[4].Value = total;
                dgv_order.Rows.Add(newRow);

                finaltotal = finaltotal + total;

                lbl_total.Text = "Rs " + finaltotal;
            }          
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Bill_Table (Bill_ID,Seller_Name,Bill_Date,Total) VALUES('" + txt_billid.Text + "'," +
                    "'" + lbl_seller.Text + "','" + date_lbl.Text + "','" + lbl_total.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Order Added Successfully");

                display_data_grid_view_BILLS(); // data grid view method
                clear();                  // data clear method        

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void pic_box_logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form log = new Login_Form();
            log.Show();
        }
    }
}
