﻿//-----------------------------------------------------------
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
        List<Pessoa> pessoas = new List<Pessoa>();

        //-----------------------------------------------------------
        public void Add(Pessoa bystander)
        {
            pessoas.Add(bystander);
        }

        //-----------------------------------------------------------
        public Clube(string _nome)
        {
            Nome = _nome;
        }

        //-----------------------------------------------------------
        public List<Pessoa> Pessoas
        {
            get { return pessoas; }
        }

        //-----------------------------------------------------------
        public Clube() { }

        //-----------------------------------------------------------
        static Clube()
        {
            Presidente = new Socio("Luís Filipe Vieira", new DateTime(1964, 7, 24), new Morada("Sé Nova", "Coimbra", "6969-069"));
            Nome = "Sport Lisboa e Benfica";
        }

        //-----------------------------------------------------------
        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement("Clube");
            foreach (var item in pessoas)
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
                        Atleta at = new Atleta();
                        at.Read(reader);
                        pessoas.Add(at);
                        break;
                    case "Pessoa":
                        Pessoa ps = new Pessoa();
                        ps.Read(reader);
                        pessoas.Add(ps);
                        break;
                    case "Socio":
                        Socio sc = new Socio();
                        sc.Read(reader);
                        pessoas.Add(sc);
                        break;
                }
            }
        }
    }
}