
namespace Hillel_Lesson20_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            string url = "https://google.com";


            Getter sender = new Getter();

            sender.Send(url);


            Poster poster = new Poster();

            poster.Send(url);


            Putter putter = new Putter();

            putter.Send(url);


            Deleter deleter = new Deleter();

            deleter.Send(url);

            Console.ReadLine();


        }
    }
}