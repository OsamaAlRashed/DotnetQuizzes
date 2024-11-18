namespace DotnetQuizzes.Quizzes;

public class Quiz_1 : IRunner
{
    public Task RunAsync()
    {
        List<int> numbers = Enumerable.Range(1, 3).ToList();
        IEnumerable<int> query = numbers.Where(x => x % 2 == 0);
        numbers.Add(4);

        foreach (var number in query)
        {
            Console.Write(number);
        }

        return Task.CompletedTask;
    }
}
