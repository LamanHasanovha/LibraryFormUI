using Business.Abstract;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using Entities.Models.ResponseModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Business.Concrete
{
    public class ReviewManager : ManagerBaseRepository<Review>, IReviewService
    {
        public ReviewManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public Review GetByAccount(int id, int recordId, RatingTypes type)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbyaccount?id=" + id + @"&recordId=" + recordId + @"&type=" + (int)type).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<Review>(data);

            return result;
        }

        public List<ReviewResponseModel> GetByType(int recordId, RatingTypes type)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbytype?recordId=" + recordId + @"&type=" + (int)type).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<ReviewResponseModel>>(data);

            return result;
        }
    }
}
