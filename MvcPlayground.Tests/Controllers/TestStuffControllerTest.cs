using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcPlayground.Controllers;
using System.Web.Mvc;

namespace MvcPlayground.Tests.Controllers
{
    [TestClass]
    public class TestStuffControllerTest
    {

        private TestStuffController CreateController()
        {
            return new TestStuffController();
        }

        [TestMethod]
        public void TestProgressBarPartial()
        {
            TestStuffController controller = CreateController();

            ActionResult result = controller.TestProgress();

            Assert.IsInstanceOfType(result, typeof(PartialViewResult));
        }

        public void TestNothing()
        {
            TestStuffController controller = CreateController();

            ActionResult result = controller.TestNothing();

            Assert.IsNull(result);
        }
    }
}
