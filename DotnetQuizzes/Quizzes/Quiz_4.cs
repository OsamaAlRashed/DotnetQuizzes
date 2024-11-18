namespace DotnetQuizzes.Quizzes;

public class Quiz_4 : IRunner
{
    public Task RunAsync()
    {
        IEnumerable<int> numbers = Enumerable.Range(1, 5)
            .Select(i => {
                Console.Write(i);
                return i;
            });

        Console.WriteLine(numbers.Last());

        return Task.CompletedTask;
    }
}
