using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210929
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Szamol_Click(object sender, EventArgs e)
        {

            int honap = Convert.ToInt32(txbhonapszama.Text);

            if (honap > 12 || honap < 0)
            {
                MessageBox.Show("nincs ilyen hónap!");
            }
            else if (honap == 1 || honap == 2 || honap == 12)
            {

                lblevszak.Text = "Tél";
                lblevszak.Visible = true;


            }
            else if (honap == 3 || honap == 4 || honap == 5)
            {

                lblevszak.Text = "Tavasz";
                lblevszak.Visible = true;


            }
            else if (honap == 6 || honap == 7 || honap == 8)
            {

                lblevszak.Text = "Nyár";
                lblevszak.Visible = true;


            }
            else if (honap == 9 || honap == 10 || honap == 11)
            {

                lblevszak.Text = "Ősz";
                lblevszak.Visible = true;


            }







        }
    }
}
