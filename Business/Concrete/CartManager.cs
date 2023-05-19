using Business.Abstract;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using Entities.Models.ResponseModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Business.Concrete
{
    public class CartManager : ManagerBaseRepository<Cart>, ICartService
    {
        public CartManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public bool Check(int accountId, int recordId, ProductTypes type)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/check?accountId=" + accountId + @"&recordId=" + recordId + @"&type=" + (int)type).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<bool>(data);

            return result;
        }

        public List<CartResponseModel> GetByAccount(int id)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbyaccount?id=" + id).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<CartResponseModel>>(data);

            return result;
        }

        public void RemoveByAccount(int accountId, int recordId, ProductTypes type)
        {
            TokenCheck();
            var response = Client.PostAsync(Endpoint + @"/removebyaccount?accountId=" + accountId + @"&recordId=" + recordId + @"&type=" + (int)type,
                                            new StringContent("", Encoding.UTF8, "application/json")).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }
        }
    }
}
