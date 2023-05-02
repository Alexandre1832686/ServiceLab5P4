using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using ServiceDonneLab5Partie4.vue;
using System.Reflection.Metadata;
using System.Windows.Media;

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

        public static async Task<bool> checkApiKey(string ApiKey)
        {
            string url = "";

            url = ApiHelper.ApiClient.BaseAddress + "mon/CheckApiKey/" + ApiKey;
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        bool rep = await response.Content.ReadAsAsync<bool>().ConfigureAwait(false);

                        return rep;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception e)
            {
                if (e.Message == "Aucune connexion n’a pu être établie car l’ordinateur cible l’a expressément refusée. (localhost:7067)")
                    return false;
                else
                    throw e;
            }
        }

        public static async Task<string> GenerateApiKey()
        {
            string url = "";

            url = ApiHelper.ApiClient.BaseAddress + "mon/GenerateApiKey";

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
            catch (Exception e)
            {
                if (e.Message == "Aucune connexion n’a pu être établie car l’ordinateur cible l’a expressément refusée. (localhost:7067)")
                    return "Erreur de connection au server api web.";
                else
                    throw e;
            }

        }

        public static async Task<List<Cour>> GetListeCourParEtu(string codePerma)
        {
            string url = "";
            url = ApiHelper.ApiClient.BaseAddress + "mon/GetCoursByCodePerma/" + codePerma;
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        List<Cour> rep = await response.Content.ReadAsAsync<List<Cour>>().ConfigureAwait(false);
                        return rep;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception e)
            {
                if (e.Message == "Aucune connexion n’a pu être établie car l’ordinateur cible l’a expressément refusée. (localhost:7067)")
                    return new List<Cour>();
                else
                    throw e;
            }
        }
        public static async Task<List<Student>> GetListeEtuParCour(string nomCour)
        {
            string url = "";
            url = ApiHelper.ApiClient.BaseAddress + "mon/GetNomStudentsParCours/" + nomCour;
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        List<Student> rep = await response.Content.ReadAsAsync<List<Student>>().ConfigureAwait(false);
                        return rep;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception e)
            {
                if (e.Message == "Aucune connexion n’a pu être établie car l’ordinateur cible l’a expressément refusée. (localhost:7067)")
                    return new List<Student>();
                else
                    throw e;
            }
        }

        public static async Task<List<Cour>> GetListeCourParProf(string prenom, string nom)
        {
            string url = "";
            url = ApiHelper.ApiClient.BaseAddress + "mon/GetCoursEnseignant/" + prenom + "/" + nom;
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        List<Cour> rep = await response.Content.ReadAsAsync<List<Cour>>().ConfigureAwait(false);
                        return rep;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception e)
            {
                if (e.Message == "Aucune connexion n’a pu être établie car l’ordinateur cible l’a expressément refusée. (localhost:7067)")
                    return new List<Cour>();
                else
                    throw e;
            }
        }

        public static async Task<Buletin> GetBuletin(string prenom, string nom)
        {
            string url = "";
            url = ApiHelper.ApiClient.BaseAddress + "mon/BuletinÉtudiant/" + prenom + "/" + nom;
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        Buletin rep = await response.Content.ReadAsAsync<Buletin>().ConfigureAwait(false);
                        return rep;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception e)
            {
                if (e.Message == "Aucune connexion n’a pu être établie car l’ordinateur cible l’a expressément refusée. (localhost:7067)")
                    return new Buletin();
                else
                    throw e;
            }
        }

        public static async Task<List<Student>> GetDiplomeParAnnee(string annee)
        {
            string url = "";
            url = ApiHelper.ApiClient.BaseAddress + "mon/DiplomeParAnnee/" + annee ;
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        List<Student> rep = await response.Content.ReadAsAsync<List<Student>>().ConfigureAwait(false);
                        return rep;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception e)
            {
                if (e.Message == "Aucune connexion n’a pu être établie car l’ordinateur cible l’a expressément refusée. (localhost:7067)")
                    return new List<Student>();
                else
                    throw e;
            }
        }

        public static async Task<string> CreeCour(string Sigle,string Titre,string Duree)
        {
            string url = "";
            url = ApiHelper.ApiClient.BaseAddress + "mon/CreerCour/" + Sigle + "/" + Titre + "/" + Duree;
            try
            {
                using (HttpResponseMessage message = await ApiHelper.ApiClient.PostAsync(url, new StringContent(string.Empty)))
                {
                    if (message.IsSuccessStatusCode)
                    {
                        string rep = await message.Content.ReadAsAsync<string>().ConfigureAwait(false);
                        return rep;
                    }
                    else
                    {
                        throw new Exception(message.ReasonPhrase);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<string> AjouterEtuCour(string prenom, string nom, string sigle)
        {
            string url = "";
            url = "mon/AjoutEtuACour/" + prenom + "/" + nom + "/" + sigle;
            try
            {
                using (var message = await ApiHelper.ApiClient.PutAsync(url, new StringContent(string.Empty)))
                {
                    if (message.StatusCode == HttpStatusCode.OK)
                    {
                        string a = await message.Content.ReadAsAsync<string>();
                        return a;
                    }
                    else
                    {
                        throw new Exception(message.StatusCode.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                return "";
            }

            
        }
        public static async Task<string> ModifierNote(string prenom, string nom, int note, string sigle, int session)
        {
            string url = "";
            url = "mon/ModifierNote/" + prenom + "/" + nom + "/" + note + "/" + sigle + "/" + session;
            try
            {
                using (var message = await ApiHelper.ApiClient.PutAsync(url, new StringContent(string.Empty)))
                {
                    if (message.StatusCode == HttpStatusCode.OK)
                    {
                        string a = await message.Content.ReadAsAsync<string>();
                        return a;
                    }
                    else
                    {
                        throw new Exception(message.StatusCode.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                return "";
            }


        }

        public static async Task<string> RetirerEtuCour(string prenom, string nom, string sigle, int session)
        {
            string url = "";
            url = "mon/DeleteEtuFromCours/" + prenom + "/" + nom + "/" + sigle + "/" + session;
            try
            {
                using (var message = await ApiHelper.ApiClient.DeleteAsync(url))
                {
                    if (message.StatusCode == HttpStatusCode.OK)
                    {
                        string a = await message.Content.ReadAsAsync<string>();
                        return a;
                    }
                    else
                    {
                        throw new Exception(message.StatusCode.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                return "";
            }


        }
        
    }
}
