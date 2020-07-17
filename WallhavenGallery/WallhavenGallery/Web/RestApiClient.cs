using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WallhavenGallery.Models;

namespace WallhavenGallery.Web
{
    public class RestApiClient
    {
        HttpClient httpClient = new HttpClient();
        private const string BaseUrl = "https://wallhaven.cc/api/v1/search?apikey=mgUbMpAaSerVpVSog4w5aTUdSl0OLxGI";
        public async Task<IEnumerable<ImageModel>> GetAll()
        {
            try
            {
                var response = await httpClient.GetAsync(BaseUrl);
                if (response.IsSuccessStatusCode)
                {
                    var ImageModels = JsonConvert.DeserializeObject<IEnumerable<ImageModel>>(await response.Content.ReadAsStringAsync());
                    return ImageModels;
                }
            }
            catch (Exception ex)
            {
                
            }
            return new List<ImageModel>();
        }   
       
    }
}
