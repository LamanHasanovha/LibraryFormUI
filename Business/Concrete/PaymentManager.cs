using Business.Abstract;
using Entities.Models.RequestModels;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        public HttpClient Client { get; set; }
        public string Endpoint { get; set; }

        public PaymentManager() 
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(@"https://localhost:7253/");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Endpoint = @"api/Payments";
        }

        public Stream Pay(PaymentModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync(Endpoint + @"/pay", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var file = response.Content.ReadAsStreamAsync().Result;

            return file;
        }
    }
}
