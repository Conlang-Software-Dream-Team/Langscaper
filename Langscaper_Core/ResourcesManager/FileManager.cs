namespace Langscaper_Core.ResourcesManager.FileSystem
{
    public static class FileManager
    {
        private static readonly string AudioDirectory = Path.Combine(AppContext.BaseDirectory, "Assets", "Audio");

        static FileManager()
        {
            if (!Directory.Exists(AudioDirectory))
            {
                throw new DirectoryNotFoundException($" Folder not founds :  {AudioDirectory}");
            }
        }

        public static event Action<string>? OnErrorLogged;

        public static string GeAudiotFilePath(string fileName)
        {

            try
            {
                string fullPath = Path.Combine(AudioDirectory, fileName);
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