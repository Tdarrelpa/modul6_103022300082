using cobaPutarVideo;

namespace cobaPengguna
{
    public class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideo;
        public SayaTubeUser(string username)
        {
            Random rnd = new Random(); // Membuat objek random baru untuk menghasilkan angka acak
            this.id = rnd.Next(00000, 99999); // Buat nomor acak antara 00000 dan 99999 secara otomatis (inlkusif)
            this.username = username;
            this.uploadedVideo = new List<SayaTubeVideo>();
            //Contract.Requires(!string.IsNullOrEmpty(username), "Username must not be empty."); // Pastikan username tidak kosong
            //Contract.Requires(username.Length <= 20, "Username must be less than or equal to 20 characters."); // Pastikan username tidak lebih dari 20 karakter
            //Contract.Requires(!string.IsNullOrEmpty(email), "Email must not be empty."); // Pastikan email tidak kosong
            //Contract.Requires(email.Length <= 50, "Email must be less than or equal to 50 characters."); // Pastikan email tidak lebih dari 50 karakter
            //Contract.Requires(!string.IsNullOrEmpty(password), "Password must not be empty."); // Pastikan password tidak kosong
            //Contract.Requires(password.Length <= 20, "Password must be less than or equal to 20 characters."); // Pastikan password tidak lebih dari 20 karakter
        }
        public int GetTotalVideoPlayCount()
        {
            return this.uploadedVideo.Count;
        }

        public void UploadVideo(SayaTubeVideo video)
        {
            this.uploadedVideo.Add(video);
        }

        public void PrintAllVideoPlayCount() 
        {
            Console.WriteLine($"User: {this.username}");
            for (int i = 0; i < GetTotalVideoPlayCount(); i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {this.uploadedVideo[i].GetTitle()}");
            }
        }
    }
}