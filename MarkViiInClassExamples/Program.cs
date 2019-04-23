using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string joke = GetJoke();
            Console.WriteLine(joke);
        }

        static string GetJoke()
        {
            WebClient webClient = new WebClient();
            string webResponse = webClient.DownloadString("https://api.chucknorris.io/jokes/random");
            return JObject.Parse(webResponse).GetValue("value").ToString();
        }

        static string GetJoke_ManualJsonParse()
        {
            WebClient webClient = new WebClient();
            string webResponse = webClient.DownloadString("https://api.chucknorris.io/jokes/random");
            int jokeKeyLocation = webResponse.IndexOf("value");
            int jokeTextLocation = jokeKeyLocation + 5 + 3; // 5 for "value", 3 for quotes and colon
            string joke = webResponse.Substring(jokeTextLocation, webResponse.Length - 2 - jokeTextLocation);
            return joke;
        }
    }
}
