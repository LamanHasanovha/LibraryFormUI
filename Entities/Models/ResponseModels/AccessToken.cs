using System;

namespace Entities.Models.ResponseModels
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
