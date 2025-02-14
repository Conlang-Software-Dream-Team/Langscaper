using Langscaper_Core.Contracts;
using NAudio.Vorbis;
using NAudio.Wave;
using System.Diagnostics;

namespace Langscaper_Core.Infra.Audio
{
    public class AudioPlayer : IAudioPlayer
    {
        private AudioCacheManager cacheManager;

        public AudioPlayer(AudioCacheManager audioCachemanager)
        {
            cacheManager = audioCachemanager;
        }

        public async Task PlayAudio(string fullPath)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(fullPath), $"[AudioPlayer] Path can't be null");

            byte[]? audioData = cacheManager.GetAudio(fullPath);

            if (audioData == null)
            {
                await cacheManager.PreloadAudioAsync(fullPath);
                audioData = cacheManager.GetAudio(fullPath);
            }

            if (audioData != null)
            {
                using var stream = new MemoryStream(audioData);
                using var reader = new VorbisWaveReader(stream);
                var waveOut = new WaveOutEvent();

                var playbackCompletion = new TaskCompletionSource<bool>();

                waveOut.PlaybackStopped += (sender, e) =>
                {
                    Debug.WriteLine("[Audio Player] Stop playing.");
                    playbackCompletion.SetResult(true);
                    waveOut.Dispose();
                };

                waveOut.Init(reader);
                waveOut.Play();
                Debug.WriteLine("[Audio Player] Start playing...");

                await playbackCompletion.Task;
            }
            else
            {
                throw new InvalidOperationException($"[AudioPlayer] Unable to load audio for fullPath: {fullPath}");
            }
        }
    }
}
