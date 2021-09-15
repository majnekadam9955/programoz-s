using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210915
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnosszeadas_Click(object sender, EventArgs e)
        {
            int adat1 = Convert.ToInt32(txbadat1.Text);
            int adat2 = Convert.ToInt32(txbadat2.Text);
            int eredmeny;

            eredmeny = adat1 + adat2;

            txberedmeny.Text = Convert.ToString(eredmeny);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close;
        }

        private void Btnkivonas_Click(object sender, EventArgs e)
        {
            int adat1 = Convert.ToInt32(txbadat1.Text);
            int adat2 = Convert.ToInt32(txbadat2.Text);
            int eredmeny;

            eredmeny = adat1 - adat2;

            txberedmeny.Text= Convert.ToString(eredmeny);
        }

        private void Btnszorzas_Click(object sender, EventArgs e)
        {
            int adat1 = Convert.ToInt32(txbadat1.Text);
            int adat2 = Convert.ToInt32(txbadat2.Text);
            int eredmeny;

            eredmeny = adat1 * adat2;

            txberedmeny.Text = Convert.ToString(eredmeny);

        }
    }
}
