using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Xml;
using M10_T01_N02_N25.Properties;

namespace M10_T01_N02_N25
{
    public partial class frmMain : Form
    {
        //TODO: Redo load code

        //-----------------------------------------------------------
        public Clube Clube = new Clube();
        //-----------------------------------------------------------
        private frmEditar _edit = new frmEditar("Editar", true);
        private frmEditar _add = new frmEditar("Adicionar", false);
        private frmSobre _sobre = new frmSobre();
        private frmSobreClube _sobreClube = new frmSobreClube();
        private frmPesquisa pesquisa;
        private bool _autoSave = false;
        private string _filePath = "Clube.xml";

        public frmMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            /*Clube.Add(new Pessoa("Coiso Manel", new DateTime(1572, 12, 19), new Morada("Marte", "Cratera 3", "1900-003"), true));
            Clube.Add(new Atleta("Engenheiro José Sócrates", new DateTime(1957, 9, 6), new Morada("Nº 33 da rua abade faria", "Lisboa", "1900-003"), 87, true));
            Clube.Add(new Socio("O Bob The Builder", new DateTime(1950, 3, 7), new Morada("Comboios", "Lisboa", "1923-02"), true));*/
            _add.IsSet += IsDataSet;

            if (File.Exists(_filePath))
            {
                Console.WriteLine("Loading Existing File...");
                loadToolStripMenuItem.PerformClick();
            }

            UpdateLB();
            pesquisa = new frmPesquisa(ref Clube);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Exclamation.Play();
            var result = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            /*else
                RemoveDuplicates();*/
        }

        private void IsDataSet(object sender, EditarEventArgs e)
        {
            //-----------------------------------------------------------
            frmEditar form = (frmEditar)sender;

            Console.WriteLine(e.Index);
            if (e.Index == 0)
                Clube.Add(new Atleta(e.Pessoa.Nome, e.Pessoa.DataNasc, e.Pessoa.MoradaPessoa, e.Peso, true));
            else if (e.Index == 1)
                Clube.Add(new Socio(e.Pessoa.Nome, e.Pessoa.DataNasc, e.Pessoa.MoradaPessoa, true));

            form.ClearField();
            form.Hide();
            UpdateLB();
        }

        private void UpdateLB()
        {
            var pessoasString = new List<string>();
            pessoasString.Clear();
            foreach (var item in Clube.Pessoas)
            {
                //if (!item.Active)
                pessoasString.Add(item.ToString());
                //MessageBox.Show(item.Active.ToString());
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
                //picMFfotoPerfil.Image = new Bitmap(Resources.DefaultProfilePhoto);
            }
            else
            {
                lblVazio.Visible = false;
            }
            if (_autoSave && Clube.Pessoas.Count > 0)
            {
                saveToolStripMenuItem.PerformClick();
            }
        }

        public void UpdateDados(int index)
        {
            lblNome.Text = "Nome: " + Clube.Pessoas[index].Nome;
            lblIdade.Text = "Idade: " + Clube.Pessoas[index].Idade.ToString() + " Ano/s";
            lblLocalidade.Text = Clube.Pessoas[index].MoradaPessoa.Localidade;
            lblRua.Text = Clube.Pessoas[index].MoradaPessoa.Rua;
            lblCodigoPostal.Text = Clube.Pessoas[index].MoradaPessoa.CodigoPostal;
            if (Clube.Pessoas[index] is Atleta)
            {
                var atleta = (Atleta)Clube.Pessoas[index];
                lblPesoSocio.Text = "Peso: " + atleta.Peso + " Kg";
            }
            else if (Clube.Pessoas[index] is Socio)
            {

                var socio = (Socio)Clube.Pessoas[index];
                lblPesoSocio.Text = "Número de Sócio: " + socio.NumSocio;
            }
            UpdateProfilePic(index);
        }

