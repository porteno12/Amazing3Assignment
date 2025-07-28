using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingArray;

namespace StudentTasks
{
    [TestClass]
    public class ArrayUtilsTests
    {
        [TestMethod]
        public void IsAmazing3_CorrectSeries_ReturnsTrue()
        {
            int[] arr = { 3, 6, 9, 12 };
            bool result = ArrayUtils.IsAmazing3(arr);
            Assert.IsTrue(result, "ציפינו לקבל true עבור סדרה חשבונית בהפרש 3: 3, 6, 9, 12");
        }

        [TestMethod]
        public void IsAmazing3_IncorrectSeries_ReturnsFalse()
        {
            int[] arr = { 3, 6, 10, 13 };
            bool result = ArrayUtils.IsAmazing3(arr);
            Assert.IsFalse(result, "ציפינו לקבל false – המערך אינו סדרה חשבונית בהפרש 3");
        }

        [TestMethod]
        public void IsAmazing3_EmptyArray_ReturnsTrue()
        {
            int[] arr = { };
            bool result = ArrayUtils.IsAmazing3(arr);
            Assert.IsTrue(result, "מערך ריק אמור להיחשב כ'סדרה מדהימה 3'");
        }

        [TestMethod]
        public void IsAmazing3_SingleElement_ReturnsTrue()
        {
            int[] arr = { 4 };
            bool result = ArrayUtils.IsAmazing3(arr);
            Assert.IsTrue(result, "מערך עם איבר אחד אמור להיחשב כסדרה תקינה");
        }

        [TestMethod]
        public void IsAmazing3_NullArray_ReturnsTrue()
        {
            int[] arr = null;
            bool result = ArrayUtils.IsAmazing3(arr);
            Assert.IsTrue(result, "null אמור להיחשב כ'סדרה מדהימה 3'");
        }

        [TestMethod]
        public void IsAmazing3_SeriesBreaksLater_ReturnsFalse()
        {
            int[] arr = { 1, 4, 7, 11, 14 };
            bool result = ArrayUtils.IsAmazing3(arr);
            Assert.IsFalse(result, "המערך מתחיל נכון אך נשבר – אסור להיחשב כסדרה מדהימה 3");
        }
    }
}
