using System.Net.Http;
using System.Threading.Tasks;
using lab16.Models;
using Newtonsoft.Json;

namespace lab16.ViewModels
{
    public class ApiManager
    {
        private const string ApiUrl = "https://api-xamarin.vercel.app/gatos";

        public async Task<Gatos[]> GetGatosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(ApiUrl);
                var gatosResponse = JsonConvert.DeserializeObject<GatosResponse>(response);
                return gatosResponse.Gatos;
            }
        }
    }
}
