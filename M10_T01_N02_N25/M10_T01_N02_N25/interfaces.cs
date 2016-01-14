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
    interface IXmlWritable
    {
        void Write(XmlWriter writer);
    }

    //-----------------------------------------------------------
    interface IXmlReadable
    {
        void Read(XmlReader reader);
    }
}
