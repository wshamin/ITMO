﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class EditPersonForm : Form
    {
        Person p;
        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }
        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }
        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value; }
        }
        //public EditPersonForm()
        //{
        //    InitializeComponent();
        //}
        public EditPersonForm(Person p)
        {
            InitializeComponent();

            this.p = p;
            this.firstNameTextBox.Text = p.FirstName;
            this.lastNameTextBox.Text = p.LastName;
            this.ageNumericUpDown.Value = p.Age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.FirstName = this.FirstName;
            p.LastName = this.LastName; 
            p.Age = this.Age;
            MessageBox.Show("Сотрудник: " + p.ToString());
        }
    }
}
