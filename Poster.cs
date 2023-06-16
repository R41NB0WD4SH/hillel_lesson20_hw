using System;
using System.Collections.Generic;
using System.Net.Http.Json;

namespace Hillel_Lesson20_HW
{
	public class Poster
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
                    var response = await client.PostAsync(url, jsonContent);

                }
                catch
                {
                    Console.WriteLine("Error");
                }

            }
        }
    }
}

