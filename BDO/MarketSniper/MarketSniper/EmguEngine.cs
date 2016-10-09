using System;
using System.Collections.Generic;
using System.Drawing;

namespace MarketSniper
{
    public class EmguEngine : ICharRecognition
    {
        public IEnumerable<char> RecognizeCaptchat(Bitmap img)
        {
            throw new NotImplementedException();
        }
    }

    public interface ICharRecognition
    {
        IEnumerable<char> RecognizeCaptchat(Bitmap img);
    }
}
