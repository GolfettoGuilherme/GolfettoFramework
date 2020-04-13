using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GolfettoFramework.Core.HttpUtilities
{
    public class SimpleRequest
    {

        HttpClient _httpClient;

        public SimpleRequest()
        {
            this._httpClient = new HttpClient();
        }

        public SimpleRequest(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        /// <summary>
        /// Realiza um Get para a URL solicitada com os parametros informados
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="queryParams">Parametros, nome=valor, separados por & (Não precisa colocar ?)</param>
        /// <returns>string = Resultado do Request</returns>
        public string GetString(string url, string queryParams = null)
        {
            try
            {
                url = queryParams != null ? $"{url}?{queryParams}" : url;
                var ret = this._httpClient.GetStringAsync(url).Result;
                if (!String.IsNullOrEmpty(ret))
                {
                    return ret;
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Realiza um Get para a URL solicitada com os parametros informados de forma Asincrona
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="queryParams">Parametros, nome=valor, separados por & (Não precisa colocar ?)</param>
        /// <returns>string = Resultado do Request</returns>
        public async Task<string> GetStringAsync(string url, string queryParams = null)
        {
            try
            {
                url = queryParams != null ? $"{url}?{queryParams}" : url;
                var ret = await this._httpClient.GetStringAsync(url);
                if (!String.IsNullOrEmpty(ret))
                {
                    return ret;
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GetJsonObject<T>(string url, string queryParams = null)
        {
            try
            {
                url = queryParams != null ? $"{url}?{queryParams}" : url;
                var ret = this._httpClient.GetStringAsync(url).Result;

                if (!String.IsNullOrEmpty(ret))
                {
                    var obj = JsonConvert.DeserializeObject<T>(ret);

                    return obj;
                }

            }
            catch (Exception)
            {

            }
            return default(T);
        }

        public async Task<T> GetJsonObjecAsync<T>(string url, string queryParams = null)
        {
            return default(T);
        }

        public T Post<T>(string url)
        {
            return default(T);
        }

        public async Task<T> PostAsync<T>(string url)
        {
            return default(T);
        }
    }
}
