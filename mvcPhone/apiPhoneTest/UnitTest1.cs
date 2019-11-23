using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apiPhoneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestControllerExistePhoneExists()
        {
            //organizar
            var controller = new apiPhone.Controllers.PhonesController();
            //actuar
            bool response = controller.PhoneExists(2);
            Assert.AreEqual(false, response);
        }
    }
}
