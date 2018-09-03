using System;
using Disbot;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DisBotTest
    {
        [TestMethod]
        public void PickACurse()
        {
            var bot = new CoreBot();
            bot.Add("Because you mum is gay");

            var ourLine = "Why are you doing this to me?";
            var actualResponse = bot.PickResponse(ourLine);

            var expectedResponse = bot.PossibleCurses[0];
            Assert.AreEqual(expectedResponse, actualResponse);
        }

        [TestMethod]
        public void SkipACurse()
        {
            var bot = new CoreBot();
            bot.Add("Because you mum is gay");

            var ourLine = "Are you doing this to me?";
            var actualResponse = bot.PickResponse(ourLine);

            var expectedResponse = "";
            Assert.AreEqual(expectedResponse, actualResponse);
        }


    }
}
