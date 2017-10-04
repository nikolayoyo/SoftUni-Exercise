using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emergency_Skeleton.Core;
namespace EmergencyManagementSystem.Test
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            var system = new Emergency_Skeleton.Core.EmergencyManagementSystem();

           var result = system.RegisterEmergency("RegisterPropertyEmergency|Test|Minor|12:24 25/02/2016|2500");

            Assert.AreEqual("Registered Public Property Emergency of level Minor at 12:24 25/02/2016.", result);
        }
    }
}
