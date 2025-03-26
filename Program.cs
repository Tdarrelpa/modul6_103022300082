// See https://aka.ms/new-console-template for more information
using cobaPengguna;
using cobaPutarVideo;

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video1 = new("Review Film Conclave oleh Timotius Darrel");
        video1.IncreasePlayCount(100);
        video1.PrintVideoDetails();

        SayaTubeVideo video2 = new("Review Film Ne Zha 1 oleh Timotius Darrel");
        video2.IncreasePlayCount(100);
        video2.PrintVideoDetails();

        SayaTubeVideo video3 = new("Review Film Ne Zha 2 oleh Timotius Darrel");
        video3.IncreasePlayCount(100);
        video3.PrintVideoDetails();

        SayaTubeVideo video4 = new("Review Film The Last Supper oleh Timotius Darrel");
        video4.IncreasePlayCount(100);
        video4.PrintVideoDetails();

        SayaTubeVideo video5 = new("Review Film Project Sekai: Miku Can't Sing oleh Timotius Darrel");
        video5.IncreasePlayCount(100);
        video5.PrintVideoDetails();

        SayaTubeVideo video6 = new("Review Film The Boy and The Heron oleh Timotius Darrel");
        video6.IncreasePlayCount(100);
        video6.PrintVideoDetails();

        SayaTubeVideo video7 = new("Review Film Agak Laen oleh Timotius Darrel");
        video7.IncreasePlayCount(100);
        video7.PrintVideoDetails();

        SayaTubeVideo video8 = new("Review Film Make A Girlfriend oleh Timotius Darrel");
        video8.IncreasePlayCount(100);
        video8.PrintVideoDetails();

        SayaTubeVideo video9 = new("Review Film Grave of Fireflies oleh Timotius Darrel");
        video9.IncreasePlayCount(100);
        video9.PrintVideoDetails();

        SayaTubeVideo video10 = new("Review Film Habibie dan Ainun oleh Timotius Darrel");
        video10.IncreasePlayCount(100);
        video10.PrintVideoDetails();

        SayaTubeUser user1 = new("Timotius Darrel");
        user1.UploadVideo(video1);
        user1.UploadVideo(video2);
        user1.UploadVideo(video3);
        user1.UploadVideo(video4);
        user1.UploadVideo(video5);
        user1.UploadVideo(video6);
        user1.UploadVideo(video7);
        user1.UploadVideo(video8);
        user1.UploadVideo(video9);
        user1.UploadVideo(video10);
        user1.PrintAllVideoPlayCount();
    }
}