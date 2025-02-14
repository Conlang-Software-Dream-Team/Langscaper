namespace Langscaper_Core.Contracts
{
    public interface IFileManager
    {
        public string GetAudioFileFullPath(string fileName);
        public void WriteToFile(string filePath, string content);
        public string ReadFromFile(string filePath);

    }
}
