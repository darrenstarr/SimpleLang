
Console.WriteLine("Hello, World!");
var sample = File.ReadAllText("sample.txt");
var ast = LanguageGrammer.Grammar.Parser.Parse(sample);

Console.ReadKey();

