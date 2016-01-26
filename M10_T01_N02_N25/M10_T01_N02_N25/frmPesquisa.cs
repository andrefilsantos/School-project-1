using System;
using System.Collections.Generic;
using System.Windows.Forms;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public partial class frmPesquisa : Form
    {
        private List<string> resultadoPesquisa = new List<string>();
        private Clube _clube;
        //-----------------------------------------------------------
        public frmPesquisa(ref Clube clube)
        {
            InitializeComponent();
            _clube = clube;
        }

        //-----------------------------------------------------------
        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //-----------------------------------------------------------
        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            cboPesquisaPor.SelectedIndex = 0;
            cboComoPesquisar.SelectedIndex = 0;
            Update(SearchByName(Util.RemoveDiacritics(txtPesquisa.Text).ToUpper()));
        }

        //-----------------------------------------------------------
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Update(SearchByName(Util.RemoveDiacritics(txtPesquisa.Text).ToUpper()));
        }

        //-----------------------------------------------------------
        private List<int> SearchByName(string name)
        {
            List<int> pessoasIndex = new List<int>();

            for (int i = 0; i < _clube.Pessoas.Count; i++)
                if (Util.RemoveDiacritics(_clube.Pessoas[i].ToString()).ToUpper().Contains(name))
                    pessoasIndex.Add(i);

            return pessoasIndex;
        }

        //-----------------------------------------------------------
        private void Update(List<int> indexes)
        {
            List<string> resultados = new List<string>();

            foreach (var index in indexes)
                resultados.Add(_clube.Pessoas[index].ToString());

            lstResultados.DataSource = resultados;
        }

        //-----------------------------------------------------------
        private void frmPesquisa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            switch (cboPesquisaPor.SelectedIndex)
            {
                case 0: //Nome
                    foreach (var item in Global.ClubeRef.Pessoas)
                    {
                        if (item.Nome == txtPesquisaAvancada.Text)
                        {
                            resultadoPesquisa.Add(item.ToString());
                            lstResultadosAvancados.DataSource = resultadoPesquisa;
                        }
                    }
                    break;
                case 1: //Rua
                    break;
                case 2: //Localidade
                    break;
                case 3: //Código Postal
                    break;
                case 4: //Idade
                    break;
                case 5: //Peso
                    break;
                case 6: //Número de sócio
                    break;
            }
        }

        private void cboPesquisaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPesquisaPor.SelectedIndex == 0)
            {
                cboComoPesquisar.Visible = false;
                //txtPesquisaAvancada.Size = Size
            }
        }
    }
}
