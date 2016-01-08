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
    public partial class frmSobreOClube : Form
    {
        //-----------------------------------------------------------
        public frmSobreOClube()
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
            Duplicate();
            UpdateDados();
        }

        //-----------------------------------------------------------
        private void btnEditarPresidente_Click(object sender, EventArgs e)
        {
            var edit = new Editar("Editar", true) { DadosPessoa = Clube.Presidente };
            var startName = Clube.Presidente.Nome;
            var result = edit.ShowDialog();
            if (result == DialogResult.OK)
            {
                Clube.Presidente.Nome = edit.DadosPessoa.Nome;
                Clube.Presidente.DataNasc = edit.DadosPessoa.DataNasc;
                Clube.Presidente.MoradaPessoa = edit.DadosPessoa.MoradaPessoa;
                UpdateDados();
            }
            try
            {
                util.GC_CLEANUP();
                File.Move("ProfilePhotos/" + startName + "_MF.jpg", "ProfilePhotos/" + Clube.Presidente.Nome + "_MF.jpg");

            }
            catch (Exception)
            {
                MessageBox.Show("Erro...", "", MessageBoxButtons.OK);
                throw;
            }
            UpdateDados();
        }

        //-----------------------------------------------------------
        void Duplicate()
        {
            if (!File.Exists("ProfilePhotos/" + Clube.Presidente.Nome + "_MF.jpg") && File.Exists("ProfilePhotos/" + Clube.Presidente.Nome + ".jpg"))
            {
                File.Copy("ProfilePhotos/" + Clube.Presidente.Nome + ".jpg", "ProfilePhotos/" + Clube.Presidente.Nome + "_MF.jpg");
            }

            if (!File.Exists("ProfilePhotos/" + Atleta.Treinador.Nome + "_MF.jpg") && File.Exists("ProfilePhotos/" + Atleta.Treinador.Nome + ".jpg"))
            {
                File.Copy("ProfilePhotos/" + Atleta.Treinador.Nome + ".jpg", "ProfilePhotos/" + Atleta.Treinador.Nome + "_MF.jpg");
            }
        }

        //-----------------------------------------------------------
        void UpdateDados()
        {
            lblNomePresidente.Text = "Nome: " + Clube.Presidente.Nome;
            lblIdadePresidente.Text = "Idade: " + Clube.Presidente.Idade;
            lblRuaPresidente.Text = Clube.Presidente.MoradaPessoa.Rua;
            lblLocalidadePresidente.Text = Clube.Presidente.MoradaPessoa.Localidade;
            lblCpPresidente.Text = Clube.Presidente.MoradaPessoa.CodigoPostal;
            if (File.Exists("ProfilePhotos/" + Clube.Presidente.Nome + "_MF.jpg"))
                picFotoPerfilPresidente.Image = new Bitmap("ProfilePhotos/" + Clube.Presidente.Nome + "_MF.jpg");
            else
                picFotoPerfilPresidente.Image = new Bitmap("ProfilePhotos/DefaultProfilePhoto.jpg");

            //-----------------------------------------------------------
            lblNomeTreinador.Text = "Nome: " + Atleta.Treinador.Nome;
            lblIdadeTreinador.Text = "Idade: " + Atleta.Treinador.Idade;
            lblRuaTreinador.Text = Atleta.Treinador.MoradaPessoa.Rua;
            lblLocalidadeTreinador.Text = Atleta.Treinador.MoradaPessoa.CodigoPostal;
            lblCpTreinador.Text = Atleta.Treinador.MoradaPessoa.CodigoPostal;
            if (File.Exists("ProfilePhotos/" + Atleta.Treinador.Nome + "_MF.jpg"))
                picFotoPerfilTreinador.Image = new Bitmap("ProfilePhotos/" + Atleta.Treinador.Nome + "_MF.jpg");
            else
                picFotoPerfilTreinador.Image = new Bitmap("ProfilePhotos/DefaultProfilePhoto.jpg");
        }

        //-----------------------------------------------------------
        private void btnEditarTreinador_Click(object sender, EventArgs e)
        {
            var edit = new Editar("Editar", true) { DadosPessoa = Atleta.Treinador };
            var startName = Atleta.Treinador.Nome;
            var result = edit.ShowDialog();
            if (result == DialogResult.OK)
            {
                Atleta.Treinador.Nome = edit.DadosPessoa.Nome;
                Atleta.Treinador.DataNasc = edit.DadosPessoa.DataNasc;
                Atleta.Treinador.MoradaPessoa = edit.DadosPessoa.MoradaPessoa;
                UpdateDados();
            }
            try
            {
                util.GC_CLEANUP();
                File.Move("ProfilePhotos/" + startName + "_MF.jpg", "ProfilePhotos/" + Atleta.Treinador.Nome + "_MF.jpg");

            }
            catch (Exception)
            {
                MessageBox.Show("Erro...", "", MessageBoxButtons.OK);
                throw;
            }
            UpdateDados();
        }

        //-----------------------------------------------------------
        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
