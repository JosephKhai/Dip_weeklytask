using NUnit.Framework;
using Dip_weeklytask.Models;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void DefaultGetInfoTest()
        {

            Room r1 = new Room();

            Assert.AreEqual("TD224 - 22", r1.getInfo());

        }
    }
}