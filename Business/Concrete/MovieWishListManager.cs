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
    public class MovieWishListManager : ManagerBaseRepository<MovieWishList>, IMovieWishListService
    {
        public MovieWishListManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public List<MovieResponseModel> GetByAccount(int accountId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbyaccount?id=" + accountId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<MovieResponseModel>>(data);

            return result;
        }

        public void RemoveByAccount(int accountId, int movieId)
        {
            TokenCheck();
            var response = Client.PostAsync(Endpoint + @"/removebyaccount?accountId=" + accountId + @"&movieId=" + movieId, new StringContent("", Encoding.UTF8, "application/json")).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }
        }
    }
}
