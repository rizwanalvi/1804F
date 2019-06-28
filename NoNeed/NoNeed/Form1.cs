using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoNeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnDoorBell(object sender, EventArgs e)
        {
            Button WhoisThere = (Button)sender;
            MessageBox.Show(WhoisThere.Parent.Text);
        }
    }
}
