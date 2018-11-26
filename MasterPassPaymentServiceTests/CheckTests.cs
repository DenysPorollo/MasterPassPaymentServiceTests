using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using MasterPassPaymentService;

namespace MasterPassPaymentServiceTests
{
    /// <summary>
    /// Summary description for CheckTests
    /// </summary>
    [TestClass]
    public class CheckTests
    {
        [TestMethod]
        public void Check_CORRECT_guid_RETURN_RC_OK()
        {
            //Arrange
            string guid = "8F322CAA-EF25-4D52-992B-1754343B67BE";

            //expected
            Int32 expected_errorCode = 0;
            string expected_errorMessage = "OK";
            double expected_amountLimit = 500.1;


            //Act
            dynamic result = JsonConvert.DeserializeObject(SwaggerMethodsMasterPassPaymentService.Check(guid));

            //Assert

            Assert.IsTrue((bool)result.allowMasterPass);
            Assert.AreEqual(expected_errorCode, (Int32)result.errorCode);
            Assert.AreEqual(expected_errorMessage, (string)result.errorMessage);
            Assert.AreEqual(expected_amountLimit, (double)result.amountLimit);

        }
    }
}
