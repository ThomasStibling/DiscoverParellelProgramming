namespace FetchApi;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        var fetchApi1 = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");
        Console.WriteLine(fetchApi1);
        var fetchApi2 = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/2");
        Console.WriteLine(fetchApi2);
        string apiStringExist = "https://official-joke-api.appspot.com/random_joke";
        string resultTrue = await FetchDataAsync(apiStringExist);
        Console.WriteLine(resultTrue);
        string apiStringNotExist = "https://azertyfdsxvhh.out";
        string resultWrong = await FetchDataAsync(apiStringNotExist);
        Console.WriteLine(resultWrong);
    }
    
    static async Task<string> FetchDataAsync(string api)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            HttpResponseMessage response = await httpClient.GetAsync(api);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}