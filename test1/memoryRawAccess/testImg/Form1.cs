using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace testImg
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> _image;
        private Mat _gray;
        private Mat _canny;
        private UMat _result;

        private IInputArray _inputArray;

        public Form1()
        {
            InitializeComponent();


        }

        private static UMat FilterPlate(UMat plate)
        {
            UMat thresh = new UMat();
            CvInvoke.Threshold(plate, thresh, 120, 255, ThresholdType.BinaryInv);
            //Image<Gray, Byte> thresh = plate.ThresholdBinaryInv(new Gray(120), new Gray(255));

            Size plateSize = plate.Size;
            using (Mat plateMask = new Mat(plateSize.Height, plateSize.Width, DepthType.Cv8U, 1))
            using (Mat plateCanny = new Mat())
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                plateMask.SetTo(new MCvScalar(255.0));
                CvInvoke.Canny(plate, plateCanny, 100, 50);
                CvInvoke.FindContours(plateCanny, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                int count = contours.Size;
                for (int i = 1; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    {

                        Rectangle rect = CvInvoke.BoundingRectangle(contour);
                        if (rect.Height > (plateSize.Height >> 1))
                        {
                            rect.X -= 1;
                            rect.Y -= 1;
                            rect.Width += 2;
                            rect.Height += 2;
                            Rectangle roi = new Rectangle(Point.Empty, plate.Size);
                            rect.Intersect(roi);
                            CvInvoke.Rectangle(plateMask, rect, new MCvScalar(), -1);
                            //plateMask.Draw(rect, new Gray(0.0), -1);
                        }
                    }

                }

                thresh.SetTo(new MCvScalar(), plateMask);
            }

            CvInvoke.Erode(thresh, thresh, null, new Point(-1, -1), 1, BorderType.Constant,
                CvInvoke.MorphologyDefaultBorderValue);
            CvInvoke.Dilate(thresh, thresh, null, new Point(-1, -1), 1, BorderType.Constant,
                CvInvoke.MorphologyDefaultBorderValue);

            return thresh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _image = GetImage(@"d:\raw\classified\3_9_0.jpg");

                var tmpImage = GetImage(@"d:\raw\classified\3_9_1.jpg");

                _image.And(tmpImage,null);

                _inputArray = _image;

                pictureBox1.Image = _image.ToBitmap();
            }
            catch (Exception ex)
            {
                
                throw;
            }



            //var _ocr = new Tesseract(@"D:\", "eng", OcrEngineMode.TesseractCubeCombined);
            //_ocr.SetVariable("tessedit_char_whitelist", "1234567890");

            ////var tmp = FilterPlate(img);

            //_ocr.Recognize(_image);

            //var result = _ocr.GetCharacters();
        }

        private Image<Bgr, byte> GetImage(string path)
        {
            _image = new Image<Bgr, byte>(path)
            {
                ROI = new Rectangle {X = 736, Y = 566, Height = 24, Width = 22}
            };

            var copiedImage = _image.Copy();

            return copiedImage.Resize(2, Inter.Nearest);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _gray = new Mat();

                CvInvoke.CvtColor(_image, _gray, ColorConversion.Bgr2Gray);

                _inputArray = _gray;

                pictureBox1.Image = _gray.Bitmap;
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            _canny = new Mat();

            CvInvoke.Canny(_gray, _canny, 100, 50, 3, false);

            _inputArray = _canny;

            pictureBox1.Image = _canny.Bitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _result = FilterPlate(_gray.ToUMat(AccessType.Read));

            _inputArray = _result;

            pictureBox1.Image = _result.Bitmap;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var _ocr = new Tesseract(@"D:\", "eng", OcrEngineMode.TesseractCubeCombined);
            _ocr.SetVariable("tessedit_char_whitelist", "1234567890");

            _ocr.Recognize(_inputArray);

            var result = _ocr.GetCharacters().ToList();

            var sb = new StringBuilder();

            result.ForEach(c => sb.Append(c.Text));

            label1.Text = sb.ToString();
        }
    }
}
