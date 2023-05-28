using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Entities.Models.ResponseModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Business.Concrete
{
    public class RecommenderManager : IRecommenderService
    {
        public HttpClient Client { get; set; }
        public string BaseAddress { get; set; }
        public string Endpoint
        {
            get
            {
                return @"api/recommenders";
            }
        }
        public string Token { get; set; }
        public DateTime TokenExpirationDate { get; set; }
        protected UserForLoginModel UserForLoginModel { get; set; }

        public RecommenderManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel)
        {
            Client = client;
            BaseAddress = baseAddress;
            BuildClient(client);
            UserForLoginModel = userForLoginModel;
        }

        private void BuildClient(HttpClient client)
        {
            Client = client;
            client.BaseAddress = new Uri(BaseAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected void TokenCheck()
        {
            if (TokenExpirationDate > DateTime.Now)
                return;

            var result = this.Login(UserForLoginModel);
            TokenExpirationDate = result.AccessToken.Expiration;
            Token = result.AccessToken.Token;
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
        }

        protected virtual UserLoginResponseModel Login(UserForLoginModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync($"api/auth/login", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<UserLoginResponseModel>(data);

            return result;
        }

        protected virtual UserRegisterResponseModel Register(UserForRegisterModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync($"api/auth/login", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<UserRegisterResponseModel>(data);

            return result;
        }

        public List<Book> GetBooks(int bookId, int count)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbooks?bookId=" + bookId + @"&count=" + count).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<Book>>(data);

            return result;
        }

        public List<Book> GetBooksByAccount(int accountId, int count)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbooksbyaccount?accountId=" + accountId + @"&count=" + count).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<Book>>(data);

            return result;
        }

        public List<Movie> GetMovies(int movieId, int count)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getmovies?movieId=" + movieId + @"&count=" + count).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<Movie>>(data);

            return result;
        }

        public List<Movie> GetMoviesByAccount(int accountId, int count)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getmoviesbyaccount?accountId=" + accountId + @"&count=" + count).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<Movie>>(data);

            return result;
        }
    }
}
