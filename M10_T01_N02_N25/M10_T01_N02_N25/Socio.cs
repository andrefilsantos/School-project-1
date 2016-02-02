using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    sealed class Socio : Pessoa
    {
        //-----------------------------------------------------------
        private static int _sociosCount = 0;
        private int _numSocio;

        //-----------------------------------------------------------
        public Socio(string _nome, DateTime _dateNasc, Morada _moradaPessoa, bool _active, int _indiceP) : base(_nome,_dateNasc,_moradaPessoa, _active, _indiceP)
        {
            _numSocio = _sociosCount + 1;
            _sociosCount++;
        }

        //-----------------------------------------------------------
        public Socio()
        {
            _numSocio = _sociosCount + 1;
            _sociosCount++;
        }

        //-----------------------------------------------------------
        public int NumSocio
        {
            get { return _numSocio; }
        }

        //-----------------------------------------------------------
        public override string ToString()
        {
            return "[S] " + Nome;
        }

        //-----------------------------------------------------------
        public override void Write(XmlWriter writer)
        {
            writer.WriteStartElement("Socio");
            writer.WriteAttributeString("Nome", Nome);
            writer.WriteAttributeString("CodSocio", _numSocio.ToString());
            writer.WriteAttributeString("Dia", DataNasc.Day.ToString());
            writer.WriteAttributeString("Mes", DataNasc.Month.ToString());
            writer.WriteAttributeString("Ano", DataNasc.Year.ToString());
            MoradaPessoa.Write(writer);
            writer.WriteAttributeString("Active", Active.ToString());
            writer.WriteAttributeString("Index", IndicePessoa.ToString());
            writer.WriteEndElement();
        }

        //-----------------------------------------------------------
        public override void Read(XmlReader reader)
        {
            Nome = reader.GetAttribute("Nome");
            var year = Convert.ToInt32(reader.GetAttribute("Ano"));
            var month = Convert.ToInt32(reader.GetAttribute("Mes"));
            var day = Convert.ToInt32(reader.GetAttribute("Dia"));
            _numSocio = Convert.ToInt32(reader.GetAttribute("CodSocio"));
            if (_numSocio > _sociosCount)
            {
                _sociosCount = _numSocio;
            }
            MoradaPessoa.Read(reader);
            DataNasc = new DateTime(year, month, day);
            Active = Convert.ToBoolean(reader.GetAttribute("Active"));
            IndicePessoa = Convert.ToInt32(reader.GetAttribute("Index"));
            Console.WriteLine(Nome + " \t" + year + " \t" + month + " \t" + day + " \t" + MoradaPessoa.Rua + " \t" + MoradaPessoa.Localidade + " \t" + MoradaPessoa.CodigoPostal + " \t" + _numSocio + " \t");
        }

    }
}
