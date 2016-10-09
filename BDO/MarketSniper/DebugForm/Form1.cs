using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using MarketSniper.Helpers;

namespace DebugForm
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> rawCaptcha;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaptureCaptcha_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName(txtProcessName.Text)[0];

            User32.SetForegroundWindow(proc.MainWindowHandle);

            var top = int.Parse(txtYCaptcha.Text);
            var left = int.Parse(txtXCaptcha.Text);
            var height = int.Parse(txtHCapture.Text);
            var width = int.Parse(txtWCapture.Text);

            var rect = new User32.Rect() {top = top, left = left, bottom = top + height, right = left + width};
            User32.GetWindowRect(proc.MainWindowHandle, ref rect);

            var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(left, top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

            pictCapture.Image = bmp;
            rawCaptcha = new Image<Bgr, byte>(bmp);
        }

        private void btnCaptureContour_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName(txtProcessName.Text)[0];

            User32.SetForegroundWindow(proc.MainWindowHandle);

            var top = int.Parse(txtYCaptureContour.Text);
            var left = int.Parse(txtXCaptureContour.Text);
            var height = int.Parse(txtHCaptureContour.Text);
            var width = int.Parse(txtWCaptureContour.Text);

            var rect = new User32.Rect {top = top, left = left, bottom = top + height, right = left + width};
            User32.GetWindowRect(proc.MainWindowHandle, ref rect);

            var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(left, top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);



            //try
            //{
            //    var q = FindRectangle(imgSrc, imgDst);
            //}
            //catch (Exception ex)
            //{
                
            //}
            

            //pictCaptureContour.Image = imgDst.ToBitmap();
        }

        public static VectorOfVectorOfPoint FindRectangle(IInputOutputArray cannyEdges, IInputOutputArray result, int areaSize = 250)
        {
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    var rect = CvInvoke.MinAreaRect(contours[i]).MinAreaRect();
                    CvInvoke.Rectangle(result, rect, new MCvScalar(0, 0, 255), 3);

                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);


                        if (CvInvoke.ContourArea(approxContour, false) > areaSize) //only consider contours with area greater than 250
                        {
                            if (approxContour.Size >= 4) //The contour has 4 vertices.
                            {
                                #region determine if all the angles in the contour are within [80, 100] degree
                                bool isRectangle = true;
                                Point[] pts = approxContour.ToArray();
                                LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                                for (int j = 0; j < edges.Length; j++)
                                {
                                    double angle = Math.Abs(
                                       edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                    if (angle < 80 || angle > 100)
                                    {
                                        isRectangle = false;
                                        break;
                                    }
                                }
                                #endregion

                                

                                //if (isRectangle)
                                //{
                                //    var rect = CvInvoke.MinAreaRect(approxContour).MinAreaRect();
                                //    CvInvoke.Rectangle(result, rect, new MCvScalar(0, 0, 255), 3);
                                //    //boxList.Add(CvInvoke.MinAreaRect(approxContour));
                                //}
                            }
                        }
                    }
                }

                return contours;
            }
        }

        public static VectorOfPoint FindLargestContour(IInputOutputArray cannyEdges, IInputOutputArray result)
        {
            int largest_contour_index = 0;
            double largest_area = 0;
            VectorOfPoint largestContour;

            using (Mat hierachy = new Mat())
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                IOutputArray hirarchy;

                CvInvoke.FindContours(cannyEdges, contours, hierachy, RetrType.Tree, ChainApproxMethod.ChainApproxNone);

                for (int i = 0; i < contours.Size; i++)
                {
                    MCvScalar color = new MCvScalar(0, 0, 255);

                    double a = CvInvoke.ContourArea(contours[i], false);  //  Find the area of contour
                    if (a > largest_area)
                    {
                        largest_area = a;
                        largest_contour_index = i;                //Store the index of largest contour
                    }

                    CvInvoke.DrawContours(result, contours, largest_contour_index, new MCvScalar(255, 0, 0));
                }

                CvInvoke.DrawContours(result, contours, largest_contour_index, new MCvScalar(0, 0, 255), 3, LineType.EightConnected, hierachy);
                largestContour = new VectorOfPoint(contours[largest_contour_index].ToArray());
            }

            return largestContour;
        }

        private void btnFilteringCaptcha_Click(object sender, EventArgs e)
        {
            var filterB = int.Parse(txtBFiltering.Text);
            var filterG = int.Parse(txtGFiltering.Text);
            var filterR = int.Parse(txtRFiltering.Text);
            var filterOffset = int.Parse(txtOFiltering.Text);
            var areaSize = int.Parse(txtArea.Text);

            var imgDst = rawCaptcha.InRange(new Bgr(filterB - filterOffset, filterG - filterOffset, filterR - filterOffset),
                new Bgr(filterB + filterOffset, filterG + filterOffset, filterR + filterOffset));

            var a = new Image<Gray,byte>(imgDst.ToBitmap());

            var result = FindRectangle(imgDst, a, areaSize);

            pictFiltering.Image = a.ToBitmap();
        }
    }
}
