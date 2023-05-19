using Business.Abstract;
using Entities.Abstract;
using Entities.Models.RequestModels;
using Entities.Models.ResponseModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Business.Concrete
{
    public class ManagerBaseRepository<T> : IServiceRepository<T> where T : class, IEntity, new()
    {
        private PluralizationService PluralService { get; set; }
        public HttpClient Client { get; set; }
        public string BaseAddress { get; set; }
        public string Endpoint
        {
            get
            {
                return @"api/" + PluralService.Pluralize(typeof(T).Name.ToLower());
            }
        }
        public string Token { get; set; }
        public DateTime TokenExpirationDate { get; set; }
        protected UserForLoginModel UserForLoginModel { get; set; }

        public ManagerBaseRepository(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel)
        {
            UserForLoginModel = userForLoginModel;
            BaseAddress = baseAddress;
            this.BuildClient(client);
            PluralService = PluralizationService.CreateService(new CultureInfo("en-US"));
        }

        protected TTarget Map<TCurrent, TTarget>(TCurrent source)
        {
            var data = Activator.CreateInstance<TTarget>();

            var targetProperties = source.GetType().GetProperties();
            var destinationProperties = data.GetType().GetProperties();

            foreach (var dp in destinationProperties)
            {
                var val = targetProperties.FirstOrDefault(p => p.Name == dp.Name)?.GetValue(source);
                dp.SetValue(data, val);
            }

            return data;
        }
        private void BuildClient(HttpClient client)
        {
            Client = client;
            client.BaseAddress = new Uri(BaseAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public virtual T Add(T entity)
        {
            TokenCheck();
            var json = JsonConvert.SerializeObject(entity);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync(Endpoint + @"/addasync", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<T>(data);

            return result;
        }

        public virtual T Delete(T entity)
        {
            TokenCheck();
            var json = JsonConvert.SerializeObject(entity);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync(Endpoint + @"/deleteasync", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<T>(data);

            return result;
        }

        public virtual void DeleteAll()
        {
            TokenCheck();
            var response = Client
                .PostAsync(Endpoint + @"/deleteallasync", new StringContent("", Encoding.UTF8, "application/json")).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }
        }

        public virtual T Get(int id)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getasync?id=" + id).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<T>(data);

            return result;
        }

        public virtual List<T> GetAll()
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getallasync").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<T>>(data);

            return result;
        }

        public virtual T Update(T entity)
        {
            TokenCheck();
            var json = JsonConvert.SerializeObject(entity);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync(Endpoint + @"/updateasync", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<T>(data);

            return result;

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
    }
}
