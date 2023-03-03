﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise03_DataBindingComplex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGridButton_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(northwindDataSet1.Products);
            BindingSource productsBindingSource = new BindingSource(northwindDataSet1, "Products");
            ProductsGrid.DataSource = productsBindingSource;
            bindingNavigator1.BindingSource = productsBindingSource;
        }
    }
}
