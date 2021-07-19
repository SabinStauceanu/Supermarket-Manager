using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managemenntul_Supermarketului
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progresionBar.Value = startpoint;
            if(progresionBar.Value == 10 || progresionBar.Value == 40 || progresionBar.Value == 70)
            {
                lblLoading.Text = "Loading.";
            }
            if (progresionBar.Value == 20 || progresionBar.Value == 50 || progresionBar.Value == 80)
            {
                lblLoading.Text = "Loading..";
            }
            if (progresionBar.Value == 30 || progresionBar.Value == 60 || progresionBar.Value == 90)
            {
                lblLoading.Text = "Loading...";
            }
            if (progresionBar.Value == 100)
            {
                progresionBar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
