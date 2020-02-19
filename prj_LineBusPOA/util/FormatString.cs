using System;

namespace LineBusPOA.util
{
    class FormatString
    {

        public FormatString() { }

        public String formatString(String text)
        {
            string textFormated = String.Empty;

            return text
                .Replace("\\", "")
                .Replace("u00aa", "ª")
                .Replace("u00c1", "Á")
                .Replace("u00c3", "Ã")
                .Replace("u00c9", "É")
                //.Replace("u00ca", "É")
                .Replace("u00cd", "Í")
                .Replace("u00d4", "Ô")
                .Replace("u00d3", "Ó")
                .Replace("u00d5", "Õ")
                .Replace("u00da", "Ú")
                .Replace("u00c7", "Ç");
        }
    }
}