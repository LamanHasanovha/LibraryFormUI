using System.Collections.Generic;

namespace Entities.Models.RequestModels
{
    public class PaymentModel
    {
        public PaymentModel() { }

        public AccountInfoModel AccountInfo { get; set; }
        public List<OrderInfoModel> Orders { get; set; }
    }
}
