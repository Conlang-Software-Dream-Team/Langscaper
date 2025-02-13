using NAudio.Vorbis;
using NAudio.Wave;
using System.Diagnostics;

namespace Langscaper_Core.ResourcesManager.Audio
{
    public interface IAudioPlayer
    {
        Task PlayAudio(string fullPath);
    }

    public class AudioPlayer : IAudioPlayer
    {
        public async Task PlayAudio(string fullPath)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(fullPath), $"[AudioPlayer] Path can't be null");

            byte[]? audioData = AudioCacheManager.GetAudio(fullPath);

            if (audioData == null)
            {
                await AudioCacheManager.PreloadAudioAsync(fullPath);
                audioData = AudioCacheManager.GetAudio(fullPath);
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
