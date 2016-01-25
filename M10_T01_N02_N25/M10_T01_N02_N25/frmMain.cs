//-----------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Xml;
using M10_T01_N02_N25.Properties;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public partial class frmMain : Form
    {
        //TODO: Redo LOAD code to only show active members
        //TODO: Insert Benfica athletes

        //-----------------------------------------------------------
        public Clube Clube = new Clube();

        //-----------------------------------------------------------
        private frmEditar _add = new frmEditar("Adicionar", false, "atleta");
        private frmSobre _sobre = new frmSobre();
        private frmSobreClube _sobreClube = new frmSobreClube();
        private frmPesquisa _pesquisa;
        private bool _autoSave = false;
        private const string FilePath = "Clube.xml";
        private readonly Bitmap _defaultProfilePic = new Bitmap(Resources.DefaultProfilePhoto);
        private int _nAtletas;
        private int _nSocios;

        //-----------------------------------------------------------
        public frmMain()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------
        private void formMain_Load(object sender, EventArgs e)
        {
            Global.SetClube(ref Clube);
            _add.IsSet += IsDataSet;

            if (File.Exists(FilePath))
            {
                Console.WriteLine("Loading Existing File...");
                loadToolStripMenuItem.PerformClick();
            }

            UpdateLb();
            _pesquisa = new frmPesquisa(ref Clube);
        }

        //-----------------------------------------------------------
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Exclamation.Play();
            var result = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
            else
                RemoveBackups();
        }

        //-----------------------------------------------------------
        private void IsDataSet(object sender, EditarEventArgs e)
        {
            
            var form = (frmEditar)sender;

            if (e.Index == 0)
            {
                Clube.Add(new Atleta(e.Pessoa.Nome, e.Pessoa.DataNasc, e.Pessoa.MoradaPessoa, e.Peso, true, Clube.Pessoas.Count + 1));
            }
            else if (e.Index == 1)
            {
                Clube.Add(new Socio(e.Pessoa.Nome, e.Pessoa.DataNasc, e.Pessoa.MoradaPessoa, true, Clube.Pessoas.Count + 1));
            }

            form.ClearField();
            form.Hide();
            UpdateLb();
        }

        //-----------------------------------------------------------
        private void UpdateLb()
        {
            var pessoasString = new List<string>();
            pessoasString.Clear();
            if (Clube == null) return;
            foreach (var item in Clube.Pessoas)
            {
                if (item.IsActive)
                pessoasString.Add(item.ToString());
            }
            lstPessoas.DataSource = pessoasString;

            if (pessoasString.Count == 0)
            {
                lblVazio.Visible = true;
                lblNome.Text = "Nome: ";
                lblIdade.Text = "Idade: ";
                lblLocalidade.Text = null;
                lblRua.Text = null;
                lblCodigoPostal.Text = null;
                lblPesoSocio.Text = null;
                picMFfotoPerfil.Image = _defaultProfilePic;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                lblVazio.Visible = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            if (_autoSave && Clube.Pessoas.Count > 0)
            {
                saveToolStripMenuItem.PerformClick();
            }
        }

        //-----------------------------------------------------------
        public void UpdateDados(int index)
        {
            lblNome.Text = "Nome: " + Clube.Pessoas[index].Nome;
            lblIdade.Text = "Idade: " + Clube.Pessoas[index].Idade + " Ano/s";
            lblLocalidade.Text = Clube.Pessoas[index].MoradaPessoa.Localidade;
            lblRua.Text = Clube.Pessoas[index].MoradaPessoa.Rua;
            lblCodigoPostal.Text = Clube.Pessoas[index].MoradaPessoa.CodigoPostal;
            if (Clube.Pessoas[index] is Atleta)
            {
                var atleta = Clube.Pessoas[index] as Atleta;
                lblPesoSocio.Text = "Peso: " + atleta.Peso + " Kg";
            }
            else if (Clube.Pessoas[index] is Socio)
            {
                var socio = Clube.Pessoas[index] as Socio;
                lblPesoSocio.Text = "Número de Sócio: " + socio.NumSocio;
            }
            UpdateProfilePic(index);
        }

        //-----------------------------------------------------------
        public void RemoveBackups()
        {
            for (var i = 0; i < Clube.Pessoas.Count; i++)
            {
                picMFfotoPerfil.Image = new Bitmap(Resources.DefaultProfilePhoto);
                Util.GC_CLEANUP();
                if (File.Exists("ProfilePhotos/" + i + "_Bck.jpg"))
                    File.Delete("ProfilePhotos/" + i + "_Bck.jpg");
            }

            if (File.Exists("ProfilePhotos/" + "Presidente" + "_Bck.jpg"))
            {
                Util.GC_CLEANUP();
                File.Delete("ProfilePhotos/" + "Presidente" + "_Bck.jpg");
            }
            if (!File.Exists("ProfilePhotos/" + "Treinador" + "_Bck.jpg")) return;
            Util.GC_CLEANUP();
            File.Delete("ProfilePhotos/" + "Treinador" + "_Bck.jpg");
        }

        //-----------------------------------------------------------
        public void UpdateProfilePic(int index)
        {
            if (!File.Exists("ProfilePhotos/" + index + "_Bck.jpg") && File.Exists("ProfilePhotos/" + index + ".jpg"))
            {
                File.Copy("ProfilePhotos/" + index + ".jpg", "ProfilePhotos/" + index + "_Bck.jpg");
            }

            picMFfotoPerfil.Image = File.Exists("ProfilePhotos/" + index + "_Bck.jpg") ? new Bitmap("ProfilePhotos/" + index + "_Bck.jpg") : new Bitmap(Resources.DefaultProfilePhoto);
        }

        //-----------------------------------------------------------
        #region ToolStripMenu

        //-----------------------------------------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGuardar.PerformClick();
        }

        //-----------------------------------------------------------
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSair.PerformClick();
        }

        //-----------------------------------------------------------
        private void clubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _nAtletas = 0;
            _nSocios = 0;
            foreach (var item in Clube.Pessoas)
            {
                if (item is Atleta)
                    _nAtletas++;
                else if (item is Socio)
                    _nSocios++;
            }
            _sobreClube.nAtletas = _nAtletas;
            _sobreClube.nSocios = _nSocios;
            _sobreClube.ShowDialog();
        }

        //-----------------------------------------------------------
        private void programaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sobre.ShowDialog();
        }

        //-----------------------------------------------------------
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Clube.Pessoas.Clear();
            using (var reader = XmlReader.Create(FilePath))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Clube")
                    {
                        Clube.Read(reader);
                    }
                }
            }
            UpdateLb();
            Console.WriteLine("End Load...");
        }

        //-----------------------------------------------------------
        private void AutoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("O Auto Save encontra-se " + Util.BoolToStringAdj(_autoSave) + ", pretende " + Util.BoolToStringVrb(!_autoSave) + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
                _autoSave = !_autoSave;
        }

        #endregion

        //-----------------------------------------------------------
        #region BTN
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Util.GC_CLEANUP();
            string type = null;
            if (Clube.Pessoas[lstPessoas.SelectedIndex] is Socio)
                type = "socio";
            else
                type = "atleta";

            var edit = new frmEditar("Editar", true, type);
            edit.Selected = lstPessoas.SelectedIndex;
            edit.ClearField();
            edit.DadosPessoa = Clube.Pessoas[lstPessoas.SelectedIndex];
            //var image = new Bitmap(picMFfotoPerfil.Image);
            edit.picFotoPerfil.Image = picMFfotoPerfil.Image;
            DialogResult result = edit.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Clube.Pessoas[lstPessoas.SelectedIndex] is Atleta)
                {
                    var pess = edit.DadosPessoa;
                    var bystander = new Atleta(pess.Nome, pess.DataNasc, pess.MoradaPessoa, 0, true,pess.Index);
                    Clube.Pessoas[lstPessoas.SelectedIndex] = bystander;
                    UpdateDados(lstPessoas.SelectedIndex);
                }
                else if (Clube.Pessoas[lstPessoas.SelectedIndex] is Socio)
                {
                    var pess = edit.DadosPessoa;
                    var bystander = new Socio(pess.Nome, pess.DataNasc, pess.MoradaPessoa, true,pess.Index);
                    Clube.Pessoas[lstPessoas.SelectedIndex] = bystander;
                    UpdateDados(lstPessoas.SelectedIndex);
                }
            }
            edit.picFotoPerfil.Image = _defaultProfilePic;
            UpdateLb();
        }

        //-----------------------------------------------------------
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Util.GC_CLEANUP();
            var result = _add.ShowDialog();
            _add.Hide();
        }

        //-----------------------------------------------------------
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-----------------------------------------------------------
        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            lstPessoas.SelectedIndex = 0;
        }

        //-----------------------------------------------------------
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedIndex > 0)
                lstPessoas.SelectedIndex--;
        }

        //-----------------------------------------------------------
        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedIndex < Clube.Pessoas.Count() - 1)
                lstPessoas.SelectedIndex++;
        }

        //-----------------------------------------------------------
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lstPessoas.SelectedIndex = Clube.Pessoas.Count() - 1;
        }

        //-----------------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var settings = new XmlWriterSettings { Indent = true };

            using (var writer = XmlWriter.Create(FilePath, settings))
            {
                writer.WriteStartDocument();
                Clube.Write(writer);
                writer.WriteEndDocument();
            }
            Console.WriteLine("End Save...");
        }

        //-----------------------------------------------------------
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            _pesquisa.Show();
        }

        //-----------------------------------------------------------
        private void btnOClube_Click(object sender, EventArgs e)
        {
            clubeToolStripMenuItem.PerformClick();
        }

        //-----------------------------------------------------------
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Clube.Pessoas[lstPessoas.SelectedIndex].Active = false;
            Clube.Pessoas.Remove(Clube.Pessoas[lstPessoas.SelectedIndex]);
            UpdateLb();
        }

        #endregion

        //-----------------------------------------------------------
        private void lstPessoas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                btnEditar.PerformClick();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Data);
            }
        }

        //-----------------------------------------------------------
        private void lstPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The Item index = " + Clube.Pessoas[lstPessoas.SelectedIndex].Index);
            Console.WriteLine("Selected index = " + lstPessoas.SelectedIndex);
            Console.WriteLine("//-----------------------------------------------------------");
            UpdateDados(lstPessoas.SelectedIndex);
        }
    }
}
