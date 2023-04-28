using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDonneLab5Partie4.model
{
    internal class FileManager
    {

        public static void EnregisterAPIKEY(string apikey)
        {
            if (File.Exists("apikeyFile"))
            {
                File.Delete("apikeyFile");
            }
            FileStream fs = File.Create("apikeyFile");
            using (StreamWriter writer = new StreamWriter("apikeyFile"))
            {
                writer.WriteLine("Monica Rathbun");
                writer.WriteLine("Vidya Agarwal");
                writer.WriteLine("Mahesh Chand");
                writer.WriteLine("Vijay Anand");
                writer.WriteLine("Jignesh Trivedi");
            }
        }
        public static string GetApiKey()
        {
            return "";
        }
    }
}
