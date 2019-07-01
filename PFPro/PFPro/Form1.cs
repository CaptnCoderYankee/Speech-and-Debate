using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FotoFly;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Image CaptureScreen()
       {
           return CaptureWindow(User32.GetDesktopWindow());
       }

        public Image CaptureWindow(IntPtr handle)
        {
            // get te hDC of the target window
            IntPtr hdcSrc = User32.GetWindowDC(handle);
            // get the size
            User32.RECT windowRect = new User32.RECT();
            User32.GetWindowRect(handle, ref windowRect);
            int width = windowRect.right - windowRect.left;
            int height = windowRect.bottom - windowRect.top;
            // create a device context we can copy to
            IntPtr hdcDest = GDI32.CreateCompatibleDC(hdcSrc);
            // create a bitmap we can copy it to,
            // using GetDeviceCaps to get the width/height
            IntPtr hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, width, height);
            // select the bitmap object
            IntPtr hOld = GDI32.SelectObject(hdcDest, hBitmap);
            // bitblt over
            GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY);
            // restore selection
            GDI32.SelectObject(hdcDest, hOld);
            // clean up
            GDI32.DeleteDC(hdcDest);
            User32.ReleaseDC(handle, hdcSrc);
            // get a .NET image object for it
            Image img = Image.FromHbitmap(hBitmap);
            // free up the Bitmap object
            GDI32.DeleteObject(hBitmap);
            return img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CaptureWindowToFile(IntPtr handle, string filename, ImageFormat format)
        {
            Image img = CaptureWindow(handle);
            img.Save(filename, format);
        }
        public void CaptureScreenToFile(string filename, ImageFormat format)
        {
            Image img = CaptureScreen();
            img.Save(filename, format);
        }

        string fileName;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 sc = new Form1();
            // capture entire screen, and save it to a file
            Image img = sc.CaptureScreen();

            sc.CaptureWindowToFile(this.Handle, tagFileNameBox.Text, ImageFormat.Jpeg);
            if (File.Exists(tagFileNameBox.Text))
            {
                
                //Check to see if the file exists, if it does, append.
                int append = 1;

                while (File.Exists($"{tagFileNameBox.Text} -{append}.jpg"))
                {
                    append++;
                }

                fileName = $"{tagFileNameBox.Text} -{append}.jpg";
                sc.CaptureWindowToFile(this.Handle, fileName, ImageFormat.Jpeg);
                Console.WriteLine(fileName);
            }

            //File.Copy(fileName, fileName, false);
            JpgPhoto jpg = new JpgPhoto(fileName);
            jpg.ReadMetadata();

            jpg.Metadata.Tags.Add($"{tagFileNameBox.Text}");

            jpg.WriteMetadata();
            img.Tag = $"{tagFileNameBox.Text}";

            ReadMetadata(fileName);
            Console.WriteLine(jpg.Metadata.Tags);

            
        }

        public static void ReadMetadata(string fileName)
        {
            JpgPhoto jpgPhoto = new JpgPhoto(fileName);
            jpgPhoto.ReadMetadata();
            Console.WriteLine(jpgPhoto.Metadata.Tags);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}





//public static void AddTag(string inputFile)
//{
//    File.Copy(inputFile, "JpgPhotoExamples.AddTag.jpg", true);

//    JpgPhoto jpgPhoto = new JpgPhoto("JpgPhotoExamples.AddTag.jpg");
//    jpgPhoto.ReadMetadata();

//    jpgPhoto.Metadata.Tags.Add("Test Tag: " + DateTime.Now.ToString());

//    jpgPhoto.WriteMetadata();
//}

//public static void AddRegion(string inputFile)
//{
//    File.Copy(inputFile, "JpgPhotoExamples.AddRegion.jpg", true);

//    // Open file and read metadata
//    JpgPhoto jpgPhoto = new JpgPhoto("JpgPhotoExamples.AddRegion.jpg");
//    jpgPhoto.ReadMetadata();

//    // Create new Region
//    MicrosoftImageRegion newRegion = new MicrosoftImageRegion();
//    newRegion.PersonDisplayName = "Ben Vincent";
//    newRegion.RectangleString = "0.1, 0.1, 0.1, 0.1";

//    // Add the new region to the photo
//    jpgPhoto.Metadata.MicrosoftRegionInfo.Regions.Add(newRegion);

//    // Save
//    jpgPhoto.WriteMetadata();
//}

//public static void AddGpsCoor(string inputFile)
//{
//    File.Copy(inputFile, "JpgPhotoExamples.AddGpsCoor.jpg", true);

//    JpgPhoto jpgPhoto = new JpgPhoto("JpgPhotoExamples.AddGpsCoor.jpg");
//    jpgPhoto.ReadMetadata();

//    jpgPhoto.Metadata.GpsPositionOfLocationCreated.Latitude.Numeric = 1.05;
//    jpgPhoto.Metadata.GpsPositionOfLocationCreated.Longitude.Numeric = -0.95;
//    jpgPhoto.Metadata.GpsPositionOfLocationCreated.Dimension = GpsPosition.Dimensions.TwoDimensional;
//    jpgPhoto.Metadata.GpsPositionOfLocationCreated.Source = "GPS Test";

//    jpgPhoto.WriteMetadata();
//}

//public static void GenerateFileNames(string inputFile)
//{
//    // Read File
//    JpgPhoto jpgphoto = new JpgPhoto(inputFile);
//    jpgphoto.ReadMetadata();

//    // Write out three suggested file names
//    Console.WriteLine(jpgphoto.RecommendedFileName(GenericPhotoEnums.FilenameFormats.yyyymmddSecondsSinceMidnight, "Photo"));
//    Console.WriteLine(jpgphoto.RecommendedFileName(GenericPhotoEnums.FilenameFormats.yyyymmddHoursMinutesSeconds, "Photo"));
//    Console.WriteLine(jpgphoto.RecommendedFileName(GenericPhotoEnums.FilenameFormats.yyyymmddSequence, "Photo"));
//}
//}