using System;
using Refit;

namespace FESapp
{
    public static class NetworkService
    {
        private static ApiService apiService;
        public static string  baseUrl = "https://pure-ocean-29783.herokuapp.com/";
        public static ApiService getApiService()
        {
            if(apiService == null)
            {
                apiService = RestService.For<ApiService>(baseUrl);
                
            }
           
            return apiService;
        }
    }
}
