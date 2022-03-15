using ExternalService.Model.Requests;
using ExternalService.Model.Responses;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExternalService.src
{
    public static class RequestSender
    {
        public static async Task<IExternalServiceResponse> Send(string URL, IExternalServiceRequest externalServiceRequest)
        {
            string jsonResponse;
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, URL))
                {
                    var response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException(statusCode: response.StatusCode, message: response.ReasonPhrase, inner: null);
                    }
                    //todo Проверить json ли
                    jsonResponse = response.Content.ToString();
                }
            }

            // Не уверен, что это сработает
            switch ((IExternalServiceRequest)externalServiceRequest.GetType())
            {
                case RegulaServiceRequest: return JsonSerializer.Deserialize<RegulaResponse>(jsonResponse);
                default: throw new Exception("Непредвиденный тип запроса сервиса");
            }
        }
    }
}
