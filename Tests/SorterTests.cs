using NUnit.Framework;
using package_dispatch_service.Enumerations;
using package_dispatch_service.src;

namespace package_dispatch_service.Tests
{
    public class SorterTests
    {
        [Test]
        public void GivenStandardPackage_WhenSorted_ThenReturnsStandard()
        {
            var result = Sorter.Sort(10, 10, 10, 5);
            Assert.Equals(DispatchType.STANDARD.ToString(), result);
        }

        [Test]
        public void GivenBulkyPackage_WhenSorted_ThenReturnsSpecial()
        {
            var result = Sorter.Sort(200, 10, 10, 5);
            Assert.Equals(DispatchType.SPECIAL.ToString(), result);
        }

        [Test]
        public void GivenHeavyPackage_WhenSorted_ThenReturnsSpecial()
        {
            var result = Sorter.Sort(10, 10, 10, 25);
            Assert.Equals(DispatchType.SPECIAL.ToString(), result);
        }

        [Test]
        public void GivenBulkyAndHeavyPackage_WhenSorted_ThenReturnsRejected()
        {
            var result = Sorter.Sort(200, 200, 200, 25);
            Assert.Equals(DispatchType.REJECTED.ToString(), result);
        }
    }
}