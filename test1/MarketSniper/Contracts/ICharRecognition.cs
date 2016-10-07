using System.Collections.Generic;
using System.Drawing;

namespace MarketSniper.Contracts
{
    public interface ICharRecognition
    {
        IEnumerable<char> RecognizeCaptcha(Bitmap captcha);
    }
}
