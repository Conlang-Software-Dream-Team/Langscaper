namespace Langscaper_Core.ResourcesManager
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

        public static string GeAudiotFilePath(string fileName)
        {
            string fullPath = Path.Combine(AudioDirectory, fileName);
            return File.Exists(fullPath) ? fullPath : throw new FileNotFoundException($"Files not founds : {fileName}");
        }
    }

}