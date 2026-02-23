// See https://aka.ms/new-console-template for more information
Console.WriteLine("-Longest sequence generator-");

Console.WriteLine("Enter numbers separated by a space");

var input = Console.ReadLine();
string[] inputStrings = Array.Empty<string>();
int[] inputNumbers = Array.Empty<int>();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("No input provided. Exiting.");
    return;
}

inputStrings = input.Split(' ', StringSplitOptions.TrimEntries);

try
{
    inputNumbers = Array.ConvertAll(inputStrings, int.Parse);
}
catch (FormatException)
{
    Console.WriteLine("Invalid numbers entered. Exiting.");
    return;
}

var sequenceGeneratorService = new SequenceGeneratorService.SequenceGeneratorService();
var longestSequence = sequenceGeneratorService.GenerateLongestSequence(inputNumbers);

Console.WriteLine(string.Join(" ", longestSequence));
