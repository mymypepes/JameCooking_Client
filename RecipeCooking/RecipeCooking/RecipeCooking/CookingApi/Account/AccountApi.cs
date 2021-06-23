using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RecipeCooking.CookingApi.Account
{
    public class AccountApi
    {
        private string Base_Url = "https://localhost:44388/cooking/";


        public Task<HttpResponseMessage> Create(AccountApi account)
        {
            try
            {
                var httpclient = new HttpClient();
                httpclient.BaseAddress = new Uri(Base_Url);
                httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                return httpclient.GetAsync("create");
            }
            catch
            {
                return null;
            }
        }
    }
}
