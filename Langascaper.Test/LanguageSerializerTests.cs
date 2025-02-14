using Langscaper_Core.Models;
using Langscaper_Core.Phonology;
using Langscaper_Core.Services;
using Newtonsoft.Json;
using System.IO;
using Xunit;

namespace Langascaper.Test
{
    public class LanguageSerializerTests
    {
        [Fact]
        public void Serialize_ShouldCreateValidJsonFile()
        {
            var p1 = new PhonemeModel();
            p1.phonem = Phoneme.AlveolarApproximant;
            var p2 = new PhonemeModel();
            p2.phonem = Phoneme.CloseBackRoundedVowel;

            var inventory = new List<PhonemeModel>()
            {
                p1,p2
            };
            var language = new LanguageModel { Name = "TestLang", PhonemicInventory = inventory };
            string filePath = "TestLang.conlang";

            // Sérialisation de l'objet en fichier
            LanguageSerializer.Serialize(language, "");

            // Vérification que le fichier a bien été créé
            Assert.True(File.Exists(filePath));

            string jsonContent = File.ReadAllText(filePath);
            var deserializedLanguage = JsonConvert.DeserializeObject<LanguageModel>(jsonContent);

            Assert.Equal("TestLang", deserializedLanguage.Name);
            Assert.Equal(2, deserializedLanguage.PhonemicInventory.Count);
            Assert.Equal(Phoneme.AlveolarApproximant, deserializedLanguage.PhonemicInventory[0].phonem);
            Assert.Equal(Phoneme.CloseBackRoundedVowel, deserializedLanguage.PhonemicInventory[1].phonem);
            Assert.Equal(language.Id, deserializedLanguage.Id);

            // Suppression du fichier de test (optionnel)
            File.Delete(filePath);
        }
    }
}