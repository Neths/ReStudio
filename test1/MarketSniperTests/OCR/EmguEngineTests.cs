using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using MarketSniper.OCR;
using NUnit.Framework;
using Utils.Extensions;

namespace MarketSniperTests.OCR
{
    [TestFixture]
    public class EmguEngineTests
    {
        private IEnumerable<ImageTest> _testImagesList;

        public struct ImageTest
        {
            public string FirstDigit;
            public string SecondDigit;
            public string Indice;
            public string Path;
            public Bitmap Image;
        }

        [SetUp]
        public void SetUp()
        {
            var pathToImagesTestSet = Path.Combine(@"D:\ReStudio\test1", @"raw\classified");
            var testsImagePathList = new DirectoryInfo(pathToImagesTestSet).GetFiles();

            _testImagesList = testsImagePathList.Select(fileInfo =>
            {
                var filenameElements = fileInfo.Name.Split('_');
                return new ImageTest
                {
                    FirstDigit = filenameElements[0],
                    SecondDigit = filenameElements[1],
                    Indice = filenameElements[2],
                    Path = fileInfo.FullName,
                    Image = new Bitmap(fileInfo.FullName)
                };
            });
        }

        [Test]
        public void Shoud_Get_Right_Captchat_When_Give_First_Image()
        {
            var imageToTest = _testImagesList.First();
            var engine = new EmguEngine();
            
            Assert.AreEqual($"{imageToTest.FirstDigit}{imageToTest.SecondDigit}".ToCharArray(),engine.RecognizeCaptcha(imageToTest.Image));
        }

        [Test]
        public void Shoud_Get_Right_Captchat_When_Give_Random_Image()
        {
            var imageToTest = _testImagesList.Random();

            var engine = new EmguEngine();

            Assert.AreEqual($"{imageToTest.FirstDigit}{imageToTest.SecondDigit}".ToCharArray(), engine.RecognizeCaptcha(imageToTest.Image));
        }

        [Test]
        public void Shoud_Get_Right_Captchat_When_Give_All_Images_Of_Tests_Set()
        {
            _testImagesList.ToList().ForEach(i =>
            {
                var engine = new EmguEngine();

                Assert.AreEqual($"{i.FirstDigit}{i.SecondDigit}".ToCharArray(), engine.RecognizeCaptcha(i.Image));
            });
        }
    }
}
