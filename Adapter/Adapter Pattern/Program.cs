using Adapter_Pattern.Adapters;
using Adapter_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3", "beyond the horizon.mp3");

            Mp4Player mp4Player = new Mp4Player();
            mp4Player.PlayMp4("alone.mp4");

            VlcPlayer vlcPlayer = new VlcPlayer();
            vlcPlayer.PlayVlc("far far away.vlc");

            Console.WriteLine("\nAdapter: IAudioPlayer play media vlc");
            IAudioPlayer mediaAdapter = new MediaAdapter(vlcPlayer);
            mediaAdapter.Play("vlc", "far far away.vlc");

            Console.ReadLine();
        }
    }
}
