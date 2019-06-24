using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NexusComputers
{
    class MyForm : Form
    {
        public override Color BackColor
        {
            get
            {
                return Color.Red;
            }

            set
            {
                base.BackColor = this.BackColor;
            }
        }
    }
}
