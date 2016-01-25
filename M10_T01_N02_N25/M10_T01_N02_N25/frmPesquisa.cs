using System;
using System.Collections.Generic;
using System.Windows.Forms;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //TODO: Do advanced search

    //-----------------------------------------------------------
    public partial class frmPesquisa : Form 
    {
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
    }
}
