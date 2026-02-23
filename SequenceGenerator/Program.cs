// See https://aka.ms/new-console-template for more information
Console.WriteLine("-Longest sequence generator-");

Console.WriteLine("Enter numbers separated by a space");

var input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("No input provided. Exiting.");
    return;
}

var output = new SequenceGeneratorService.SequenceGeneratorService().ProcessInput(input);

Console.WriteLine(output);