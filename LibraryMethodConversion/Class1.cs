using System;

namespace LibraryMethodConversion
{
    public class Class1
    {
        public class LibraryBase64
        {
            public static string Base64()
            {
                string toEncode = "Nicola";
                byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(toEncode);

                string returnValue = Convert.ToBase64String(toEncodeAsBytes);

                return returnValue;
            }
        }
}
