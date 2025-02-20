namespace MiniHW1;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<VetClinic>()
            .AddSingleton<Zoo>()
            .AddSingleton<WriteToConsole>()
            .BuildServiceProvider();
        var printer = serviceProvider.GetService<WriteToConsole>();
        printer?.Run();
    }
}