using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Entities.Models.ResponseModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Business.Concrete
{
    public class BookWishListManager : ManagerBaseRepository<BookWishList>, IBookWishListService
    {
        public BookWishListManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public List<BookResponseModel> GetByAccount(int accountId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbyaccount?id=" + accountId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<BookResponseModel>>(data);

            return result;
        }

        public void RemoveByAccount(int accountId, int bookId)
        {
            TokenCheck();
            var response = Client.PostAsync(Endpoint + @"/removebyaccount?accountId=" + accountId + @"&bookId=" + bookId, new StringContent("", Encoding.UTF8, "application/json")).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }
        }
    }
}
