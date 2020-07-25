using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WallhavenGallery.Models;
using WallhavenGallery.Services.Interfaces;

namespace WallhavenGallery.Services
{
    public class RestApiClient : IRestApiClient
    {
        private const string BaseUrl = "https://wallhaven.cc/api/v1/search?";
        private StringBuilder stringBuilder = new StringBuilder(BaseUrl);
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<ResponseModel> GetAsyncAll()
        {
            var response = await _httpClient.GetAsync(stringBuilder.Append("apikey=mgUbMpAaSerVpVSog4w5aTUdSl0OLxGI").ToString());
            if (response.IsSuccessStatusCode)
            {
                var imageModel = ResponseModel.FromJson(await response.Content.ReadAsStringAsync());
                return imageModel;
            }
            return null;
        }

        public async Task<ResponseModel> GetAsyncByCategory(string category)
        {
            var response = await _httpClient.GetAsync(stringBuilder.Append("q="+category).ToString());
            if (response.IsSuccessStatusCode)
            {
                var imageModel = ResponseModel.FromJson(await response.Content.ReadAsStringAsync());
                return imageModel;
            }
            return null;
        }
    }
}
