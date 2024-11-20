namespace ConsoleApp1;

class Program
{
    static async Task Main(string[] args)
    {
        int randomNumber = await FakeAsyncTasks.GetRandomNumberAsync();
        Console.WriteLine(randomNumber);
        string testMessageToUpper = await FakeAsyncTasks.GetSpecialStringAsync("message de test");
        Console.WriteLine(testMessageToUpper);
        await FakeAsyncTasks.SendEmailAsync();
    }
}