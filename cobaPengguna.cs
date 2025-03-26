﻿using cobaPutarVideo;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace cobaPengguna
{
    public class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideo;
        public SayaTubeUser(string username)
        {
            Contract.Requires(!string.IsNullOrEmpty(username), "Username must not be empty."); // Ensure username is not empty
            Contract.Requires(username.Length <= 100, "Username must be less than or equal to 100 characters."); // Ensure username length is valid

            Random rnd = new Random(); // Membuat objek random baru untuk menghasilkan angka acak
            this.id = rnd.Next(00000, 99999); // Buat nomor acak antara 00000 dan 99999 secara otomatis (inlkusif)
            this.username = username;
            this.uploadedVideo = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            return this.uploadedVideo.Count;
        }

        public void UploadVideo(SayaTubeVideo video)
        {
            Contract.Requires(video != null, "Video must not be null."); // Ensure video is not null
            Contract.Requires(video.GetTitle() != null, "Video title must not be null."); // Ensure video title is not null
            Contract.Requires(video.GetTitle().Length <= 200, "Video title must be less than or equal to 200 characters."); // Ensure video title length is valid
            this.uploadedVideo.Add(video);
        }

        public void PrintAllVideoPlayCount() 
        {
            Contract.Ensures(GetTotalVideoPlayCount() <= 8); // Ensure that the number of videos printed does not exceed 8
            Console.WriteLine($"User: {this.username}");
            for (int i = 0; i < GetTotalVideoPlayCount(); i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {this.uploadedVideo[i].GetTitle()}");
            }
        }
    }
}