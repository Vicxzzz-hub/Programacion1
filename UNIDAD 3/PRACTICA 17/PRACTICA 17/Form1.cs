﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = int.Parse(textBox3.Text);
            if (A > B)
                if (B > C)
                    if (B > C)
                    {
                        textBox4.Text = A.ToString();
                        textBox5.Text = B.ToString();
                        textBox6.Text = C.ToString();
                    }
                    else
                    {
                        textBox4.Text = A.ToString();
                        textBox5.Text = C.ToString();
                        textBox6.Text = B.ToString();
                    }
                else
                {
                    textBox4.Text = C.ToString();
                    textBox5.Text = A.ToString();
                    textBox6.Text = B.ToString();
                }
            else
                 if (B > C)
                if (A > C)
                {
                    textBox4.Text = B.ToString();
                    textBox5.Text = A.ToString();
                    textBox6.Text = C.ToString();
                }
                else
                {
                    textBox4.Text = B.ToString();
                    textBox5.Text = C.ToString();
                    textBox6.Text = A.ToString();
                }
            else
            {
                textBox4.Text = C.ToString();
                textBox5.Text = B.ToString();
                textBox6.Text = A.ToString();
            }
        }
    }
}
