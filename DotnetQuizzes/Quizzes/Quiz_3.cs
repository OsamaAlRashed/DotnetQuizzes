namespace DotnetQuizzes.Quizzes;

public class Quiz_3 : IRunner
{
    public Task RunAsync()
    {
        IEnumerable<int> numbers = Enumerable.Range(1, 5)
            .Select(i => {
                Console.Write(i);
                return i;
            }).OrderBy(i => i);

        foreach (int i in numbers)
        {
            Console.Write(i);
        }

        return Task.CompletedTask;
    }
}
