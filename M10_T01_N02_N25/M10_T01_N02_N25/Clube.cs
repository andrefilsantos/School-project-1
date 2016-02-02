//-----------------------------------------------------------
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
    public class Clube : IXmlWritable, IXmlReadable
    {
        //-----------------------------------------------------------
        public static Pessoa Presidente { get; private set; }
        public static string Nome { get; private set; }
        public static DateTime DataFundacao { get; private set; }
        private List<Pessoa> _pessoas = new List<Pessoa>();

        //-----------------------------------------------------------
        public void Add(Pessoa bystander)
        {
            _pessoas.Add(bystander);
        }

        //-----------------------------------------------------------
        public Clube(string _nome)
        {
            Nome = _nome;
        }

        //-----------------------------------------------------------
        public List<Pessoa> Pessoas
        {
            get { return _pessoas; }
        }

        //-----------------------------------------------------------
        public Clube() { }

        //-----------------------------------------------------------
        static Clube()
        {
            Presidente = new Socio("Luís Filipe Vieira", new DateTime(1964, 7, 24), new Morada("Sé Nova", "Coimbra", "6969-069"), true, 1);
            Nome = "Sport Lisboa e Benfica";
            DataFundacao = new DateTime(1904,02,28);
        }

        //-----------------------------------------------------------
        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement("Clube");
            foreach (var item in _pessoas)
            {
                item.Write(writer);
            }
            writer.WriteEndElement();
        }

        //-----------------------------------------------------------
        public void Read(XmlReader reader)
        {
            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.Read();
                switch (reader.Name)
                {
                    case "Atleta":
                        var at = new Atleta();
                        at.Read(reader);
                        //MessageBox.Show("Clube.cs " + at.Active);
                        _pessoas.Add(at);
                        break;
                    case "Pessoa":
                        var ps = new Pessoa();
                        ps.Read(reader);
                        //MessageBox.Show("Clube.cs " + ps.Active);
                        _pessoas.Add(ps);
                        break;
                    case "Socio":
                        var sc = new Socio();
                        sc.Read(reader);
                        //MessageBox.Show("Clube.cs " + sc.Active);
                        _pessoas.Add(sc);
                        break;
                }
            }
        }
    }
}