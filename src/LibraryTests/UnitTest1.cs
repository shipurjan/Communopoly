using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Library;

namespace LibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CzyPolaNaKrawedziachPlanszyMajaPoprawnyTyp()
        {
            //arrange
            int expected_position_start = 0;
            int expected_position_reeducation = 10;
            int expected_position_katorga = 20;
            int expected_position_redistribution = 30;
            var gra = new Board();

            foreach (Space space in gra.Spaces) {
                if (space.Name == "Start")
                    Assert.AreEqual(expected_position_start, space.Position);
                if (space.Name == "Reeducation") 
                    Assert.AreEqual(expected_position_reeducation, space.Position);
                if (space.Name == "Katorga")
                    Assert.AreEqual(expected_position_katorga, space.Position);
                if (space.Name == "Redistribution")
                    Assert.AreEqual(expected_position_redistribution, space.Position);
            }

        }

    }
}
