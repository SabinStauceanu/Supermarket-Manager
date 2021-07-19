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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stauc\OneDrive\Documente\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        SoundPlayer splayer = new SoundPlayer("C:\\Users\\stauc\\Downloads\\mixkit-select-click-1109.wav");
        SoundPlayer eplayer = new SoundPlayer("C:\\Users\\stauc\\Downloads\\mixkit-click-error-1110.wav");

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                splayer.Play();
                Con.Open();
                string query = "insert into CategoryTbl values(" + txtCatID.Text + ",'" + txtCatName.Text + "','" + txtCatDesc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added succesfully");
                Con.Close();
                populate();
                
            }
            catch(Exception ex)
            {
                eplayer.Play();
                MessageBox.Show(ex.Message);
                
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataCategory.DataSource = ds.Tables[0];
            Con.Close();
            
        }

        private void dataCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCatID.Text = dataCategory.SelectedRows[0].Cells[0].Value.ToString();
            txtCatName.Text = dataCategory.SelectedRows[0].Cells[1].Value.ToString();
            txtCatDesc.Text = dataCategory.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketdbDataSet.CategoryTbl' table. You can move, or remove it, as needed.
            this.categoryTblTableAdapter.Fill(this.supermarketdbDataSet.CategoryTbl);
            populate();
            btnSelling.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCatID.Text == "")
                {
                    eplayer.Play();
                    MessageBox.Show("Select The Category to Delelte");
                    
                }
                else
                {
                    splayer.Play();
                    Con.Open();
                    string query = "delete from CategoryTbl where CatId=" + txtCatID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted succesfully");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCatID.Text == "" || txtCatName.Text == "" || txtCatDesc.Text == "")
                {
                    eplayer.Play();
                    MessageBox.Show("Missing Information");
                    
                }
                else
                {
                    splayer.Play();
                    Con.Open();
                    string query = "update CategoryTbl set CatName='" + txtCatName.Text + "',CatDesc='" + txtCatDesc.Text + "' where CatId=" + txtCatID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category succesfuly updated");
                    Con.Close();
                    populate();
                    
                }
            }
            catch(Exception ex)
            {
                eplayer.Play();
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            this.Hide();
            products.Show();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            this.Hide();
            seller.Show();
        }
    }
}
