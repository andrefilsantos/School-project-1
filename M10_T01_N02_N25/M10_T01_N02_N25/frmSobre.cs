//-----------------------------------------------------------
using System;
using System.Windows.Forms;
using System.Media;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public partial class frmSobre : Form
    { 
        //-----------------------------------------------------------
        public frmSobre()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------
        private void btnSobreOK_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //-----------------------------------------------------------
        private void frmSobre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        //-----------------------------------------------------------
        private void frmSobre_Activated(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        //-----------------------------------------------------------
        private void frmSobre_Load(object sender, EventArgs e)
        {

        }
    }
}
