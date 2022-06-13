using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekEnd1.Part1;
namespace TestProject1
{
    class FakeTemplate : CarTemplate, IVehicle, ICar
    {
        public int count = 0;

        string IVehicle.LicencePlate()
        {
            count += 1;
            return "PATATE3000";// base.LicencePlate();
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var iface = new FakeTemplate();
            var auto = new WeekEnd1.Part1.FiatPanda(iface);
            Assert.AreEqual("PATATE3000", auto.LicencePlate());
            Assert.AreEqual(1, iface.count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var iface = new WeekEnd1.Part1.CarTemplate();
            var auto = new WeekEnd1.Part1.FiatPanda(iface);
            Assert.ThrowsException<System.NotImplementedException>(() => auto.LicencePlate());
        }
    }
}
