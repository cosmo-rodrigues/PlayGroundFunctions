
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
  }
}
