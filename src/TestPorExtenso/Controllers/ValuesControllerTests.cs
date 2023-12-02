using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace PorExtenso.Controllers.Tests
{
    public class ValuesControllerTests
    {
        [Test()]
        public void Test_NaoAceitarMaiorQueLimiteDeRange()
        {
            PorExtenso.Controllers.ValuesController valuesController = new ValuesController();
            var ret = valuesController.Get(1000000);
            var expected = 400;
            Assert.AreEqual(expected, ((BadRequestObjectResult)ret).StatusCode);
        }
    }
}