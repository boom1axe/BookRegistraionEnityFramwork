﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistraionEnityFramwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCustomerList();
        }

        /// <summary>
        /// Populates customer list from the database
        /// </summary>
        private void PopulateCustomerList()
        {
            List<Customer> customers = CustomerDB.GetCustomers();

            cboCustomers.DataSource = customers;
            cboCustomers.DisplayMember = nameof(Customer.FullName);
        }
    }
}
