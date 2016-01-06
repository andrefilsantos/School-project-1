using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Threading;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public class Pessoa : IXmlWritable, IXmlReadable
    {
        //-----------------------------------------------------------
        public int Idade { get; private set; }
        DateTime dataNas;
        public string Nome { get; set; }
        public Morada MoradaPessoa { get; set; }

        //-----------------------------------------------------------
        public DateTime DataNasc
        {
            //-----------------------------------------------------------
            get { return dataNas; }

            //-----------------------------------------------------------
            set
            {
                dataNas = value;
                Idade = CalculaIdade();
            }
        }

        public virtual string GetSpecial()
        {
            return "";
        }

        //-----------------------------------------------------------
        int CalculaIdade()
        {
            int anos = DateTime.Now.Year - dataNas.Year;

            if (DateTime.Now.Month < dataNas.Month || (DateTime.Now.Month == dataNas.Month && DateTime.Now.Day < dataNas.Day))
                anos--;
            return anos;
        }

        //-----------------------------------------------------------
        public Pessoa()
        {
            Nome = null;
            DataNasc = new DateTime();
            DataNasc = DateTime.Now;
            MoradaPessoa = new Morada();
            Idade = 0;
        }

        //-----------------------------------------------------------
        public Pessoa(string _nome, DateTime _dateNasc, Morada _moradaPessoa)
        {
            Nome = _nome;
            DataNasc = _dateNasc;
            MoradaPessoa = _moradaPessoa; ;
            Idade = CalculaIdade();
        }

        //-----------------------------------------------------------
        public override string ToString()
        {
            return "[P] " + Nome;
        }

        //-----------------------------------------------------------
        public virtual void Read(XmlReader reader)
        {
            Nome = reader.GetAttribute("Nome");
            var year = Convert.ToInt32(reader.GetAttribute("Ano"));
            var month = Convert.ToInt32(reader.GetAttribute("Mes"));
            var day = Convert.ToInt32(reader.GetAttribute("Dia"));
            MoradaPessoa.Read(reader);
            DataNasc = new DateTime(year, month, day);
            Console.WriteLine(Nome + " " + year + " " + month + " " + day + " " + MoradaPessoa.Rua + " " + MoradaPessoa.Localidade + " " + MoradaPessoa.CodigoPostal);
        }

        //-----------------------------------------------------------
        public virtual void Write(XmlWriter writer)
        {
            writer.WriteStartElement("Pessoa");
            writer.WriteAttributeString("Nome", Nome);
            writer.WriteAttributeString("Ano", DataNasc.Year.ToString());
            writer.WriteAttributeString("Mes", DataNasc.Month.ToString());
            writer.WriteAttributeString("Dia", DataNasc.Day.ToString());
            MoradaPessoa.Write(writer);
            writer.WriteEndElement();
        }
    }
}
