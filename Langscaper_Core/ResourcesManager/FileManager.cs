namespace Langscaper_Core.ResourcesManager.FileSystem
{
    public static class FileManager
    {
        public static event Action<string>? OnErrorLogged;

        static FileManager()
        {
            try
            {
                if (!Directory.Exists(AppSettings.AudioDirectory))
                    throw new DirectoryNotFoundException($"[FileManager]Audio folder not founds at {AppSettings.AudioDirectory}");
            }
            catch(DirectoryNotFoundException e) 
            {
                OnErrorLogged?.Invoke(e.Message);
            }
        }


        public static string GetAudioFileFullPath(string fileName)
        {
            try
            {
                string fullPath = Path.Combine(AppSettings.AudioDirectory, fileName);
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
    }

}