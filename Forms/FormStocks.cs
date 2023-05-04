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

namespace Appliances_Management_System.Forms
{
    public partial class FormStocks : Form
    {
        public FormStocks()
        {
            InitializeComponent();
        }
        
        private void FormStocks_Load(object sender, EventArgs e)
        {
           


            // Create a connection object and open it
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=Newproductlist.mdb");
            con.Open();

            // Create a command object and execute a query to retrieve the data
            string sql = "SELECT * FROM tbl_productlist";
            OleDbCommand command = new OleDbCommand(sql, con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Bind the DataTable to the DataGridView control
            dataGridView1.DataSource = table;

            // Close the connection
            con.Close();






        }

        private void tblproductlistBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is currently selected
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Get the name of the product to delete
                string productName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                // Prompt the user to confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete the product '" + productName + "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete the row from the database
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=Newproductlist.mdb");
                    con.Open();
                    string sql = "DELETE FROM tbl_productlist WHERE product_name = @product_name";
                    OleDbCommand command = new OleDbCommand(sql, con);
                    command.Parameters.AddWithValue("@product_name", productName);
                    command.ExecuteNonQuery();
                    con.Close();

                    // Remove the row from the DataGridView
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    // Display a success message
                    MessageBox.Show("The product '" + productName + "' has been deleted.", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // If no row is selected, display an error message
                MessageBox.Show("Please select a product to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            /* Add a new row to the DataGridView
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            // Set the values of other columns
            row.Cells["product_name"].Value = txtProductName.Text;
            row.Cells["product_quantity"].Value = txtProductQuantity.Text;
            row.Cells["brand"].Value = txtBrand.Text;
            row.Cells["category"].Value = comboBoxCategory.Text;
            row.Cells["product_price"].Value = txtProductPrice.Text;

            // Calculate the total
            double quantity = Convert.ToDouble(txtProductQuantity.Text);
            double price = Convert.ToDouble(txtProductPrice.Text);
            double total = quantity * price;
            row.Cells["product_total"].Value = total.ToString();

            // Add the new row to the DataGridView
            dataGridView1.Rows.Add(row); */
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the selected row
    if (dataGridView1.SelectedRows.Count > 0)
    {
        DataGridViewRow row = dataGridView1.SelectedRows[0];

        // Check if any of the input fields are empty
        if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtProductQuantity.Text) || string.IsNullOrWhiteSpace(txtBrand.Text) || string.IsNullOrWhiteSpace(comboBoxCategory.Text) || string.IsNullOrWhiteSpace(txtProductPrice.Text))
        {
            // If any field is empty, display an error message and exit the method
            MessageBox.Show("Please fill in all the fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if the product quantity is a positive integer
        int quantity;
        if (int.TryParse(txtProductQuantity.Text, out quantity) && quantity > 0)
        {
            // If the product quantity is valid, update the values of the selected row
            row.Cells["product_name"].Value = txtProductName.Text;
            row.Cells["product_quantity"].Value = txtProductQuantity.Text;
            row.Cells["brand"].Value = txtBrand.Text;
            row.Cells["category"].Value = comboBoxCategory.Text;
            row.Cells["product_price"].Value = txtProductPrice.Text;

            // Clear the input fields and display a success message
            txtProductName.Text = "";
            txtProductQuantity.Text = "";
            txtBrand.Text = "";
            comboBoxCategory.Text = "";
            txtProductPrice.Text = "";
            MessageBox.Show("Product has been updated successfully.", "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // If the product quantity is invalid, display an error message
            MessageBox.Show("Please enter a valid positive integer for the product quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    else
    {
        // If no row is selected, display an error message
        MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_productlistTableAdapter3.FillBy(this.newproductlistDataSet.tbl_productlist);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
