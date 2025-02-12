namespace Langscaper_Core.ResourcesManager.FileSystem
{
    public static class FileManager
    {

        static FileManager()
        {
            if (!Directory.Exists(AppSettings.AudioDirectory))
            {
                throw new DirectoryNotFoundException($" Folder not founds :  {AppSettings.AudioDirectory}");
            }
        }

        public static event Action<string>? OnErrorLogged;

        public static string GetAudioFilePath(string fileName)
        {

            try
            {
                string fullPath = Path.Combine(AppSettings.AudioDirectory, fileName);
                if (File.Exists(fullPath))
                    return fullPath;

                throw new FileNotFoundException($"Files not founds : {fileName}");
            }
            catch (Exception e)
            {
                OnErrorLogged?.Invoke($"[FileManager] Audio file {fileName} not founds : {e.Message}");
                return "";
            }
        }
    }

}