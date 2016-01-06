using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    public class Morada : IXmlWritable, IXmlReadable
    {
        //-----------------------------------------------------------
        public string Rua { set; get; }
        public string Localidade { set; get; }
        public string CodigoPostal { set; get; }

        //-----------------------------------------------------------
        public Morada()
        {
            Rua = null;
            Localidade = null;
            CodigoPostal = null;
        }

        //-----------------------------------------------------------
        public Morada(string _rua, string _localidade, string _codigoPostal)
        {
            Rua = _rua;
            Localidade = _localidade;
            CodigoPostal = _codigoPostal;
        }

        //-----------------------------------------------------------
        public void Write(XmlWriter writer)
        {
            writer.WriteAttributeString("Rua", Rua);
            writer.WriteAttributeString("Localidade", Localidade);
            writer.WriteAttributeString("CodigoPostoal", CodigoPostal);
        }

        //-----------------------------------------------------------
        public override string ToString()

        {
            return Rua + "\n" + Localidade + "\n" + CodigoPostal;
        }

        public void Read(XmlReader reader) 
        {
            Rua = reader.GetAttribute("Rua");
            Localidade = reader.GetAttribute("Localidade");
            CodigoPostal = reader.GetAttribute("CodigoPostoal");
        }
    }
}
