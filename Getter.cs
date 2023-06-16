using System;
namespace Hillel_Lesson20_HW
{
	public class Getter
	{

		public async void Send(string url)
		{
			using(HttpClient client = new HttpClient())
			{
				try
				{
					HttpResponseMessage response = await client.GetAsync(url);

					response.EnsureSuccessStatusCode();

					string responseBody = await response.Content.ReadAsStringAsync();
					Console.WriteLine(responseBody);
				}
				catch(HttpRequestException e)
				{
					Console.WriteLine($"Error during perfomance: {e.Message}");
				}

			}
		}
	}
}

