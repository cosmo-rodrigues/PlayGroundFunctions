
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
      double area = itemBase * itemHeight / 2;
      return area;
    }
  }
}
