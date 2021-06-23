using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RecipeCooking.CookingApi.Recipe
{
    public class RecipeApi
    {
        private string Base_Url = "https://localhost:44388/cooking/";


        public Task<HttpResponseMessage> FindAll()
        {
            try
            {
                var httpclient = new HttpClient();
                httpclient.BaseAddress = new Uri(Base_Url);
                httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                return httpclient.GetAsync("recipefindall");
            }
            catch
            {
                return null;
            }
        }
    }
}
