using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using MasterPassPaymentService;

namespace MasterPassPaymentServiceTests
{
    /// <summary>
    /// Summary description for PurchaseTests
    /// </summary>
    [TestClass]
    public class PurchaseTests
    {
        [TestMethod]
        public void Purchase_CORRECT_all_data_RETURN_OK()
        {

            //Arrange
            string guid         = InitialData.guid;
            string uniqueId     = InitialData.uniqueId;
            double amount       = InitialData.amount;
            int filialId        = InitialData.filialId;
            string frNumber     = InitialData.frNumber_wrong;
            string pos_ip       = InitialData.pos_ip_wrong;
            int localChequeId   = InitialData.localChequeId;
            int zId             = InitialData.zId_wrong;
            string posName      = InitialData.posName;
            string uuid         = InitialData.uuid;

            //expected
            Int32 expected_errorCode = 0;
            string expected_errorMessage = "OK";
            string expected_terminalId = "QR"+ filialId;

            //Act
            dynamic result = JsonConvert.DeserializeObject(SwaggerMethodsMasterPassPaymentService.Purchase(guid, uniqueId, filialId, posName, pos_ip, frNumber, zId, localChequeId, amount, uuid));


            //Assert
            Assert.AreEqual(expected_errorCode, (Int32)result.errorCode);
            Assert.AreEqual(expected_errorMessage, (string)result.errorMessage);
            Assert.AreEqual(expected_errorCode, (Int32)result.errorCode);
            Assert.AreEqual(expected_terminalId, (string)result.terminalId);

        }
    }
}
