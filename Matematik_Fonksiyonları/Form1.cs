﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Fonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi= Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Abs(sayi).ToString(); //Mutlak

            label2.Text=Math.Ceiling(sayi).ToString(); //Ceil 00001 bile geçse üste yuvarlar

            label2.Text=Math.Floor(sayi).ToString(); //floor aşağa yuvarlar
            label2.Text=Math.Pow(sayi, 2).ToString();// girilen sayının üssü
            label2.Text=Math.Sqrt(sayi).ToString();//karekök alma
            label2.Text=Math.PI.ToString();  
            label2.Text=Math.Round(sayi).ToString();


        }
    }
}
