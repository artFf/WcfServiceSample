using System.Linq;
using ConvertingTextLibrary.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestConvertingText
{
    [TestClass]
    public class UnitTestRepository
    {
        [TestMethod]
        public void Test_repository_method_GetUpperText()
        {
            //arange
            var convertingTextRepository = new ConvertingTextRepository();
            string testText = "TeSt";            

            //act
            var result = convertingTextRepository.GetUpperText(testText);
            
            //assert
            Assert.IsTrue(result.All(char.IsUpper));
        }

        [TestMethod]
        public void Test_repository_method_GetLowerText()
        {
            //arange
            var convertingTextRepository = new ConvertingTextRepository();
            string testText = "TeSt";
            //string 

            //act
            var result = convertingTextRepository.GetLowerText(testText);

            //assert
            Assert.IsTrue(result.All(char.IsLower));
        }

        [TestMethod]
        public void Test_repository_method_GetReversText()
        {
            //arange
            var convertingTextRepository = new ConvertingTextRepository();
            string testText = "TeSt";
            string testReverseTest = "tSeT";

            //act
            var result = convertingTextRepository.GetReversText(testText);

            //assert
            Assert.AreEqual(testReverseTest,result);
        }

        [TestMethod]
        public void Test_repository_methpd_GetSplitTest()
        {
            //arange
            var convertingTextRepository = new ConvertingTextRepository();
            string testText = "TeSt tSeT";
            string[] testSplitTest = testText.Split(' ');

            //act
            var result = convertingTextRepository.GetSplitTest(testText);
            bool compareResult = result.SequenceEqual(testSplitTest);

            //assert
            Assert.IsTrue(compareResult);
        }
    }
}
