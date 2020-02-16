using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParsetheParcel;

namespace UnitTestCases
{
    [TestClass]
    public class UnitTest
    {
        decimal smallPrice;
        decimal mediumPrice;
        decimal largePrice;
        decimal invalidPrice;
        [TestInitialize]
        public void SetUp()
        {
            smallPrice = 5.00M;
            mediumPrice = 7.50M;
            largePrice = 8.50M;
            invalidPrice = 0M;
        }
        [TestMethod]
        public void TestSmallPackageParcel()
        {
            var parseTheParcel = new ParseTheParcel();
            decimal parcelCost = parseTheParcel.CalculateParcelCost(200, 300, 150, 2.5);
           Assert.AreEqual(smallPrice, parcelCost, "Small Package Parcel Test");
        }
        [TestMethod]
        public void TestLargePackageParcel()
        {
            var parseTheParcel = new ParseTheParcel();
            decimal parcelCost = parseTheParcel.CalculateParcelCost(200, 300, 250, 10);
            Assert.AreEqual(largePrice, parcelCost, "Large Package Parcel Condition Test");
        }
        [TestMethod]
        public void TestMediumPackageParcel()
        {
            var parseTheParcel = new ParseTheParcel();
            decimal parcelCost = parseTheParcel.CalculateParcelCost(200, 400, 200, 10);
            Assert.AreEqual(mediumPrice, parcelCost, "Medium Package Parcel Condition Test");
        }
        [TestMethod]
        public void TestOverWeightCondition()
        {
            var parseTheParcel = new ParseTheParcel();
            decimal parcelCost = parseTheParcel.CalculateParcelCost(200, 400, 200, 30.5);
            Assert.AreEqual(invalidPrice, parcelCost, "Over Weight Condition test Successful");
        }
        [TestMethod]
        public void TestInvalidDimention()
        {
            var parseTheParcel = new ParseTheParcel();
            decimal parcelCost = parseTheParcel.CalculateParcelCost(200, 400, 700, 10);
            Assert.AreEqual(invalidPrice, parcelCost, "Invalid Dimention test Successful");
        }
    }
}
