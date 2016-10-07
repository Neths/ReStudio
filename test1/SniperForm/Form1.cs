using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.Structure;

namespace SniperForm
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> _img;
        private int colorRange = 0;
        private int offset = 5;
        Image<Gray, Byte> imgCleand = null;

        private Tesseract ocr;

        public Form1()
        {
            InitializeComponent();

            ocr = new Tesseract();
            ocr.SetVariable("tessedit_char_whitelist", "1234567890");
            ocr.Init(@"D:\", "eng", OcrEngineMode.TesseractOnly);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _img = new Image<Bgr, byte>(@"d:\raw\classified\test.jpg");

            pictureBox1.Image = _img.ToBitmap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var a = new Image<Gray, byte>(new Size
            //{
            //    Height = _img.Height,
            //    Width = _img.Width
            //});

            //CvInvoke.CvtColor(_img, a, ColorConversion.Bgr2Hsv);

            imgCleand = _img.InRange(new Bgr(int.Parse(txtB.Text) - int.Parse(txtOffset.Text), int.Parse(txtG.Text) - int.Parse(txtOffset.Text), int.Parse(txtR.Text) - int.Parse(txtOffset.Text)), 
                new Bgr(int.Parse(txtB.Text) + int.Parse(txtOffset.Text), int.Parse(txtG.Text) + int.Parse(txtOffset.Text), int.Parse(txtR.Text) + int.Parse(txtOffset.Text)));


            pictureBox1.Image = imgCleand.ToBitmap();

            



            //using (Image<Hsv, byte> hsv = _img.Convert<Hsv, byte>())
            //{
            //    // 2. Obtain the 3 channels (hue, saturation and value) that compose the HSV image
            //    Image<Gray, byte>[] channels = hsv.Split();

            //    try
            //    {
            //        //channels[0].InRange(new Gray(40), new Gray(60));
            //        //// 3. Remove all pixels from the hue channel that are not in the range [40, 60]
            //        //CvInvoke.cvInRangeS(channels[0], new Gray(40).MCvScalar, new Gray(60).MCvScalar, channels[0]);





            //        var a = channels[0].InRange(new Gray(Color.Red.GetHue() - 0), new Gray(Color.Red.GetHue() + 0)).ToBitmap();

            //        // 4. Display the result
            //        pictureBox1.Image = CvInvoke.cv;
            //    }
            //    finally
            //    {
            //        channels[1].Dispose();
            //        channels[2].Dispose();
            //    }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocr.Recognize(imgCleand);

            var sb = new StringBuilder();
            ocr.GetText().Where(char.IsDigit).ToList().ForEach(c => sb.Append(c));
            lblH.Text = sb.ToString();
        }
    }
}
