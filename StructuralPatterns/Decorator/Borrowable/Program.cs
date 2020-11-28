namespace DecoratorPattern
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            //Create book
            var book = new Book("Microsoft", "Asp.Net Core", 10);
            book.Display();

            //Create video
            var video = new Video(".Net conference", "Blazor", 120, 22);
            video.Display();

            Console.WriteLine("\nMaking video borrowable.");

            var borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("Atanas Vasilev");
            borrowableVideo.BorrowItem("Pesho Georgiev");

            borrowableVideo.Display();

            borrowableVideo.ReturnItem("Atanas Vasilev");

            Console.WriteLine("\nAtanas Vasilev returned the video.");
            borrowableVideo.Display();
        }
    }
}
