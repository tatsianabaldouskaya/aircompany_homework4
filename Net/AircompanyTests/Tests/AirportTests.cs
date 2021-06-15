using Aircompany;
using Aircompany.Models;
using Aircompany.Planes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AircompanyTests.Tests
{
    [TestFixture]
    public class AirportTests:AirportBaseTests
    {
       
        [Test]
        public void TestHasMilitaryTransportPlane()
        {
            Assert.IsTrue(HasMilitaryTransportPlanes());
        }

        [Test]
        public void TestIsExpectedPlaneWithMaxPassengersCapacityEqualsActual()
        {
            Airport airport = new Airport(planes);
            Assert.AreEqual(_passengerPlaneWithMaxPassengerCapacity, airport.GetPassengerPlaneWithMaxPassengersCapacity());   
        }

        [Test]
        public void TestNextPlaneMaxLoadCapacityIsHigherThanCurrent()
        {
           Assert.IsTrue(NextPlaneMaxLoadCapacityIsHigherThanCurrent());
        }
    }
}
