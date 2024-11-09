using System;
using NAudio.Wave;

namespace Audio
{

    public class AudioMP3
    {
        protected void runMP3(string filename)
        {
            using(var audioPlik = new AudioFileReader(filename))
            using(var wyjscieAudio = new WaveOutEvent()){
                wyjscieAudio.Init(audioPlik);
                wyjscieAudio.Play();
                while(wyjscieAudio.PlaybackState == PlaybackState.Playing){
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
    }
}