using Entities.Models.RequestModels;
using System.IO;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        Stream Pay(PaymentModel model);
    }
}
