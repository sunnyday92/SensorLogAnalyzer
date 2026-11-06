Console.WriteLine("Sensor Log Analyzer v0,1");
var lines = File.ReadAllLines("data/sample.csv");
Console.WriteLine($"Прочитаено строк: {lines.Length}");

foreach (var line in lines)
{
    Console.WriteLine(line);
}