using System;
using System.Net.Http.Json;

namespace Hillel_Lesson20_HW
{
	public class Deleter
	{
        public async void Send(string url)
        {

            using (HttpClient client = new HttpClient())
            {

                try
                {
                    var response = await client.DeleteAsync(url);

                }
                catch
                {
                    Console.WriteLine("Error");
                }

            }
        }
    }
}

