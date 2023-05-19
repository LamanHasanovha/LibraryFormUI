using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Business.Concrete
{
    public class BookGenreListManager : ManagerBaseRepository<BookGenreList>, IBookGenreListService
    {
        public BookGenreListManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public void DeleteByBook(int recordId)
        {
            TokenCheck();
            var response = Client.PostAsync(Endpoint + @"/deletebybook?id=" + recordId, new StringContent("", Encoding.UTF8, "application/json")).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }
        }

        public List<BookGenreList> GetByBook(int recordId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbybook?id=" + recordId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<BookGenreList>>(data);

            return result;
        }

        public List<BookGenreList> UpdateByBook(List<BookGenreList> list)
        {
            TokenCheck();
            var json = JsonConvert.SerializeObject(list);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync(Endpoint + @"updatebybook", content).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<BookGenreList>>(data);

            return result;
        }
    }
}
