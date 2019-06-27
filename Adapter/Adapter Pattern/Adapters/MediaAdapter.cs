using Adapter_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Adapters
{
    public class MediaAdapter : IAudioPlayer
    {
        IMediaPlayer _mediaPlayer;

        public MediaAdapter(IMediaPlayer mediaPlayer)
        {
            _mediaPlayer = mediaPlayer;
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                _mediaPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                _mediaPlayer.PlayMp4(fileName);
            }
        }
    }
}
