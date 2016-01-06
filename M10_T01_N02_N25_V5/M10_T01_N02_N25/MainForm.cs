using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Media;
using System.IO;
using M10_T01_N02_N25.Properties;
using Message = Microsoft.Build.Tasks.Message;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public partial class MainForm : Form
    {
        //-----------------------------------------------------------
        public Clube clube = new Clube();
        Editar edit = new Editar("Editar", true);
        Editar add = new Editar("Adicionar", false);
        frmSobre sobre = new frmSobre();
        frmPesquisa pesquisar = new frmPesquisa();
        bool autoSave = false;
        string filePath = "Clube.xml";

        //-----------------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------
        private void IsDataSet(object sender, EditarEventArgs e)
        {
            //-----------------------------------------------------------
            Editar form = (Editar)sender;

            Console.WriteLine(e.Index);
            if (e.Index == 0)
                clube.Add(new Atleta(e.Pessoa.Nome, e.Pessoa.DataNasc, e.Pessoa.MoradaPessoa, e.Peso));
            else if (e.Index == 1)
                clube.Add(new Socio(e.Pessoa.Nome, e.Pessoa.DataNasc, e.Pessoa.MoradaPessoa));

            UpdateLB();
        }

        //-----------------------------------------------------------
        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
            clube.Add(new Pessoa("Coiso Manel", new DateTime(1572, 12, 19), new Morada("Marte", "Cratera 3", "1900-003")));
            clube.Add(new Atleta("Engenheiro José Sócrates", new DateTime(1957, 9, 6), new Morada("Nº 33 da rua abade faria", "Lisboa", "1900-003"), 87));
            clube.Add(new Socio("O Bob The Builder", new DateTime(1950, 3, 7), new Morada("Comboios", "Lisboa", "1923-02")));
            */
            add.IsSet += IsDataSet;

            if (File.Exists(filePath))
            {
                Console.WriteLine("Loading Existing File...");
                loadToolStripMenuItem.PerformClick();
            }

            UpdateLB();
        }

        //-----------------------------------------------------------
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Exclamation.Play();
            DialogResult result = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
                RemoveDuplicates();
        }

        //-----------------------------------------------------------
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            add.ClearField();
            DialogResult result = add.ShowDialog();
            add.Hide();
        }

        //-----------------------------------------------------------
        private void btnEditar_Click(object sender, EventArgs e)
        {
            util.GC_CLEANUP();
            Editar edit = new Editar("Editar", true);
            edit.ClearField();
            edit.DadosPessoa = clube.Pessoas[lbMembros.SelectedIndex];
            string startName = edit.DadosPessoa.Nome;
            DialogResult result = edit.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (clube.Pessoas[lbMembros.SelectedIndex] is Atleta)
                {
                    Atleta bystander = new Atleta(edit.DadosPessoa.Nome, edit.DadosPessoa.DataNasc, edit.DadosPessoa.MoradaPessoa, 0);
                    clube.Pessoas[lbMembros.SelectedIndex] = bystander;
                    UpdateDados(lbMembros.SelectedIndex);
                    Console.WriteLine("Hi 1");
                }
                else if (clube.Pessoas[lbMembros.SelectedIndex] is Socio)
                {
                    Socio bystander = new Socio(edit.DadosPessoa.Nome, edit.DadosPessoa.DataNasc, edit.DadosPessoa.MoradaPessoa);
                    clube.Pessoas[lbMembros.SelectedIndex] = bystander;
                    UpdateDados(lbMembros.SelectedIndex);
                    Console.WriteLine("Hi 2");
                }
            }
            try
            {
                util.GC_CLEANUP();
                File.Move("ProfilePhotos/" + startName + "_MF.jpg", "ProfilePhotos/" + clube.Pessoas[lbMembros.SelectedIndex].Nome + "_MF.jpg");

            }
            catch (Exception)
            {
                MessageBox.Show("Erro...", "", MessageBoxButtons.OK);
                throw;
            }

            UpdateLB();
        }

        //-----------------------------------------------------------
        private void UpdateLB()
        {
            List<string> pessoasString = new List<string>();
            pessoasString.Clear();
            foreach (var item in clube.Pessoas)
            {
                pessoasString.Add(item.ToString());
            }
            lbMembros.DataSource = pessoasString;
            if (pessoasString.Count == 0)
            {
                lblVazio.Visible = true;
                lblNome.Text = "Nome: ";
                lblIdade.Text = "Idade: ";
                lblLocalidade.Text = null;
                lblRua.Text = null;
                lbl_codpost.Text = null;
                picFotoPerfil.Image = new Bitmap(Resources.DefaultProfilePhoto);
            }
            else
            {
                lblVazio.Visible = false;
            }
            if (autoSave && clube.Pessoas.Count > 0)
            {
                saveToolStripMenuItem.PerformClick();
            }
        }

        //-----------------------------------------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                writer.WriteStartDocument();
                clube.Write(writer);
                writer.WriteEndDocument();
            }
            Console.WriteLine("End Save...");
        }

        //-----------------------------------------------------------
        public void UpdateDados(int index)
        {
            lblNome.Text = "Nome: " + clube.Pessoas[index].Nome;
            lblIdade.Text = "Idade: " + clube.Pessoas[index].Idade.ToString() + " Ano/s";
            lblLocalidade.Text = clube.Pessoas[index].MoradaPessoa.Localidade;
            lblRua.Text = clube.Pessoas[index].MoradaPessoa.Rua;
            lbl_codpost.Text = clube.Pessoas[index].MoradaPessoa.CodigoPostal;
            lblPeso.Text = clube.Pessoas[index].GetSpecial();
            UpdateProfilePic(index);
        }

        //-----------------------------------------------------------
        public void UpdateProfilePic(int index)
        {
            if (!File.Exists("ProfilePhotos/" + clube.Pessoas[index].Nome + "_MF.jpg") && File.Exists("ProfilePhotos/" + clube.Pessoas[index].Nome + ".jpg"))
            {
                File.Copy("ProfilePhotos/" + clube.Pessoas[index].Nome + ".jpg", "ProfilePhotos/" + clube.Pessoas[index].Nome + "_MF.jpg");
                return;
            }

            if (File.Exists("ProfilePhotos/" + clube.Pessoas[index].Nome + "_MF.jpg"))
                picFotoPerfil.Image = new Bitmap("ProfilePhotos/" + clube.Pessoas[index].Nome + "_MF.jpg");
            else
                picFotoPerfil.Image = new Bitmap(Resources.DefaultProfilePhoto);
        }

        //-----------------------------------------------------------
        private void lbMembros_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDados(lbMembros.SelectedIndex);
        }

        //-----------------------------------------------------------
        private void lbMembros_DoubleClick(object sender, EventArgs e)
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
        private void tsmSobre_Click(object sender, EventArgs e)
        {
        }

        //-----------------------------------------------------------
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-----------------------------------------------------------
        private void btnPresidente_Click(object sender, EventArgs e)
        {
            clubeToolStripMenuItem.PerformClick();
        }

        //-----------------------------------------------------------
        private void btnFstReg_Click(object sender, EventArgs e)
        {

            try
            {
                lbMembros.SelectedIndex = 0;
                UpdateDados(0);
            }
            catch { }
        }

        //-----------------------------------------------------------
        private void btnPrevReg_Click(object sender, EventArgs e)
        {
            if (lbMembros.SelectedIndex != 0)
            {
                try
                {
                    UpdateDados(lbMembros.SelectedIndex -= 1);
                }
                catch { }
            }
        }

        //-----------------------------------------------------------
        private void btnNxtReg_Click(object sender, EventArgs e)
        {
            if (lbMembros.SelectedIndex != clube.Pessoas.Count - 1)
            {
                UpdateDados(lbMembros.SelectedIndex += 1);
            }
        }

        //-----------------------------------------------------------
        private void btnLatReg_Click(object sender, EventArgs e)
        {
            lbMembros.SelectedIndex = clube.Pessoas.Count() - 1;
            //UpdateDados(0);
        }

        //-----------------------------------------------------------
        private void lblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start("mailto:" + clube.Pessoas[lbMembros.SelectedIndex].Email);
        }

        //-----------------------------------------------------------
        private void btnRemReg_Click(object sender, EventArgs e)
        {
            try
            {
                clube.Pessoas.RemoveRange(lbMembros.SelectedIndex, 1);
                UpdateLB();
            }
            catch
            {
                MessageBox.Show("A lista não contem mais elementos para eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------------------------------
        private void btnRemAll_Click(object sender, EventArgs e)
        {
            clube.Pessoas.Clear();
            UpdateLB();
        }

        //-----------------------------------------------------------
        public void RemoveDuplicates()
        {
            foreach (var item in clube.Pessoas)
            {
                picFotoPerfil.Image = new Bitmap(Resources.DefaultProfilePhoto);
                util.GC_CLEANUP();
                if (File.Exists("ProfilePhotos/" + item.Nome + "_MF.jpg"))
                    File.Delete("ProfilePhotos/" + item.Nome + "_MF.jpg");
            }

            if (File.Exists("ProfilePhotos/" + Clube.Presidente.Nome + "_MF.jpg"))
                File.Delete("ProfilePhotos/" + Clube.Presidente.Nome + "_MF.jpg");
            if (File.Exists("ProfilePhotos/" + Atleta.Treinador.Nome + "_MF.jpg"))
                File.Delete("ProfilePhotos/" + Atleta.Treinador.Nome + "_MF.jpg");
        }

        //-----------------------------------------------------------
        private void tsmPesquisa_Click(object sender, EventArgs e)
        {
            pesquisar.ShowDialog();
        }

        //-----------------------------------------------------------
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Clube")
                    {
                        clube.Read(reader);
                    }
                }
            }
            UpdateLB();
            Console.WriteLine("End Load...");
        }

        private void clubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobreOClube sbClube = new frmSobreOClube();
            sbClube.ShowDialog();
        }

        private void programaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre.ShowDialog();
        }

        private void autoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("O Autosave encontra-se " + util.BoolToStringAdj(autoSave) + ", pretende " + util.BoolToStringVrb(!autoSave), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
                autoSave = !autoSave;
        }
    }
}



//pessoas.Add(new Atleta("Engenheiro José Sócrates", new DateTime(1957,9,6), new Morada("Nº 33 da rua abade faria","Lisboa", "1900-003"), 87));
//pessoas.Add(new Socio("Doutor Passos Coelho", new DateTime(1964, 7, 24), new Morada("Sé Nova", "Coimbra", "6969-069")));