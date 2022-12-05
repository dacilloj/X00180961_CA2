using Domain;
using Domain.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using X00180961_CA2.Controllers;

namespace API_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRepository repo = new MockDB();
            ProductController testContoller = new StudentMockDBController(repo);
        }
    }
}
