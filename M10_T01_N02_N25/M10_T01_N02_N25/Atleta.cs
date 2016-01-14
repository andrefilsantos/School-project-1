﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    sealed class Atleta : Pessoa
    {
        //-----------------------------------------------------------
        public static Pessoa Treinador { get; private set; }
        private double _peso;

        //-----------------------------------------------------------
        public Atleta() { }

        //-----------------------------------------------------------
        public Atleta(string _nome, DateTime _dateNasc, Morada _moradaPessoa, double peso) : base(_nome, _dateNasc, _moradaPessoa)
        {
            _peso = peso;
        }

        //-----------------------------------------------------------
        static Atleta()
        {
            Treinador = new Atleta("Rui Carlos Pinho da Vitória", new DateTime(1970, 04, 16), new Morada("Alverca do Ribatejo", "Vila Franca de Xira", "0000-000"), 78);
        }

        //-----------------------------------------------------------
        public double Peso
        {
            //-----------------------------------------------------------
            get
            {
                return _peso;
            }

            //-----------------------------------------------------------
            set
            {
                if (_peso > 0)
                    _peso = value;
            }
        }

        //-----------------------------------------------------------
        public override void Write(XmlWriter writer)
        {
            writer.WriteStartElement("Atleta");
            writer.WriteAttributeString("Nome", Nome);
            writer.WriteAttributeString("Peso", _peso.ToString());
            writer.WriteAttributeString("Dia", DataNasc.Day.ToString());
            writer.WriteAttributeString("Mes", DataNasc.Month.ToString());
            writer.WriteAttributeString("Ano", DataNasc.Year.ToString());
            MoradaPessoa.Write(writer);
            writer.WriteEndElement();
        }

        //-----------------------------------------------------------
        public override void Read(XmlReader reader)
        {
            Nome = reader.GetAttribute("Nome");
            var year = Convert.ToInt32(reader.GetAttribute("Ano"));
            var month = Convert.ToInt32(reader.GetAttribute("Mes"));
            var day = Convert.ToInt32(reader.GetAttribute("Dia"));
            _peso = Convert.ToInt32(reader.GetAttribute("Peso"));
            MoradaPessoa.Read(reader);
            DataNasc = new DateTime(year, month, day);
            Console.WriteLine(Nome + " " + year + " " + month + " " + day + " " + MoradaPessoa.Rua + " " + MoradaPessoa.Localidade + " " + MoradaPessoa.CodigoPostal + " " + _peso);
        }

        //-----------------------------------------------------------
        public override string ToString()
        {
            return "[A] " + base.Nome;
        }
    }
}