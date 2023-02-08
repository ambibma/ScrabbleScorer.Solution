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
    public void ToPoints_ReturnsPointsFromOneLetter_Int()
    {
      //arrange
      string word = "A";
      //act
      int result = WordScore.ToPoints(word);
      //assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void ToPoints_ReturnsPointsFromTwoLetters_Int()
    {
      //arrange
      string word = "AT";
      //act
      int result = WordScore.ToPoints(word);
      //assert
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void ToPoints_ReceivesLowerCase_Int()
    {
      string word = "a";
      int result = WordScore.ToPoints(word);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void ToPoints_ThrowsErrorForNotABC_Int()
    {
      string word = "!";
      int result = WordScore.ToPoints(word);
      Assert.AreEqual(0, result);
    }
  }
}