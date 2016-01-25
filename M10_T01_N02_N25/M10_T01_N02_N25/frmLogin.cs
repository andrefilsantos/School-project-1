using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10_T01_N02_N25
{
    public partial class frmLogin : Form
    {
        public string Username;
        public string Password;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblAutNec.Text = "A ação que pretende executar requer permissões de administrador. \n Por favor, identifique-se";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Password = txtPassword.Text;
            Hide();
        }
    }
}
