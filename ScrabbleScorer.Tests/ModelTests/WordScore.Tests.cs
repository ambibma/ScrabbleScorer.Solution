using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scoring.Models;
using System;

namespace Scoring.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void ToPoints_ReturnsPoints_Int()
    {
      //arrange
      string word = "A";
      //act
      int result = WordScore.ToPoints(word);
      //assert
      Assert.AreEqual(1, result);
    }
  }
}