using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Business.Concrete
{
    public class MenuObjectManager : ManagerBaseRepository<MenuObject>, IMenuObjectService
    {
        public MenuObjectManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public List<MenuObject> GetByContent(int contentId)
        {
            TokenCheck();
            var response = Client.GetAsync(Endpoint + @"/getbycontent?id=" + contentId).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<List<MenuObject>>(data);

            return result;
        }
    }
}
