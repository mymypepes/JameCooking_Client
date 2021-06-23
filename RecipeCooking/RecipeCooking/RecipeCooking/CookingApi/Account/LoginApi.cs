using CookingApi.Models;
using Newtonsoft.Json;
using RecipeCooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCooking.CookingApi.Recipe
{
    public class LoginApi
    {
        private string Base_Url = "https://localhost:44357/login";


        public async Task<LoginResponse> Login(string user, string password)
        {
            try
            {
                var httpclient = new HttpClient();
                object requestBody = new
                {
                    username = user,
                    password = password
                };
                var json = JsonConvert.SerializeObject(requestBody);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var response = await httpclient.PostAsync(Base_Url + "/login", stringContent);
                var data = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<LoginResponse>(data);
                return result;
            }
            catch
            {
                return null;
            }
        }
        public async Task<RegisterResponse> Register(string user, string password, string fullname, string email, string phone)
        {
            try
            {
                var httpclient = new HttpClient();
                object requestBody = new
                {
                    username = user,
                    password = password,
                    fullname = fullname,
                    email = email,
                    phone = phone
                };
                var json = JsonConvert.SerializeObject(requestBody);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var response = await httpclient.PostAsync(Base_Url + "/register", stringContent);
                var data = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<RegisterResponse>(data);
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
