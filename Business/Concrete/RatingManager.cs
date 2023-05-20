using Business.Abstract;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Business.Concrete
{
    public class RatingManager : ManagerBaseRepository<Rating>, IRatingService
    {
        public RatingManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public List<Rating> GetByRecord(int recordId, RatingTypes type)
        {
            TokenCheck();
            var response = Client.PostAsync(Endpoint + @"/getbyrecord?recordId=" + recordId + @"&type=" + (int)type,
                                            new StringContent("", Encoding.UTF8, "application/json")).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<Rating>>(data);

            return result;
        }

        public void SaveRating(Rating rating)
        {
            TokenCheck();
            var json = JsonConvert.SerializeObject(rating);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync(Endpoint + @"/saverating", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }
        }
    }
}
