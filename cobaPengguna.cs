using cobaPutarVideo;
using System.Diagnostics.Contracts;

namespace cobaPengguna
{
    public class SayaTubeUser
    {
        private readonly int id;
        private string username;
        private readonly List<SayaTubeVideo> uploadedVideo;
        public SayaTubeUser(string username)
        {
            Contract.Requires(!string.IsNullOrEmpty(username), "Username must not be empty."); // Ensure username is not empty
            Contract.Requires(username.Length <= 100, "Username must be less than or equal to 100 characters."); // Ensure username length is valid

            Random rnd = new Random(); // Membuat objek random baru untuk menghasilkan angka acak
            id = rnd.Next(00000, 99999); // Buat nomor acak antara 00000 dan 99999 secara otomatis (inlkusif), 'this' disingkirkan karena attributenya read-only
            this.username = username;
            uploadedVideo = new List<SayaTubeVideo>(); // Inisialisasi list uploadedVideo, 'this' disingkirkan karena attributenya read-only
        }
        public int GetTotalVideoPlayCount()
        {
            return uploadedVideo.Count;
        }

        public void UploadVideo(SayaTubeVideo video)
        {
            Contract.Requires(video != null, "Video must not be null."); // Ensure video is not null
            Contract.Requires(video.GetPlayCount() != 0, "Video title must not be null."); // Ensure video title is not null
            Contract.Requires(video.GetPlayCount() <= 200, "Video title must be less than or equal to 200 characters."); // Ensure video title length is valid
            uploadedVideo.Add(video); // Tambahkan video ke list uploadedVideo, 'this' disingkirkan karena attributenya read-only
        }

        public void PrintAllVideoPlayCount() 
        {
            Contract.Ensures(GetTotalVideoPlayCount() <= 8); // Ensure that the number of videos printed does not exceed 8
            Console.WriteLine($"User: {this.username}");
            for (int i = 0; i < GetTotalVideoPlayCount(); i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideo[i].GetPlayCount()}"); // Cetak play count tiap video, 'this' disingkirkan karena attributenya read-only
            }
        }
    }
}