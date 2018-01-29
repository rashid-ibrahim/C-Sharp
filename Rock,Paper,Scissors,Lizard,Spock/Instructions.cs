using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        //Load event for this form.
        private void Instructions_Load(object sender, EventArgs e)
        {
            //Sets the form to always on top.
            this.TopMost = true;
        }

        //Click event for the OK button.
        private void btnOK_Click(object sender, EventArgs e)
        {
            //Closes this form.
            this.Close();
        }
    }
}
