using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
            var subscription = new Subscription(null);
            var student = new Student("Enderson", "Rufino", "12345678910", "endersonrufino@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}
