using Microsoft.Extensions.DependencyInjection;
using SequenceGenerator.Service;

//DI setup
ServiceProvider serviceProvider = new ServiceCollection()
            .AddSingleton<ISequenceGeneratorService, SequenceGeneratorService>()
            .BuildServiceProvider();

Console.WriteLine("-Longest sequence generator-");

Console.WriteLine("Enter numbers separated by a single whitespace");

string? input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("No input provided. Exiting.");
    return;
}

ISequenceGeneratorService? service = serviceProvider.GetService<ISequenceGeneratorService>();
string? output = service?.ProcessInput(input);

Console.WriteLine(output);
