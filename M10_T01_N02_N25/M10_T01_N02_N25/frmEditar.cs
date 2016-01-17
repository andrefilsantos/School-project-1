using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.MessageBox;

namespace M10_T01_N02_N25
{
    public partial class frmEditar : Form //TODO: Image loading Complete code refator 
    {
        //-----------------------------------------------------------
        private DateTime _data;
        private bool _changePhoto = false;
        public int Selected;

        //-----------------------------------------------------------
        public frmEditar(string nome, bool isEditar)
        {
            InitializeComponent();
            Text = nome;
            cboTipo.SelectedIndex = 0;
            cboTipo.Enabled = !isEditar;
        }

        //-----------------------------------------------------------
        public double Peso
        {
            get
            {
                return Math.Abs(Convert.ToDouble(txtPeso.Text));
            }
            set
            {
                txtPeso.Text = Math.Abs(value).ToString();
            }
        }

        //-----------------------------------------------------------
        public Pessoa DadosPessoa
        {
            //-----------------------------------------------------------
            get
            {
                var dados = new Pessoa
                {
                    Nome = txtNome.Text,
                    MoradaPessoa = new Morada(txtRua.Text, txtLocalidade.Text, mskCodigoPostal.Text),
                    DataNasc = new DateTime()
                };
                var converteuOk = DateTime.TryParse(mskData.Text, out _data);

                dados.DataNasc = !converteuOk ? _data : DateTime.Now;

                if (_changePhoto)
                {
                    //TODO: Image code refactoring...
                    if (File.Exists("ProfilePhotos/" + Selected + ".jpg"))
                    {
                        Dispose();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete("ProfilePhotos/" + Selected + ".jpg");
                    }
                    var image = new Bitmap(picFotoPerfil.Image);
                    image.Save("ProfilePhotos/" + Selected + ".jpg");
                    MessageBox.Show("Imagem guardada com Sucesso!", "Imagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return dados;
            }

            //-----------------------------------------------------------
            set
            {
                txtNome.Text = value.Nome;
                mskData.Text = value.DataNasc.ToString("dd-MM-yyyy");
                txtRua.Text = value.MoradaPessoa.Rua;
                txtLocalidade.Text = value.MoradaPessoa.Localidade;
                mskCodigoPostal.Text = value.MoradaPessoa.CodigoPostal;

                /*if (File.Exists("ProfilePhotos/" + value.Nome + ".jpg"))
                    picFotoPerfil.Image = new Bitmap("ProfilePhotos/" + value.Nome + ".jpg");
                else
                    picFotoPerfil.Image = new Bitmap("ProfilePhotos/DefaultProfilePhoto.jpg");*/
            }
        }

        //-----------------------------------------------------------
        public frmEditar() { }

        //-----------------------------------------------------------
        private void frmEditar_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Selected.ToString());
        }

        //-----------------------------------------------------------
        private void btnOK_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //-----------------------------------------------------------
        private void frmEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnIsSet();
        }

        //-----------------------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //-----------------------------------------------------------
        public void ClearField()
        {
            txtNome.Text = null;
            mskData.Text = null;
            txtRua.Text = null;
            txtLocalidade.Text = null;
            mskCodigoPostal.Text = null;
            //picFotoPerfil.Image = new Bitmap("ProfilePhotos/DefaultProfilePhoto.jpg");
        }

        //-----------------------------------------------------------
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected = cboTipo.SelectedIndex;
            if (Selected == 0)
            {
                txtPeso.Enabled = true;
                return;
            }
            txtPeso.Enabled = false;
            txtPeso.Text = null;
        }

        //-----------------------------------------------------------
        public event IsSetHandler IsSet;

        //-----------------------------------------------------------
        public void OnIsSet()
        {
            if (string.IsNullOrEmpty(txtPeso.Text))
            {
                IsSet?.Invoke(this, new EditarEventArgs(DadosPessoa, cboTipo.SelectedIndex, 0));
                return;
            }
            IsSet?.Invoke(this, new EditarEventArgs(DadosPessoa, cboTipo.SelectedIndex, Peso));
        }

        //-----------------------------------------------------------
        private void btnAlterarFoto_Click(object sender, EventArgs e)
        {
            var changeImg = new OpenFileDialog
            {
                Title = "Editar > Foto de Perfil",
                Filter = "Apenas Imagens. |*jpg"
            };
            var dr = changeImg.ShowDialog();
            if (string.IsNullOrEmpty(changeImg.FileName)) return;
            picFotoPerfil.Image = new Bitmap(changeImg.FileName);
            _changePhoto = true;
        }
    }
}
