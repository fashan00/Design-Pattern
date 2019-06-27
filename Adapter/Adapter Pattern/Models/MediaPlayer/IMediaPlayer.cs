﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Models
{
    public interface IMediaPlayer
    {
        void PlayVlc(string fileName);
        void PlayMp4(string fileName);
    }
}
