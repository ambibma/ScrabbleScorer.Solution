using System;
using System.Collections.Generic;
using Scoring.Models;

namespace Scoring
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("Welcome, I am a Scrabble Word Scoring Program. (But I won't help you cheat ;) ... unless...😏).");
      while(true)
      {
        Console.WriteLine("Please enter a word, a real, true word. And I will give you a score for that word. Don't try to fool me, now, it only hurts us both.");
        string checkWord = Console.ReadLine();
        Console.WriteLine(WordScore.ValidateAndScore(checkWord));
      }
    }
  }
}