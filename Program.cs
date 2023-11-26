using PlayGroundFunctions.Solutions;

string tudoDeErrado = "Tá louco, te falo em time perfeito";

string[] arrayDePalavras = ChallengeSolutions.SplitSentence(tudoDeErrado);

Console.WriteLine("Resultado:");
foreach (string palavra in arrayDePalavras)
{
  Console.WriteLine(palavra);
}
