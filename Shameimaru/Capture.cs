using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Shameimaru
{
    public static class ScreenCapture
    {
        public static Bitmap GetScreen()
        {
            try
            {
                var primScreen = Screen.PrimaryScreen;
                var bitmap = new Bitmap(primScreen.Bounds.Width,
                    primScreen.Bounds.Height, PixelFormat.Format32bppArgb);

                var g = Graphics.FromImage(bitmap);

                g.CopyFromScreen(
                    primScreen.Bounds.Left, primScreen.Bounds.Top,
                    0, 0,
                    primScreen.Bounds.Size);

                return bitmap;
            }
            catch
            {
                return null;
            }
        }

        public static Bitmap Crop(Bitmap src, int top, int left, int bottom, int right)
        {
            var cropRect = new Rectangle(left, top, right - left, bottom - top);

            var dst = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(dst))
            {
                g.DrawImage(src, new Rectangle(0, 0, dst.Width, dst.Height),
                    cropRect, GraphicsUnit.Pixel);
            }

            return dst;
        }
    }
}
