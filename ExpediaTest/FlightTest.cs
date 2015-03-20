using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{




      
        [Test()]
        public
        void
        TestThatFlightInitializes
        ()
        {
            var
            target =
            new
            Flight(new DateTime(2015, 4, 18), new DateTime(2015, 4, 29), 700);
            Assert.IsNotNull(target);
        }

       

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public
        void
        TestThatFlightThrowsOnBadDates
        
        ()
        {
            new
            Flight
            ( new DateTime(2015, 4, 29), new DateTime(2015, 4, 18), 700);
        }


        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public
        void
        TestThatFlightThrowsOnBadMiles
        ()
        {
            new
            Flight
            (new DateTime(2015, 4, 18), new DateTime(2015, 4, 29), -5);
        }



        [Test()]
        public
        void
        TestThatFlightHasCorrectBasePriceForSameDayFlight
        ()
        {
            var
            target =
            new
            Flight(new DateTime(2015, 4, 18), new DateTime(2015, 4, 18), 700);
            Assert.AreEqual(
            200
            , target.getBasePrice());
        }


        [Test()]
        public
        void
        TestThatFlightHasCorrectBasePriceForOneDayFlightGap
        ()
        {
            var
            target =
            new
            Flight(new DateTime(2015, 4, 18), new DateTime(2015, 4, 19), 700);
            Assert.AreEqual(
            220
            , target.getBasePrice());
        }



        [Test()]
        public
        void
        TestThatFlightHasCorrectBasePriceForTwoDayFlightGap
        ()
        {
            var
            target =
            new
            Flight(new DateTime(2015, 4, 18), new DateTime(2015, 4, 20), 700);
            Assert.AreEqual(
            240
            , target.getBasePrice());
        }


        [Test()]
        public
        void
        TestThatFlightHasCorrectBasePriceForLongFlightGap
        ()
        {
            var
            target =
            new
            Flight(new DateTime(2015, 4, 18), new DateTime(2018, 9, 30), 700);
            Assert.AreEqual(
            25420
            , target.getBasePrice());
        }








	}
}
