﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte  sayac = 0;
            byte sayi;
            sayi = Convert.ToByte(textBox1.Text);
            listBox1.Items.Clear();
            while (sayac < sayi)
            
            {
                listBox1.Items.Add("serkan");
                sayac++;
            }
            

        }
    }
}