        public void UpdateProfilePic(int index)
        {
            //MessageBox.Show("ProfilePhotos/" + Convert.ToString(index) + ".jpg");
            if (File.Exists("ProfilePhotos/" + index + ".jpg"))
            {
                picMFfotoPerfil.Image = new Bitmap("ProfilePhotos/" + index + ".jpg");
                //File.FromFile("ProfilePhotos/" + Selected + ".jpg").Dispose
            }
            else
                picMFfotoPerfil.Image = new Bitmap("ProfilePhotos/DefaultProfilePhoto.jpg");
        }

        //----------------------------------------------------------- TOOLSTIP MENU

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGuardar.PerformClick();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSair.PerformClick();
        }

        private void clubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sobreClube.ShowDialog();
        }

        private void programaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sobre.ShowDialog();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var reader = XmlReader.Create(_filePath))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Clube")
                    {
                        Clube.Read(reader);
                    }
                }
            }
            UpdateLB();
            Console.WriteLine("End Load...");
        }

        private void AutoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("O Auto Save encontra-se " + Util.BoolToStringAdj(_autoSave) + ", pretende " + Util.BoolToStringVrb(!_autoSave) + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
                _autoSave = !_autoSave;
        }

        //----------------------------------------------------------- /TOOLSTIP MENU

        //----------------------------------------------------------- BTN
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Util.GC_CLEANUP();
            var edit = new frmEditar("Editar", true);
            edit.Selected = lstPessoas.SelectedIndex;
            edit.ClearField();
            edit.DadosPessoa = Clube.Pessoas[lstPessoas.SelectedIndex];
            //var image = new Bitmap(picMFfotoPerfil.Image);
            edit.picFotoPerfil.Image = picMFfotoPerfil.Image;
            var startName = edit.DadosPessoa.Nome;
            DialogResult result = edit.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Clube.Pessoas[lstPessoas.SelectedIndex] is Atleta)
                {
                    var bystander = new Atleta(edit.DadosPessoa.Nome, edit.DadosPessoa.DataNasc, edit.DadosPessoa.MoradaPessoa, 0, true);
                    Clube.Pessoas[lstPessoas.SelectedIndex] = bystander;
                    UpdateDados(lstPessoas.SelectedIndex); Console.WriteLine("Hi 1");
                }
                else if (Clube.Pessoas[lstPessoas.SelectedIndex] is Socio)
                {
                    var bystander = new Socio(edit.DadosPessoa.Nome, edit.DadosPessoa.DataNasc, edit.DadosPessoa.MoradaPessoa, true);
                    Clube.Pessoas[lstPessoas.SelectedIndex] = bystander;
                    UpdateDados(lstPessoas.SelectedIndex);
                    Console.WriteLine("Hi 2");
                }
            }
            /*try
            {
                //Util.GC_CLEANUP();
                File.Move("ProfilePhotos/" + startName + "_MF.jpg", "ProfilePhotos/" + Clube.Pessoas[lstPessoas.SelectedIndex].Nome + "_MF.jpg");

            }
            catch (Exception)
            {
                MessageBox.Show("Erro...", "", MessageBoxButtons.OK);
            }*/

            UpdateLB();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _add.ClearField();
            DialogResult result = _add.ShowDialog();
            _add.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            lstPessoas.SelectedIndex = 0;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedIndex > 0)
                lstPessoas.SelectedIndex--;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedIndex < Clube.Pessoas.Count() - 1)
                lstPessoas.SelectedIndex++;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lstPessoas.SelectedIndex = Clube.Pessoas.Count() - 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var settings = new XmlWriterSettings();
            settings.Indent = true;

            using (var writer = XmlWriter.Create(_filePath, settings))
            {
                writer.WriteStartDocument();
                Clube.Write(writer);
                writer.WriteEndDocument();
            }
            Console.WriteLine("End Save...");
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pesquisa.ShowDialog();
        }

        private void btnOClube_Click(object sender, EventArgs e)
        {
            clubeToolStripMenuItem.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clube.Pessoas[lstPessoas.SelectedIndex].Active = false;
            UpdateLB();
        }

        //----------------------------------------------------------- /BTN

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

        private void lstPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDados(lstPessoas.SelectedIndex);
        }
    }
}
