using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatoriskOpgave1_Football;
using System;

namespace FootBallTests
{
    [TestClass]
    public class Footballtest
    {
        private FootballPlayer player;

        [TestInitialize]
        public void setupPlayer()
        {
            player = new FootballPlayer();
        }
            [TestMethod]
        public void IDtest()
        {
            player.ID = 1;
            Assert.AreEqual(1, player.ID);
            player.ID = 2000;
            Assert.AreEqual(2000, player.ID);
            player.ID = -500;
            Assert.AreEqual(-500, player.ID);
        }

        [TestMethod]
        public void Nametest()
        {
            player.Name = "bobby";
            Assert.AreEqual("bobby", player.Name);
            player.Name = "Emil";
            Assert.AreEqual("Emil", player.Name);
            try
            {
                player.Name = "ib";
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {

            }
            try
            {
                player.Name = "     ";
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {

            }
        }

        [TestMethod]
        public void Pricetest()
        {
            player.Price = 100;
            Assert.AreEqual(100, player.Price);
            player.Price = 1;
            Assert.AreEqual(1, player.Price);
            try
            {
                player.Price = 0;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {

            }

            try
            {
                player.Price = -12;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {

            }
        }

        [TestMethod]
        public void Shirttest()
        {
            player.ShirtNumber = 52;
            Assert.AreEqual(52, player.ShirtNumber);
            player.ShirtNumber = 1;
            Assert.AreEqual(1, player.ShirtNumber);
            player.ShirtNumber = 100;
            Assert.AreEqual(100, player.ShirtNumber);
            try
            {
                player.ShirtNumber = 0;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {
    
            }

            try
            {
                player.ShirtNumber = 101;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {

            }
        }
    }
}
