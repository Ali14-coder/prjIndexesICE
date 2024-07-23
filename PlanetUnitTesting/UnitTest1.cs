using prjIndexesICE;
using System;
namespace PlanetUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        Planet planet = new Planet("Venus","Terrestrial",3.285,"Yellow-brown",false);
        [TestMethod]
        public void correctPlanetName()
        {
            string expectedPlanetName = "Venus";
            string actualPlanetName = (string)planet[0];
            Assert.AreEqual(expectedPlanetName, actualPlanetName); 
        }

        [TestMethod]
        public void correctPlanetType()
        {
            string expectedPlanetType = "Terrestrial";
            string actualPlanetType = (string)planet[1];
            Assert.AreEqual(expectedPlanetType, actualPlanetType);
        }

        [TestMethod]
        public void correctPlanetMass()
        {
            double actualPlanetMass = 3.285;
            double expectedPlanetMass = (double)planet["planetmass"];
            Assert.AreEqual(actualPlanetMass, expectedPlanetMass);
        }

        [TestMethod]
        public void correctPlanetColour() 
        {
            string expectedPlanetColour = "Yellow-brown";
            string actualPlanetColour = (string)planet["planetcolour"];
            Assert.AreEqual(expectedPlanetColour, actualPlanetColour);
        }

        [TestMethod]
        public void correctPlanetRings() 
        {
            bool expectedPlanetRings = false;
            bool actualPlanetRings = (bool)planet[4];
            Assert.AreEqual(expectedPlanetRings, actualPlanetRings);
        }
    }
}