using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlFlow;

namespace ControlFrowTest
{
    [TestClass]
    public class AreYouValidTest
    {
        [TestMethod]
        public void ShouldBeValid()
        {
            string actual = ControlFlow.ControlFlow.AreYouValid(5);

            const string expected = "Valid";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldBeInvalid()
        {
            string actual = ControlFlow.ControlFlow.AreYouValid(11);

            const string expected = "Invalid";

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class MaximumTest
    {
        [TestMethod]
        public void FirstNumberShouldBeMax()
        {
            var actual = ControlFlow.ControlFlow.Maximum(10, 5);

            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondNumberShouldBeMax()
        {
            var actual = ControlFlow.ControlFlow.Maximum(11, 99);

            var expected = 99;

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class LandscapeOrPortraitTest
    {
        [TestMethod]
        public void ShouldBeLandscape()
        {
            var actual = ControlFlow.ControlFlow.LandscapeOrPortrait(10, 5);

            var expected = "Landscape";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldBePortrait()
        {
            var actual = ControlFlow.ControlFlow.LandscapeOrPortrait(55, 1000);

            var expected = "Portrait";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldBeSquare()
        {
            var actual = ControlFlow.ControlFlow.LandscapeOrPortrait(55, 55);

            var expected = "Square";

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class SpeedTrapTest
    {
        [TestMethod]
        public void ShouldBeOkay()
        {
            var actual = ControlFlow.ControlFlow.SpeedTrap(10, 5);

            var expected = "Okay";

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Did they check whether or not driving at the speed limit was okay?
        /// </summary>
        [TestMethod]
        public void DrivingAtLimitOkay()
        {
            var actual = ControlFlow.ControlFlow.SpeedTrap(10, 10);

            var expected = "Okay";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DrivingFast2Points()
        {
            var actual = ControlFlow.ControlFlow.SpeedTrap(15, 25);

            var expected = "2";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WayTooFastAmigo()
        {
            var actual = ControlFlow.ControlFlow.SpeedTrap(15, 120);

            var expected = "License Suspended";

            Assert.AreEqual(expected, actual);
        }
    }
}
