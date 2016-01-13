using System;
using System.Runtime.InteropServices;

//I dont want to set the world on fire
//-----------------------------------------------------------
namespace M10_T01_N02_N25
{
    //-----------------------------------------------------------
    class Util
    {
        //-----------------------------------------------------------
        public static void GC_CLEANUP()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        //-----------------------------------------------------------
        public static string BoolToStringAdj(bool val) => val ? "ligado" : "desligado";
        public static string BoolToStringVrb(bool val) => val ? "liga-lo" : "desliga-lo";
        public static string BoolToStringStatus(bool val) => val ? "Enable" : "Disable";
    }

    //-----------------------------------------------------------0
    public delegate void IsSetHandler(object sender, EditarEventArgs e);
}

