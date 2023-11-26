
namespace PlayGroundFunctions.Solutions
{
  public class ChallengeSolutions
  {
    // Challenge 01
    public static bool CompareTrue(bool ligado, bool quente)
    {
      bool podeBanhar;

      if (ligado && quente)
      {
        podeBanhar = true;
      }
      else
      {
        podeBanhar = false;
      }

      return podeBanhar;
    }

    // Challenge 02
    public static double CalcArea(double itemBase, double itemHeight)
    {
      return itemBase * itemHeight / 2;
    }

    // Challenge 03
    public static string[] SplitSentence(string sentence)
    {
      return sentence.Split(" ");
    }
  }
}
