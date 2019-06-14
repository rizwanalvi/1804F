using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.ServiceReference1;
using Testing.ServiceReference2;
namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorSoapClient sp = new CalculatorSoapClient();
         int i =   sp.Add(int.Parse(textBox1.Text), int.Parse(textBox1.Text));
            MessageBox.Show(i.ToString());
        }
    }
}
