namespace DotnetQuizzes.Quizzes;

public class Quiz_2 : IRunner
{
    public Task RunAsync()
    {
        IEnumerable<int> numbers = Enumerable.Range(1, 5)
            .Select(i => {
                Console.Write(i);
                return i;
            });

        foreach (int i in numbers) 
        { 
            Console.Write(i);
        }

        return Task.CompletedTask;
    }
}
