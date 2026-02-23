// See https://aka.ms/new-console-template for more information
Console.WriteLine("-Longest sequence generator-");

Console.WriteLine("Enter numbers separated by a single whitespace");

var input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("No input provided. Exiting.");
    return;
}

var service = new SequenceGeneratorService.SequenceGeneratorService();
var output = service.ProcessInput(input);

Console.WriteLine(output);