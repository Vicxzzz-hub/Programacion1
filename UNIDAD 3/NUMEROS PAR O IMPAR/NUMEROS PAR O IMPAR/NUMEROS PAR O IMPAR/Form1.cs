﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUMEROS_PAR_O_IMPAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            if (numero % 2 == 0)
            {
                listBox1.Items.Add(numero + "Par");
            }
        else
            {
                listBox1.Items.Add(numero + "Impar");
            }
            textBox1.Text = " ";
            textBox1.Focus();
        }
    }
}
