using Business.Abstract;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Business.Concrete
{
    public class AuthCodeManager : ManagerBaseRepository<AuthCode>, IAuthCodeService
    {
        public AuthCodeManager(HttpClient client, string baseAddress, UserForLoginModel userForLoginModel) : base(client, baseAddress, userForLoginModel)
        {
        }

        public bool CheckAuthCode(int accountId, string code)
        {
            TokenCheck();
            var response = Client.PostAsync(Endpoint + @"/checkauthcode?accountId=" + accountId + @"&code=" + code, new StringContent("", Encoding.UTF8, "application/json")).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }

            var result = JsonConvert.DeserializeObject<bool>(data);

            return result;
        }

        public void SendAuthCode(int accountId)
        {
            TokenCheck();
            var response = Client.PostAsync(Endpoint + @"/sendauthcode?accountId=" + accountId, new StringContent("", Encoding.UTF8, "application/json")).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var temp = JsonConvert.DeserializeObject<ProblemDetails>(data);
                throw new Exception(temp.Title + " : " + temp.Status + "\n" + temp.Detail);
            }
        }
    }
}
