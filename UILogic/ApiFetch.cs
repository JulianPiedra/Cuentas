using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace UILogic
{
    public class ApiFetch
    {

        public async Task<object> FetchAsync(
            string baseUrl,
            string url,
            HttpMethod method,
            string? json)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpRequestMessage request = new HttpRequestMessage(method, url);

                if (!string.IsNullOrEmpty(json))
                {
                    request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                }

                HttpResponseMessage response = await client.SendAsync(request);
                var bodyResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return (bodyResponse);
                }

                try
                {
                    string errorMessage = bodyResponse?.FirstOrDefault()?.Mensaje ?? "Error desconocido";

                    return (errorMessage, (int)response.StatusCode);
                }
                catch (JsonSerializationException)
                {
                    return ("Ha ocurrido un error al deserializar la respuesta del servidor.", (int)response.StatusCode);
                }
            }
        }
    }
}
