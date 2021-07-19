using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managemenntul_Supermarketului
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stauc\OneDrive\Documente\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        SoundPlayer splayer = new SoundPlayer("C:\\Users\\stauc\\Downloads\\mixkit-select-click-1109.wav");
        SoundPlayer eplayer = new SoundPlayer("C:\\Users\\stauc\\Downloads\\mixkit-click-error-1110.wav");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                splayer.Play();
                Con.Open();
                string query = "insert into SellerTbl values(" + txtSellerId.Text + ",'" + txtSellerName.Text + "'," + txtSellerAge.Text + ",'"+txtSellerPhone.Text+"','"+txtSellerPass.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller added succesfully");
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                eplayer.Play();
                MessageBox.Show(ex.Message);

            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataSeller.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void dataSeller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSellerId.Text = dataSeller.SelectedRows[0].Cells[0].Value.ToString();
            txtSellerName.Text = dataSeller.SelectedRows[0].Cells[1].Value.ToString();
            txtSellerAge.Text = dataSeller.SelectedRows[0].Cells[2].Value.ToString();
            txtSellerPhone.Text = dataSeller.SelectedRows[0].Cells[3].Value.ToString();
            txtSellerPass.Text = dataSeller.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            btnSeller.Enabled = false;
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSellerId.Text == "")
                {
                    eplayer.Play();
                    MessageBox.Show("Select The Seller to Delete");

                }
                else
                {
                    splayer.Play();
                    Con.Open();
                    string query = "delete from SellerTbl where SellerId=" + txtSellerId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller deleted succesfully");
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
                if (txtSellerId.Text == "" || txtSellerName.Text == "" || txtSellerAge.Text == "")
                {
                    eplayer.Play();
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    splayer.Play();
                    Con.Open();
                    string query = "update SellerTbl set SellerName='" + txtSellerName.Text + "',SellerAge='" + txtSellerAge.Text + "',SellerPhone='"+txtSellerPhone.Text+"',SellerPass='"+txtSellerPass.Text+"' where SellerId=" + txtSellerId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller succesfuly updated");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            this.Hide();
            products.Show();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            this.Hide();
            category.Show();
        }
    }
}
