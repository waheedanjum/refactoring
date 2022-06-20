using Smartwyre.DeveloperTest.Types;
using System.Threading.Tasks;

namespace Smartwyre.DeveloperTest.Services
{
    public interface IPaymentService
    {
        Task<MakePaymentResult> MakePaymentAsync(MakePaymentRequest request);
    }
}
