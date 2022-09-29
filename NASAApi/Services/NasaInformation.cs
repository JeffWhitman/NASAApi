using Microsoft.Extensions.Configuration;
using NASAApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NASAApi.Services
{
    public class NasaInformation
    {
        private string ApiKey = string.Empty;

        public NasaInformation()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
            IConfigurationRoot root = builder.Build();
            ApiKey = root["APIKey"];

        }
        public async Task<ResponseData> GetNasaInformation(RequestData requestData)
        {
            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.nasa.gov/planetary/apod?date={requestData.date}&api_key={ApiKey}");

                HttpResponseMessage responseNasaData = client.SendAsync(request).Result;

                if (responseNasaData.IsSuccessStatusCode)
                {
                    var result = await responseNasaData.Content.ReadFromJsonAsync<ResponseData>();

                    return result;
                }
                else
                {
                    return new ResponseData { ErrorMessage=responseNasaData.ReasonPhrase};

                }
            }
        }
    }
}
