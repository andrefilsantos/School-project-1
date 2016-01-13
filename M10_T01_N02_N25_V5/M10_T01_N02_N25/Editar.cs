using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public partial class Editar : Form
    {
        //-----------------------------------------------------------
        private DateTime _data;
        private bool _changePhoto = false;
        public int Selected;

        //-----------------------------------------------------------
        public Editar(string nome, bool isEditar)
        {
            InitializeComponent();
            Text = nome;
            comboBoxTipo.SelectedIndex = 0;
            comboBoxTipo.Enabled = !isEditar;
        }

        //-----------------------------------------------------------
        public double Peso
        {
            get
            {
                return Math.Abs(Convert.ToDouble(tb_peso.Text));
            }
            set
            {
                tb_peso.Text = Math.Abs(value).ToString();
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
                    MoradaPessoa = new Morada(txbRua.Text, txbLocalidade.Text, txbCod_postal.Text),
                    DataNasc = new DateTime()
                };
                var converteuOk = DateTime.TryParse(mskData.Text, out _data);

                if (converteuOk)
                {
                    dados.DataNasc = _data;
                }
                else
                {
                    dados.DataNasc = DateTime.Now;
                    //oaef
                }
                if (_changePhoto)
                {
                    if (File.Exists("ProfilePhotos/" + dados.Nome + ".jpg"))
                    {
                        Dispose();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete("ProfilePhotos/" + dados.Nome + ".jpg");
                    }
                    var image = new Bitmap(picFotoPerfil.Image);
                    image.Save("ProfilePhotos/" + dados.Nome + ".jpg");
                    MessageBox.Show("Imagem guardada com Sucesso!", "Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return dados;
            }

            //-----------------------------------------------------------
            set
            {
                txtNome.Text = value.Nome;
                mskData.Text = value.DataNasc.ToString("dd-MM-yyyy");
                txbRua.Text = value.MoradaPessoa.Rua;
                txbLocalidade.Text = value.MoradaPessoa.Localidade;
                txbCod_postal.Text = value.MoradaPessoa.CodigoPostal;

                if (File.Exists("ProfilePhotos/" + value.Nome + ".jpg"))
                    picFotoPerfil.Image = new Bitmap("ProfilePhotos/" + value.Nome + ".jpg");
                else
                    picFotoPerfil.Image = new Bitmap("ProfilePhotos/DefaultProfilePhoto.jpg");
            }
        }

        //-----------------------------------------------------------
        public Editar() { }

        //-----------------------------------------------------------
        private void Editar_Load(object sender, EventArgs e)
        {
        }

        //-----------------------------------------------------------
        private void btnOK_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //-----------------------------------------------------------
        private void Editar_FormClosing(object sender, FormClosingEventArgs e)
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
            txbRua.Text = null;
            txbLocalidade.Text = null;
            txbCod_postal.Text = null;
            picFotoPerfil.Image = new Bitmap("ProfilePhotos/DefaultProfilePhoto.jpg");
        }

        //-----------------------------------------------------------
        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected = comboBoxTipo.SelectedIndex;
            if (Selected == 0)
            {
                tb_peso.Enabled = true;
                return;
            }
            tb_peso.Enabled = false;
            tb_peso.Text = null;
        }

        //-----------------------------------------------------------
        public event IsSetHandler IsSet;

        //-----------------------------------------------------------
        public void OnIsSet()
        {
            if (string.IsNullOrEmpty(tb_peso.Text))
            {
                IsSet?.Invoke(this, new EditarEventArgs(DadosPessoa, comboBoxTipo.SelectedIndex, 0));
                return;
            }
            IsSet?.Invoke(this, new EditarEventArgs(DadosPessoa, comboBoxTipo.SelectedIndex, Peso));
            // Uso de "?" do C# 6.0 menos que 19 é um roubo -- Tomás Pinto @legobrainiac e Andre Santos @andrefilsantos
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

        private void txbCod_postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbCod_postal.Text.Length == 4)
            {
                txbCod_postal.Text += "-";
                txbCod_postal.Select(txbCod_postal.Text.Length, 0);
            }
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb_peso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
