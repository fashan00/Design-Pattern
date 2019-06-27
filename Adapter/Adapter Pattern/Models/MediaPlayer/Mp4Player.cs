using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Models
{
    public class Mp4Player : IMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            //do nothing
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }
    }
}
