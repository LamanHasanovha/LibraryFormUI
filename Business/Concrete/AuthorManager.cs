using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Business.Concrete
{
    public class AuthorManager : ManagerBaseRepository<Author>, IAuthorService
    {
        public AuthorManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public Author GetRandomAuthor()
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getrandomauthor").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<Author>(data);

            return result;
        }
    }
}
