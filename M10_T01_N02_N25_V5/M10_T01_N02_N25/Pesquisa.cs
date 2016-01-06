using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public partial class frmPesquisa : Form
    {
        //TODO: Get the search working

        //-----------------------------------------------------------
        public frmPesquisa()
        {
            InitializeComponent();
            pnlbckResultados.Visible = false;
        }

        //-----------------------------------------------------------
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //-----------------------------------------------------------
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlbckResultados.Visible = true;
        }

        //-----------------------------------------------------------
        private void frmPesquisa_Load(object sender, EventArgs e)
        {

        }
    }
}
