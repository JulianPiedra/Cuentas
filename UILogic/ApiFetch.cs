using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace UILogic
{
    public static class ApiFetch
    {
        private static readonly string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];


        public static async Task<T> FetchAsync<T>(
            string url,
            HttpMethod method,
            object? body = null)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpRequestMessage request = new HttpRequestMessage(method, $"/api{url}");

                    if (body != null)
                    {
                        var json = JsonConvert.SerializeObject(body);
                        request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    }

                    HttpResponseMessage response = await client.SendAsync(request);
                    var bodyResponse = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return default(T)!;
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(bodyResponse)!;
                    }
                    else
                    {
                        // Intentar extraer el mensaje de error del JSON
                        string apiMessage;
                        try
                        {
                            var jsonObj = JObject.Parse(bodyResponse);
                            apiMessage = jsonObj["message"]?.ToString() ?? bodyResponse;
                        }
                        catch
                        {
                            apiMessage = bodyResponse; // Si no es JSON, devolver el contenido tal cual
                        }

                        throw new Exception($"Error {response.StatusCode}: {apiMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al realizar la solicitud a la API: {ex.Message}", ex);
            }
        }

    }
}

