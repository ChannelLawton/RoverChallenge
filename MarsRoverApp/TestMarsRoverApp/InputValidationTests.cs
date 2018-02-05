using MarsRoverApp;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestMarsRoverApp
{
    [TestFixture]
    public class InputValidationTests
    {
        private static TestCaseData _testCaseData { get; set; }

        [SetUp]
        public void BeforeEachTest()
        {

        }

        [TearDown]
        public void AfterEachTest()
        {

        }

        [Test, Category("TestMarsRoverApp"), Category("InputValidationTests")]
        [TestCaseSource("ValidDirectionSucessfulDataSet")]
        public void ValidDirection_Input_Successfully(string direction)
        {
            Assert.AreEqual(true, InputValidations.ValidDirection(direction.ToUpper()));
        }

        [Test, Category("TestMarsRoverApp"), Category("InputValidationTests")]
        [TestCaseSource("ValidDirectionUnSuccessfulDataSet")]
        public void ValidDirection_Input_UnSuccessfully(string direction)
        {
            Assert.AreEqual(false, InputValidations.ValidDirection(direction.ToUpper()));
        }

        [Test, Category("TestMarsRoverApp"), Category("InputValidationTests")]
        [TestCaseSource("ValidDirectionCommandsDataSet")]
        public void ValidCommands_Input_Successfully(string commands)
        {
            Assert.AreEqual(true, InputValidations.ValidCommands(commands.ToUpper()));
        }

        [Test, Category("TestMarsRoverApp"), Category("InputValidationTests")]
        [TestCaseSource("ValidCommandsUnSuccessfulDataSet")]
        public void ValidCommands_Input_UnSuccessfully(string commands)
        {
            Assert.AreEqual(false, InputValidations.ValidCommands(commands.ToUpper()));
        }

        private static IEnumerable<TestCaseData> ValidDirectionSucessfulDataSet()
        {
            yield return ValidDirectionSucessfulData();
        }
        private static TestCaseData ValidDirectionSucessfulData()
        {
            _testCaseData = new TestCaseData(
                "N"
                );

            return _testCaseData;
        }
        private static IEnumerable<TestCaseData> ValidDirectionUnSuccessfulDataSet()
        {
            yield return ValidDirectionUnSuccessfulData();
        }
        private static TestCaseData ValidDirectionUnSuccessfulData()
        {
            _testCaseData = new TestCaseData(
                "X"
                );

            return _testCaseData;
        }
        private static IEnumerable<TestCaseData> ValidDirectionCommandsDataSet()
        {
            yield return ValidDirectionCommandsData();
        }
        private static TestCaseData ValidDirectionCommandsData()
        {
            _testCaseData = new TestCaseData(
                "MRL"
                );

            return _testCaseData;
        }
        private static IEnumerable<TestCaseData> ValidCommandsUnSuccessfulDataSet()
        {
            yield return ValidCommandsUnSuccessfulData();
        }
        private static TestCaseData ValidCommandsUnSuccessfulData()
        {
            _testCaseData = new TestCaseData(
                "XMRL"
                );

            return _testCaseData;
        }
    }
}
