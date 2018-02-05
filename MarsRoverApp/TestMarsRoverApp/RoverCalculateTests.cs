using MarsRoverApp;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestMarsRoverApp
{
    [TestFixture]
    public class RoverCalculateTests
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



        [Test, Category("TestMarsRoverApp"), Category("RoverCalculateTests")]
        [TestCaseSource("ValidRoverCalculationSucessfulDataSet")]
        public void ValidRoverCalculation_Input_Successfully(Rover rover)
        {
            Assert.AreEqual("3 3 S", rover.Calculate());
        }

        [Test, Category("TestMarsRoverApp"), Category("RoverCalculateTests")]
        [TestCaseSource("ValidRoverCalculationUnSucessfulDataSet")]
        public void ValidRoverCalculation_Input_UnSuccessfully(Rover rover)
        {
            Assert.AreEqual("Result postion not valid.", rover.Calculate());
        }

        private static IEnumerable<TestCaseData> ValidRoverCalculationSucessfulDataSet()
        {
            yield return ValidRoverCalculationSucessfulData();
        }
        private static TestCaseData ValidRoverCalculationSucessfulData()
        {
            _testCaseData = new TestCaseData(
                       new Rover()
                      {
                          ZoneSizeX = 5,
                          ZoneSizeY = 5,
                          PositionX = 1,
                          PositionY = 2,
                          RoverPosition = CompassValue.E,
                          Commands = "MMLMRMMRRMML"
                       }
                );

            return _testCaseData;
        }

        private static IEnumerable<TestCaseData> ValidRoverCalculationUnSucessfulDataSet()
        {
            yield return ValidRoverCalculationUnSucessfulData();
        }
        private static TestCaseData ValidRoverCalculationUnSucessfulData()
        {
            _testCaseData = new TestCaseData(
                    new Rover()
                    {
                        ZoneSizeX = 2,
                        ZoneSizeY = 2,
                        PositionX = 1,
                        PositionY = 2,
                        RoverPosition = CompassValue.E,
                        Commands = "MMLMRMMRRMML"
                    }
                );

            return _testCaseData;
        }
    }
}
