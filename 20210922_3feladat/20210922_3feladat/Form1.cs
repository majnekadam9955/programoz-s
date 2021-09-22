﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210922_3feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                int r = Convert.ToInt32(txbsugar.Text);
                int d = 2 * r;
                double K = Math.PI * d;
                int r2 = r * r;
                double T = Math.PI * r2; 
                lblkerulet.Visible = true;
                lblterulet.Visible = true;
                txbkerulet.Text = Convert.ToString(K);
                txbterulet.Text = Convert.ToString(T);

            }
            catch (Exception)
            {

                MessageBox.Show("nem megfelelő értéket írtál be");

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                int r = Convert.ToInt32(txbsugar.Text);
                int r2 = r * r;
                int r3 = r * r * r;
                double K = 4 * r2 * Math.PI;
                double osztas1 = 4 * r3 * Math.PI;
                double T = osztas1 % 3;


                lblkerulet.Text = "A gömb felülete";
                lblterulet.Text = "A gömb térfogata";
                lblkerulet.Visible = true;
                lblterulet.Visible = true;
                txbkerulet.Text = Convert.ToString(K);
                txbterulet.Text = Convert.ToString(T);

            }
            catch (Exception)
            {

                MessageBox.Show("nem jó számot adtál meg");
                
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




//𝑉 = 4⋅𝑟3𝜋 / 3.