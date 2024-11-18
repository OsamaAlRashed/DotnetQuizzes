namespace DotnetQuizzes.Quizzes;

public class Quiz_5 : IRunner
{
    public Task RunAsync()
    {
        IEnumerable<int> numbers = GetNumbers()
           .Select(i => 
           {
               Console.Write(i);
               return i;
           });

        Console.WriteLine(numbers.Last());

        return Task.CompletedTask;
    }

    private static IEnumerable<int> GetNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
    }
}
