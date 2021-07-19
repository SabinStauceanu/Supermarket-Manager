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
using System.Media;

namespace Managemenntul_Supermarketului
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stauc\OneDrive\Documente\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        SoundPlayer splayer = new SoundPlayer("C:\\Users\\stauc\\Downloads\\mixkit-select-click-1109.wav");
        SoundPlayer eplayer = new SoundPlayer("C:\\Users\\stauc\\Downloads\\mixkit-click-error-1110.wav");

        

        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataProducts.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                splayer.Play();
                Con.Open();
                string query = "insert into ProductTbl values(" + txtProductId.Text + ",'" + txtProductName.Text + "','" + txtProductQuantity.Text + "','" + txtProductPrice.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added succesfully");
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                eplayer.Play();
                MessageBox.Show(ex.Message);

            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            btnProduct.Enabled = false;
            
            populate();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            this.Hide();
            category.Show();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            this.Hide();
            seller.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductId.Text == "" || txtProductName.Text == "" || txtProductQuantity.Text == "" || txtProductPrice.Text == "")
                {
                    eplayer.Play();
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    splayer.Play();
                    Con.Open();
                    string query = "update ProductTbl set ProdName='" + txtProductName.Text + "',ProdQty='" + txtProductQuantity.Text + "',ProdPrice='" + txtProductPrice.Text + "' where ProdId=" + txtProductId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product succesfuly updated");
                    Con.Close();
                    populate();
                    

                }
            }
            catch (Exception ex)
            {
                eplayer.Play();
                MessageBox.Show(ex.Message);

            }
        }

        private void dataProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductId.Text = dataProducts.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = dataProducts.SelectedRows[0].Cells[1].Value.ToString();
            txtProductQuantity.Text = dataProducts.SelectedRows[0].Cells[2].Value.ToString();
            txtProductPrice.Text = dataProducts.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductId.Text == "")
                {
                    eplayer.Play();
                    MessageBox.Show("Select The Product to Delete");

                }
                else
                {
                    splayer.Play();
                    Con.Open();
                    string query = "delete from ProductTbl where ProdId=" + txtProductId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted succesfully");
                    Con.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                eplayer.Play();
                MessageBox.Show(ex.Message);

            }
        }
    }
}
