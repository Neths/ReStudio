using System;
using System.Collections.Generic;
using System.Drawing;
using MarketSniper.Contracts;

namespace MarketSniper.OCR
{
    public class EmguEngine : ICharRecognition
    {
        public IEnumerable<char> RecognizeCaptcha(Bitmap captcha)
        {
            return new List<char>() {'3','9'};
        }
    }
}