using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

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
        public static string BoolToStringVrb(bool val) => val ? "ligá-lo" : "desligá-lo";
        public static string BoolToStringStatus(bool val) => val ? "Enable" : "Disable";

        //From: http://www.siao2.com/2007/05/14/2629747.aspx---------
        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }

    //-----------------------------------------------------------
    public delegate void IsSetHandler(object sender, EditarEventArgs e);
}

