using Microsoft.Extensions.DependencyInjection;
using SequenceGenerator;

//DI setup
var serviceProvider = new ServiceCollection()
            .AddSingleton<ISequenceGeneratorService, SequenceGeneratorService>()
            .BuildServiceProvider();

Console.WriteLine("-Longest sequence generator-");

Console.WriteLine("Enter numbers separated by a single whitespace");

var input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("No input provided. Exiting.");
    return;
}

var service = serviceProvider.GetService<ISequenceGeneratorService>();
var output = service?.ProcessInput(input);

Console.WriteLine(output);