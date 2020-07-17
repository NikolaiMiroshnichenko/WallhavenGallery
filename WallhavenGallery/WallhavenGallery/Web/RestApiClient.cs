using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WallhavenGallery.Web
{
    public class RestApiClient
    {
        HttpClient httpClient = new HttpClient();
        private const string BaseUrl = "https://wallhaven.cc/api/v1/search?apikey=mgUbMpAaSerVpVSog4w5aTUdSl0OLxGI";
        public async void webThings()
        {
            HttpResponseMessage response = httpClient.GetAsync()
        }
       
    }
}
