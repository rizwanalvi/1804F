﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sTDDETAILSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTDDETAILSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aPTECHDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPTECHDBDataSet.STDDETAILS' table. You can move, or remove it, as needed.
            this.sTDDETAILSTableAdapter.Fill(this.aPTECHDBDataSet.STDDETAILS);

        }
    }
}
