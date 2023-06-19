using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Business.Concrete
{
    public class ActorManager : ManagerBaseRepository<Actor>, IActorService
    {
        public ActorManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public Actor GetRandomActor()
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getrandomactor").Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<Actor>(data);

            return result;
        }
    }
}
