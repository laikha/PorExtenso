using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PorExtenso.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PorExtenso.Controllers.Tests
{
    [TestClass()]
    public class ValuesControllerTests
    {
        [TestMethod()]
        public void Test_NaoAceitarMaiorQueLimiteDeRange()
        {
            PorExtenso.Controllers.ValuesController valuesController = new ValuesController();
            var ret = valuesController.Get(1000000);
            var expected = 400;
            Assert.AreEqual(expected, ((BadRequestObjectResult)ret).StatusCode);
        }
    }
}