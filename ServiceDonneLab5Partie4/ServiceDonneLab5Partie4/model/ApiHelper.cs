using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDonneLab5Partie4.model
{
    internal class ApiHelper
    {
        public static HttpClient ApiClient { get; set; } = new HttpClient();

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ApiClient.BaseAddress = new Uri("https://localhost:7067/");
        }

        public static async Task<string> GetNomStudent(string CodePerma)
        {
            string url = "";

            url = ApiHelper.ApiClient.BaseAddress + "mon/GetNomStudentByCodePerma/" + CodePerma;

            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string rep = await response.Content.ReadAsAsync<string>().ConfigureAwait(false);

                        return rep;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch(Exception e)
            {
                if (e.Message == "Aucune connexion n’a pu être établie car l’ordinateur cible l’a expressément refusée. (localhost:7067)")
                    return "Erreur de connection au server api web.";
                else
                    throw e;
            }

        }
    }
}
