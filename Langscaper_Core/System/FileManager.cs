using Langscaper_Core.Contracts;

namespace Langscaper_Core.System.FileSystem
{
    public class FileManager : IFileManager
    {
        public event Action<string>? OnErrorLogged;
        private readonly string? audioDirectory;

        public FileManager(string audioDirectoryPath)
        {
            try
            {
                if (!Directory.Exists(audioDirectoryPath))
                    throw new DirectoryNotFoundException($"[FileManager] Audio folder not founds at {AppSettings.AudioDirectory}");
                audioDirectory = audioDirectoryPath;
            }
            catch (DirectoryNotFoundException e)
            {
                OnErrorLogged?.Invoke(e.Message);
            }
        }



        public string GetAudioFileFullPath(string fileName)
        {
            try
            {
                string fullPath = Path.Combine(audioDirectory, fileName);
                if (File.Exists(fullPath))
                    return fullPath;

                throw new FileNotFoundException($"[FileManager] Audio files not founds : {fileName}");
            }
            catch (Exception e)
            {
                OnErrorLogged?.Invoke(e.Message);
                return "";
            }
        }

        public void WriteToFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        public string ReadFromFile(string filePath)
        {
            return File.Exists(filePath) ? File.ReadAllText(filePath) : string.Empty;
        }
    }

}