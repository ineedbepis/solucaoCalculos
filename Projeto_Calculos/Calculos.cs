﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculos
{
    public partial class Calculos : Form
    {
        public Calculos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "?";
            txtN1.Focus();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double  a, b;

            try
            {
                lblSinal.Text = "+";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                lblResultado.Text = (a + b).ToString();
            } 
            catch (FormatException)
            {
                MessageBox.Show("Preencha corretamente os números!");
                lblSinal.Text = "?";
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
            double a, b;
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                lblResultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha corretamente os números!");
                lblSinal.Text = "?";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "X";
            double a, b;
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha corretamente os números!");
                lblSinal.Text = "?";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "/";
            double a, b;
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                if (b == 0)
                {
                    MessageBox.Show("Divisão por zero não é permitida!");
                    lblResultado.Text = "?";
                }
                else if (a == 0)
                {
                    MessageBox.Show("Divisão por zero não é permitida!");
                    lblResultado.Text = "0";
                }
                else
                {
                    lblResultado.Text = (a / b).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha corretamente os números!");
                lblSinal.Text = "?";
            }

        }
    }
}
