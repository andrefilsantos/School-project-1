using System;
using System.Collections.Generic;
using System.Drawing;
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
            Update(SearchByName(Util.RemoveDiacritics(txtPesquisa.Text).ToUpper()), lstResultados);
        }

        //-----------------------------------------------------------
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Update(SearchByName(Util.RemoveDiacritics(txtPesquisa.Text).ToUpper()), lstResultados);
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
        private List<int> SearchByStreet(string street)
        {
            List<int> pessoasIndex = new List<int>();

            for (int i = 0; i < _clube.Pessoas.Count; i++)
                if (_clube.Pessoas[i].MoradaPessoa.Rua.ToUpper().Contains(street))
                    pessoasIndex.Add(i);

            return pessoasIndex;
        }

        //-----------------------------------------------------------
        private List<int> SearchByCity(string city)
        {
            List<int> pessoasIndex = new List<int>();

            for (int i = 0; i < _clube.Pessoas.Count; i++)
                if (_clube.Pessoas[i].MoradaPessoa.Localidade.ToUpper().Contains(city))
                    pessoasIndex.Add(i);

            return pessoasIndex;
        }

        //-----------------------------------------------------------
        private List<int> SearchByPostalCode(string codPostal)
        {
            List<int> pessoasIndex = new List<int>();

            for (int i = 0; i < _clube.Pessoas.Count; i++)
                if (_clube.Pessoas[i].MoradaPessoa.Localidade.ToUpper().Contains(codPostal))
                    pessoasIndex.Add(i);

            return pessoasIndex;
        }

        //-----------------------------------------------------------
        private List<int> SearchByAge(int age)
        {
            List<int> pessoasIndex = new List<int>();

            if (cboComoPesquisar.SelectedIndex == 0) //Igual a
            {
                for (int i = 0; i < _clube.Pessoas.Count; i++)
                    if (_clube.Pessoas[i].Idade == age)
                        pessoasIndex.Add(i);
            }
            else if (cboComoPesquisar.SelectedIndex == 1) //Superior a
            {
                for (int i = 0; i < _clube.Pessoas.Count; i++)
                    if (_clube.Pessoas[i].Idade >= age)
                        pessoasIndex.Add(i);
            }
            else //Inferior a
            {
                for (int i = 0; i < _clube.Pessoas.Count; i++)
                    if (_clube.Pessoas[i].Idade <= age)
                        pessoasIndex.Add(i);
            }

            return pessoasIndex;
        }

        //-----------------------------------------------------------
        private List<int> SearchByWeight(int weight)
        {
            List<int> pessoasIndex = new List<int>();

            if (cboComoPesquisar.SelectedIndex == 0) //Igual a
            {
                for (int i = 0; i < _clube.Pessoas.Count; i++)
                {
                    if (_clube.Pessoas[i] is Atleta)
                    {
                        var atletaTemp = (Atleta)_clube.Pessoas[i];
                        if (atletaTemp.Peso == weight)
                            pessoasIndex.Add(i);
                    }
                }
            }
            else if (cboComoPesquisar.SelectedIndex == 1) //Superior a
            {
                for (int i = 0; i < _clube.Pessoas.Count; i++)
                {
                    if (_clube.Pessoas[i] is Atleta)
                    {
                        var atletaTemp = (Atleta)_clube.Pessoas[i];
                        if (atletaTemp.Peso >= weight)
                            pessoasIndex.Add(i);
                    }
                }
            }
            else //Inferior a
            {
                for (int i = 0; i < _clube.Pessoas.Count; i++)
                {
                    if (_clube.Pessoas[i] is Atleta)
                    {
                        var atletaTemp = (Atleta)_clube.Pessoas[i];
                        if (atletaTemp.Peso <= weight)
                            pessoasIndex.Add(i);
                    }
                }
            }

            return pessoasIndex;
        }

        //-----------------------------------------------------------
        private List<int> SearchByNumSocio(int numSocio)
        {
            List<int> pessoasIndex = new List<int>();

            if (cboComoPesquisar.SelectedIndex == 0) //Igual a
            {
                for (int i = 0; i < _clube.Pessoas.Count; i++)
                {
                    if (_clube.Pessoas[i] is Socio)
                    {
                        var atletaTemp = (Socio)_clube.Pessoas[i];
                        if (atletaTemp.NumSocio == numSocio)
                            pessoasIndex.Add(i);
                    }
                }
            }
            else if (cboComoPesquisar.SelectedIndex == 1) //Superior a
            {
                for (int i = 0; i < _clube.Pessoas.Count; i++)
                {
                    if (_clube.Pessoas[i] is Socio)
                    {
                        var atletaTemp = (Socio)_clube.Pessoas[i];
                        if (atletaTemp.NumSocio >= numSocio)
                            pessoasIndex.Add(i);
                    }
                }
            }
            else //Inferior a
            {
                for (int i = 0; i < _clube.Pessoas.Count; i++)
                {
                    if (_clube.Pessoas[i] is Socio)
                    {
                        var atletaTemp = (Socio)_clube.Pessoas[i];
                        if (atletaTemp.NumSocio <= numSocio)
                            pessoasIndex.Add(i);
                    }
                }
            }

            return pessoasIndex;
        }

        //-----------------------------------------------------------
        private void Update(List<int> indexes, ListBox lista)
        {
            List<string> resultados = new List<string>();

            foreach (var index in indexes)
                resultados.Add(_clube.Pessoas[index].ToString());

            lista.DataSource = resultados;
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

        //-----------------------------------------------------------
        private void cboPesquisaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPesquisaPor.SelectedIndex == 0 || cboPesquisaPor.SelectedIndex == 1 || cboPesquisaPor.SelectedIndex == 2 || cboPesquisaPor.SelectedIndex == 3)
            {
                cboComoPesquisar.Visible = false;
                txtPesquisaAvancada.Size = new Size(604, 21);
                txtPesquisaAvancada.Location = new Point(157, 7);
            }
            else
            {
                cboComoPesquisar.Visible = true;
                txtPesquisaAvancada.Size = new Size(508, 21);
                txtPesquisaAvancada.Location = new Point(253, 7);
            }
        }

        private void txtPesquisaAvancada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(cboPesquisaPor.SelectedIndex == 0 || cboPesquisaPor.SelectedIndex == 1 ||
                  cboPesquisaPor.SelectedIndex == 2 || cboPesquisaPor.SelectedIndex == 3) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPesquisaAvancada_TextChanged(object sender, EventArgs e)
        {
            switch (cboPesquisaPor.SelectedIndex)
            {
                //-----------------------------------------------------------
                case 0: //Nome
                    Update(SearchByName(Util.RemoveDiacritics(txtPesquisaAvancada.Text).ToUpper()), lstResultadosAvancados);
                    break;

                //-----------------------------------------------------------
                case 1: //Rua
                    Update(SearchByStreet(Util.RemoveDiacritics(txtPesquisaAvancada.Text).ToUpper()), lstResultadosAvancados);
                    break;

                //-----------------------------------------------------------
                case 2: //Localidade
                    Update(SearchByCity(Util.RemoveDiacritics(txtPesquisaAvancada.Text).ToUpper()), lstResultadosAvancados);
                    break;

                //-----------------------------------------------------------
                case 3: //Código Postal
                    Update(SearchByPostalCode(Util.RemoveDiacritics(txtPesquisaAvancada.Text).ToUpper()), lstResultadosAvancados);
                    break;

                //-----------------------------------------------------------
                case 4: //Idade
                    try
                    {
                        Update(SearchByAge(Convert.ToInt32(txtPesquisaAvancada.Text)), lstResultadosAvancados);
                    }
                    catch { }
                    break;

                //-----------------------------------------------------------
                case 5: //Peso
                    try
                    {
                        Update(SearchByWeight(Convert.ToInt32(txtPesquisaAvancada.Text)), lstResultadosAvancados);
                    }
                    catch { }
                    break;

                //-----------------------------------------------------------
                case 6: //Número de sócio
                    try
                    {
                        Update(SearchByNumSocio(Convert.ToInt32(txtPesquisaAvancada.Text)), lstResultadosAvancados);
                    }
                    catch { }
                    break;
            }
        }
    }
}
