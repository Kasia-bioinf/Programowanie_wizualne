using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int MirroredProperty { get; set; }

        public static int RotateProperty { get; set; }



        public MainWindow()
        {
            InitializeComponent();
            MirroredProperty = RotateProperty = 1;
        }

        private BitmapImage BitmapToImage(Bitmap img)
        {
            using (MemoryStream mr = new MemoryStream())
            {
                img.Save(mr, System.Drawing.Imaging.ImageFormat.Bmp);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = mr;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        /

        /*private Bitmap ImageToBitmap(BitmapImage img)
        {
            using (MemoryStream mr = new MemoryStream())
            {
                BitmapEncoder bitmapEncoder = new BmpBitmapEncoder();
                bitmapEncoder.Frames.Add(BitmapFrame.Create(img));
                bitmapEncoder.Save(mr);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(mr);
                return new Bitmap(bitmap);
            }
        }*/

        private void chose_button__Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "JPG|*.jpg";
            dialog.Title = "Open an Image file";

            if (dialog.ShowDialog() ?? false)
            {
                image.Source = new BitmapImage(new Uri(dialog.FileName));
            }

        }

        private void mirror_button_Click(object sender, RoutedEventArgs e)
        {
            
                if (image.Source == null) return;

                image.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
                MirroredProperty *= -1;

                ScaleTransform mirrorTransform = new ScaleTransform();
                mirrorTransform.ScaleX = MirroredProperty;

                image.RenderTransform = mirrorTransform;
            
        }

        private void spin_button_Click(object sender, RoutedEventArgs e)
        {
            if (image.Source == null) return;
            image.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);

            RotateTransform rotateTransform = new RotateTransform();
            rotateTransform.Angle = RotateProperty++ * 90;

            image.RenderTransform = rotateTransform;
        }

        /*private void green_button_Click(object sender, RoutedEventArgs e)
        {
            if (image.Source == null) return;
            BitmapImage image = (BitmapImage)image.Source;
            Bitmap bitmap = ImageToBitmap(image);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color pixel = bitmap.GetPixel(j, i);
                    int alpha = pixel.A;
                    int red = pixel.R;
                    int green = pixel.G;
                    int blue = pixel.B;

                    if (red > 150 || blue > 150)
                    {
                        red = green = blue = 255;
                    }

                    bitmap.SetPixel(j, i, System.Drawing.Color.FromArgb(alpha, red, green, blue));
                }
            }
            image.Source = BitmapToImage(bitmap);
        }*/
    }
}
