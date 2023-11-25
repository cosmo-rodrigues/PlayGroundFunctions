using System;
public class ChallangeSolcutions
{
  // Challnge 01
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

class Program
{
  static void Main()
  {
    bool resultado01 = ChallangeSolcutions.CompareTrue(true, true);
    bool resultado02 = ChallangeSolcutions.CompareTrue(false, true);

    Console.WriteLine(resultado01);
    Console.WriteLine(resultado02);
  }
}
