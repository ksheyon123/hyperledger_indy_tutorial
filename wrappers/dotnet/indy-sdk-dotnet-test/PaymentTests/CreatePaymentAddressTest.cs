using Hyperledger.Indy.PaymentsApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Hyperledger.Indy.Test.PairwiseTests
{
    [TestClass]
    public class CreatePaymentAddressTest : PaymentIntegrationTestBase
    {
        [TestMethod]
        public async Task TestCreatePaymentAddressWorksForUnknownPaymentMethod()
        {
            var ex = await Assert.ThrowsExceptionAsync<UnknownPaymentMethodException>(() =>
                 Payments.CreatePaymentAddressAsync(wallet, paymentMethod, "{}")
             );
        }
    }
}
