using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10_T01_N02_N25
{
    class Global
    {
        public static Clube ClubeRef;

        public static void SetClube(ref Clube clube)
        {
            ClubeRef = clube;
        }
    }
}
