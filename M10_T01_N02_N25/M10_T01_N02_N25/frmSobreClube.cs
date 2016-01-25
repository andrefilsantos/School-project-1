//-----------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using M10_T01_N02_N25.Properties;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public partial class frmSobreClube : Form
    {
        public int nSocios;
        public int nAtletas;

        //-----------------------------------------------------------
        public frmSobreClube()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------
        private void frmSobreOClube_Load(object sender, EventArgs e)
        {
            if (File.Exists("ProfilePhotos/" + Clube.Nome + "_Logo.png"))
                picLogoClube.Image = new Bitmap("ProfilePhotos/" + Clube.Nome + "_Logo.png");
            else
            {
                picLogoClube.Image = new Bitmap(Resources._5168fb83e1e34e0381bb67a80527c464_800);
            }
            lblNomeClube.Text = Clube.Nome;
            lblDataFundacao.Text = "Data de Fundação: " + Clube.DataFundacao.ToString("dd/MM/yyyy");
            lblNsocios.Text = "Número de Sócios: " + nSocios;
            lblNatletas.Text = "Número de Atletas: " + nAtletas;
            Backups();
            UpdateDados();
        }

        //-----------------------------------------------------------
        void Backups()
        {
            if (!File.Exists("ProfilePhotos/Presidente_Bck.jpg") && File.Exists("ProfilePhotos/Presidente.jpg"))
                File.Copy("ProfilePhotos/Presidente.jpg", "ProfilePhotos/Presidente_Bck.jpg");

            if (!File.Exists("ProfilePhotos/Treinador_Bck.jpg") && File.Exists("ProfilePhotos/Treinador.jpg"))
                File.Copy("ProfilePhotos/Treinador.jpg", "ProfilePhotos/Treinador_Bck.jpg");
        }

        //-----------------------------------------------------------
        void UpdateDados()
        {
            lblNomePresidente.Text = "Nome: " + Clube.Presidente.Nome;
            lblIdadePresidente.Text = "Idade: " + Clube.Presidente.Idade;
            lblRuaPresidente.Text = Clube.Presidente.MoradaPessoa.Rua;
            lblLocalidadePresidente.Text = Clube.Presidente.MoradaPessoa.Localidade;
            lblCpPresidente.Text = Clube.Presidente.MoradaPessoa.CodigoPostal;
            if (File.Exists("ProfilePhotos/Presidente_Bck.jpg"))
                picFotoPerfilPresidente.Image = new Bitmap("ProfilePhotos/Presidente_Bck.jpg");
            else
                picFotoPerfilPresidente.Image = new Bitmap("ProfilePhotos/DefaultProfilePhoto.jpg");

            //-----------------------------------------------------------
            lblNomeTreinador.Text = "Nome: " + Atleta.Treinador.Nome;
            lblIdadeTreinador.Text = "Idade: " + Atleta.Treinador.Idade;
            lblRuaTreinador.Text = Atleta.Treinador.MoradaPessoa.Rua;
            lblLocalidadeTreinador.Text = Atleta.Treinador.MoradaPessoa.CodigoPostal;
            lblCpTreinador.Text = Atleta.Treinador.MoradaPessoa.CodigoPostal;
            if (File.Exists("ProfilePhotos/Treinador_Bck.jpg"))
                picFotoPerfilTreinador.Image = new Bitmap("ProfilePhotos/Treinador_Bck.jpg");
            else
                picFotoPerfilTreinador.Image = new Bitmap("ProfilePhotos/DefaultProfilePhoto.jpg");
        }

        //-----------------------------------------------------------
        private void btnEditarTreinador_Click(object sender, EventArgs e)
        {
            var login = new frmLogin();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                if (login.Username == "Administrator" && login.Password == "oaefeott")
                {
                    var edit = new frmEditar("Editar", true, "treinador") { DadosPessoa = Atleta.Treinador };
                    var result = edit.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Atleta.Treinador.Nome = edit.DadosPessoa.Nome;
                        Atleta.Treinador.DataNasc = edit.DadosPessoa.DataNasc;
                        Atleta.Treinador.MoradaPessoa = edit.DadosPessoa.MoradaPessoa;
                        UpdateDados();
                    }
                }
                else
                {
                    MessageBox.Show("Utilizador ou Password Incorretos \nPor favor, contacte o administrador do sistema para obter os dados.", "Login", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------------------------------
        private void btnEditarPresidente_Click(object sender, EventArgs e)
        {
            var login = new frmLogin();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                if (login.Username == "Administrator" && login.Password == "oaefeott")
                {
                    var edit = new frmEditar("Editar", true, "presidente") { DadosPessoa = Clube.Presidente };
                    var startName = Clube.Presidente.Nome;
                    var result = edit.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        Clube.Presidente.Nome = edit.DadosPessoa.Nome;
                        Clube.Presidente.DataNasc = edit.DadosPessoa.DataNasc;
                        Clube.Presidente.MoradaPessoa = edit.DadosPessoa.MoradaPessoa;
                        UpdateDados();
                    }
                }
                else
                {
                    MessageBox.Show("Utilizador ou Password Incorretos.\nPor favor, contacte o administrador do sistema para obter os dados.", "Login", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------------------------------
        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
