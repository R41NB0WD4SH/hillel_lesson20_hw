using System;
using System.Net.Http.Json;

namespace Hillel_Lesson20_HW
{
    public class Putter
    {
        public async void Send(string url)
        {

            using (HttpClient client = new HttpClient())
            {
                Post post = new Post()
                {
                    title = "Title",
                    body = "Body",
                    userId = 4
                };

                JsonContent jsonContent = JsonContent.Create(post);

                try
                {
                    var response = await client.PutAsync(url, jsonContent);

                }
                catch
                {
                    Console.WriteLine("Error");
                }

            }
        }
    }
}

