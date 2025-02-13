using NAudio.Vorbis;
using NAudio.Wave;
using Langscaper_Core.Phonology;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Langscaper_Core.ResourcesManager.Audio
{
    public static class AudioPlayer
    {
        public static async void PlayAudio(string fullPath)
        {
            if (string.IsNullOrWhiteSpace(fullPath)) return;

            // Vérifier si l'audio est déjà dans le cache
            byte[]? audioData = AudioCacheManager.GetAudio(fullPath);

            if (audioData == null)
            {
                // L'audio n'est pas dans le cache, donc on le charge
                await AudioCacheManager.PreloadAudioAsync(fullPath); // On attend que le fichier soit chargé
                audioData = AudioCacheManager.GetAudio(fullPath);
            }

            if (audioData != null)
            {
                // Créer un flux mémoire à partir des données audio
                using (var stream = new MemoryStream(audioData))
                {
                    // Créer un lecteur Vorbis pour lire les fichiers OGG
                    using (var reader = new VorbisWaveReader(stream))
                    {
                        // Créer un WaveOutEvent pour la lecture de l'audio
                        using (var waveOut = new WaveOutEvent())
                        {
                            waveOut.Init(reader); // Initialiser le lecteur avec le flux audio
                            waveOut.Play(); // Jouer l'audio
                            while (waveOut.PlaybackState == PlaybackState.Playing)
                            {
                                // Attendre que l'audio se termine avant de continuer
                                System.Threading.Thread.Sleep(100);
                            }
                        }
                    }
                }
            }
            else
            {
                throw new InvalidOperationException($"Unable to load audio for fullPath: {fullPath}");
            }
        }
    }
}
