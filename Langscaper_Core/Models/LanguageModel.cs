
namespace Langscaper_Core.Models
{
    public class LanguageModel
    {
        public string Name { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<PhonemeModel> PhonemicInventory { get; set; } = new();

        public void UpdateTimestamp()
        {
            LastUpdate = DateTime.UtcNow;
        }
    }
}
