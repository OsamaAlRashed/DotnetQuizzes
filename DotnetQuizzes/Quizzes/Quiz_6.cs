using DotnetQuizzes.Models;

namespace DotnetQuizzes.Quizzes;

public class Quiz_6 : IRunner
{
    public Task RunAsync()
    {
        List<Number> numbers = Enumerable.Range(1, 5)
            .Select(i => new Number(i))
            .ToList();

        foreach (var number in numbers)
        {
            if (number.Id % 2 == 0)
            {
                numbers.Add(new Number(number.Id * 100));
            }

            Console.Write(number.Id);
        }

        return Task.CompletedTask;
    }
}
