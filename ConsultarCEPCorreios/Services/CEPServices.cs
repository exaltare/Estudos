using ConsultarCEPCorreios.Model;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsultarCEPCorreios.Services
{

    public class CEPServices
    {
        public async Task<CEPResponseModel> GetDataCEP(string CEP)
        {
            string Url = $"https://viacep.com.br/ws/{CEP}/json/";
            var client = new HttpClient();
            var request = new HttpRequestMessage();
            
            request.RequestUri = new Uri(Url);
            request.Method = HttpMethod.Get;

            request.Headers.Add("Accept", "*/*");
            
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();

            CEPResponseModel  CEPModel = JsonSerializer.Deserialize<CEPResponseModel>(result);

            return CEPModel;

        }
    }
}
