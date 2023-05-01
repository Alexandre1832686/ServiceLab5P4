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

            try
            {
                // Creating a new file, or overwrite
                // if the file already exists.
                using (FileStream fs = File.Create("apikeyFile"))
                {
                    // Adding some info into the file
                    byte[] info = new UTF8Encoding(true).GetBytes(apikey);
                    fs.Write(info, 0, info.Length);
                }

            }
            catch(Exception e)
            {
                
            }
            
            
        }
        public static string GetApiKey()
        {
            string retour = "";
            using (StreamReader sr = File.OpenText("apikeyFile"))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                   retour = s;
                }
            }
            return retour;
        }
    }
}
