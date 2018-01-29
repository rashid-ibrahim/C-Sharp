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
    public partial class LoadGameType : Form
    {
        public LoadGameType()
        {
            InitializeComponent();
        }

        //Load event for this form.
        private void LoadGameType_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            //Sets game state.
            Main.Variables.GameType = 1;
            //Shows main form.
            Visible = true;
            //Hides this form.
            this.Visible = false;
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            //Sets game state.
            Main.Variables.GameType = 2;
            //Shows main form
            Visible = true;
            //Hides this form.
            this.Visible = false;
        }
    }
}
