using DotnetQuizzes;
using System.Reflection;

Console.WriteLine("Enter The quiz number:");

if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int quizNumber))
{
    Console.WriteLine("Invalid quiz number");
    return;
}

var quiz = Assembly.GetExecutingAssembly().GetExportedTypes()
    .Where(x => x.IsClass && x.IsAssignableTo(typeof(IRunner)) && x.Name.Equals($"Quiz_{quizNumber}"))
    .FirstOrDefault();

if (quiz is null)
{
    Console.WriteLine("The quiz does not exist.");
    return;
}

Console.ForegroundColor = ConsoleColor.Green;

await ((IRunner)Activator.CreateInstance(quiz)!).RunAsync();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine($"Quiz {quizNumber} has been executed.");
