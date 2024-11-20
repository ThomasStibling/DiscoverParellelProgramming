namespace DoWork;

class Program
{
    static async Task Main(string[] args)
    {
        Task<int> task1 = Task.Run(() => DoWork("Task 1", 3000));
        Task<int> task2 = Task.Run(() => DoWork("Task 2", 2000));
        Task<int> task3 = Task.Run(() => DoWork("Task 3", 4000));
        
        int[] results = await Task.WhenAll(task1, task2, task3);
        int totalDelay = 0;
        foreach (int result in results)
        {
            totalDelay += result;
        }
        
        Console.WriteLine("Total delay: " + totalDelay);
        
        totalDelay += 500;
        Console.WriteLine("Total delay + 500: " + totalDelay);
    }
    
    static int DoWork(string taskName, int delayMilliseconds)
    {
        Console.WriteLine("{0} starting...", taskName);
        Task.Delay(delayMilliseconds).Wait();
        Console.WriteLine("{0} completed.", taskName);
        return delayMilliseconds;
    }
}