﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();
            pictureBox1.Image = Image.FromFile("../../image/ee7d130e4933060ea68d34c45e511ea6.jpg");

        }
    }
}
