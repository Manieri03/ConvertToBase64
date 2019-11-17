using System;
using System.Text;

namespace LibraryMethodConversion
{
    public class Base64class
    {

        public static string Base64()
        {
            string input = "Ciao";
            byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(input);

            string r = Convert.ToBase64String(toEncodeAsBytes);

            return r;
        }


    }
}
