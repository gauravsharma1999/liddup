﻿using System.IO;
using Liddup.Droid.Services;
using Liddup.Services;
using Xamarin.Forms;
using Environment = Android.OS.Environment;

[assembly: Dependency(typeof(FileSystemAndroid))]

namespace Liddup.Droid.Services
{
    public class FileSystemAndroid : IFileSystem
    {
        public string GetMusicDirectory()
        {
            return Environment.GetExternalStoragePublicDirectory(Environment.DirectoryMusic).AbsolutePath;
            //return Environment.GetExternalStoragePublicDirectory(Environment.DirectoryDownloads).AbsolutePath;
        }

        public void DeleteDirectoryContents(string path)
        {
            var files = Directory.GetFiles(path, "*");

            if (files.Length <= 0) return;
            foreach (var file in files)
                File.Delete(file);
        }
    }
}