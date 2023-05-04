using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Appliances_Management_System.Forms
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {







            try
            {
                // Create a connection object and open it
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=Newproductlist.mdb");
                con.Open();

                // Check if any of the input fields are empty
                if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtProductQuantity.Text) || string.IsNullOrWhiteSpace(txtBrand.Text) || string.IsNullOrWhiteSpace(comboBoxCategory.Text) || string.IsNullOrWhiteSpace(txtProductPrice.Text))
                {
                    // If any field is empty, display an error message and exit the try block
                    MessageBox.Show("Please fill in all the fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the product quantity is a positive integer
                int quantity;
                if (int.TryParse(txtProductQuantity.Text, out quantity) && quantity > 0)
                {
                    // If the product quantity is valid, create a command object and execute the query
                    string sql = "INSERT INTO tbl_productlist (product_name, product_quantity, brand, category, product_price) VALUES (@product_name, @product_quantity, @brand, @category, @product_price)";
                    OleDbCommand command = new OleDbCommand(sql, con);
                    command.Parameters.AddWithValue("@product_name", txtProductName.Text);
                    command.Parameters.AddWithValue("@product_quantity", quantity);
                    command.Parameters.AddWithValue("@brand", txtBrand.Text);
                    command.Parameters.AddWithValue("@category", comboBoxCategory.Text);
                    command.Parameters.AddWithValue("@product_price", txtProductPrice.Text);
                    command.ExecuteNonQuery();

                    // Clear the input fields and display a success message
                    txtProductName.Text = "";
                    txtProductQuantity.Text = "";
                    txtBrand.Text = "";
                    comboBoxCategory.Text = "";
                    txtProductPrice.Text = "";
                    MessageBox.Show("Product has been added successfully.", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If the product quantity is invalid, display an error message
                    MessageBox.Show("Please enter a valid positive integer for the product quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Close the connection
                con.Close();
            }
            catch (Exception ex)
            {
                // If an exception occurs, display the error message
                MessageBox.Show(ex.Message);
            }
















            /* try
             {
                 OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=productlist.mdb");
                 //OleDbCommand cmd = new OleDbCommand();
                 OleDbDataAdapter da = new OleDbDataAdapter();

                 con.Open();

                 string sql = "INSERT INTO tbl_productlist (product_name, product_quantity, brand, category, product_price) VALUES (@product_name, @product_quantity, @brand, @category, @product_price)";
                 OleDbCommand command = new OleDbCommand(sql, con);
                 command.Parameters.AddWithValue("@product_name", txtProductName.Text);
                 command.Parameters.AddWithValue("@product_quantity", txtProductQuantity.Text);
                 command.Parameters.AddWithValue("@brand", txtBrand.Text);
                 command.Parameters.AddWithValue("@category", comboBoxCategory.Text);
                 command.Parameters.AddWithValue("@product_price", txtProductPrice.Text);
                 command.ExecuteNonQuery();

                 con.Close();

                 txtProductName.Text = "";
                 txtProductQuantity.Text = "";
                 txtBrand.Text = "";
                 comboBoxCategory.Text = "";
                 txtProductPrice.Text = "";


                 MessageBox.Show("Product has been Added", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             } */

            // TESTING ADDING DATABASE 
            /* if (txtProductName.Text == "" && txtProductQuantity.Text == "" && txtBrand.Text =="" && txtCategory.Text == "" && txtProductPrice.Text == "")
               {
                   MessageBox.Show("Please Enter Product", "Adding product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }

               else if (txtProductName.Text == "" && txtProductQuantity.Text == "" && txtBrand.Text == "" && txtCategory.Text == "" && txtProductPrice.Text == "")
               {
                   con.Open();
                   string Addproname = "INSERT INTO tbl_product VALUES ('" + txtProductName.Text + "', '" + txtProductQuantity.Text + "' , '" + txtBrand.Text + "', '" + txtCategory.Text + "' , '" + txtProductPrice.Text + "')";
                   cmd = new OleDbCommand(Addproname, con);
                   cmd.ExecuteNonQuery();
                   con.Close();

                   txtProductName.Text = "";
                   txtProductQuantity.Text = "";
                   txtBrand.Text = "";
                   txtCategory.Text = "";
                   txtProductPrice.Text = "";

                   MessageBox.Show("Product Has been Added", "Product add Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               } 

               else
               {
                   MessageBox.Show("Please Enter Product", "Add product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
              */
        }
    }
}
