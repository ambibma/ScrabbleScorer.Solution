using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;


namespace Scoring.Models
{
  public class WordScore
  {
    private static Dictionary<char, int> _letterScores  = new Dictionary<char,int>() {
      {'A', 1},
      {'E', 1},
      {'I', 1},
      {'O', 1},
      {'U', 1},
      {'L', 1},
      {'N', 1},
      {'R', 1},
      {'S', 1},
      {'T', 1},
      {'D', 2},
      {'G', 2},
      {'B', 3},
      {'C', 3},
      {'M', 3},
      {'P', 3},
      {'F', 4},
      {'H', 4},
      {'V', 4},
      {'W', 4},
      {'Y', 4},
      {'K', 5},
      {'J', 8},
      {'X', 8},
      {'Q', 10},
      {'Z', 10},
    };
    private static HashSet<string> HellSpawnDaemonWords = new HashSet<string>(File.ReadAllLines(@"Assets/CollinsScrabbleWords(2019).txt"));
    public static int ToPoints(string word)
    {
      string upperCaseWord = word.ToUpper();
      char[] chars = upperCaseWord.ToCharArray();
      try
      {
        return chars.Select(c => _letterScores[c]).Sum();
      }
      catch (KeyNotFoundException)
      {
        return 0;
      }
    }
    public static Boolean IsValidWord(string word)
    {
      return HellSpawnDaemonWords.Contains(word);
    }
    public static int ValidateAndScore(string word)
    {
      string upperCaseWord = word.ToUpper();
      if (IsValidWord(upperCaseWord))
      {
        return ToPoints(upperCaseWord);
      }
      return 0;
    }
  }
}