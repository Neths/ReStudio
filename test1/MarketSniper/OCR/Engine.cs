using System;
using System.Collections.Generic;
using System.Drawing;

namespace MarketSniper.OCR
{
    public class EmguEngine : ICharRecognition
    {
        public IEnumerable<char> RecognizeCaptcha(Bitmap captcha)
        {
            throw new NotImplementedException();
        }
    }

    public interface ICharRecognition
    {
        IEnumerable<char> RecognizeCaptcha(Bitmap captcha);
    }
}
