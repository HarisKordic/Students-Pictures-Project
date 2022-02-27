using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Source_code.Helpers
{
    internal static class ImageConverter
    {
        #region Image to byte array conversion
        public static byte[] ImageToByte(Image image)
        {
            if (image != null)
            {
                var stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
            return null;
        }
        #endregion

        #region Byte array to Image conversion
        public static Image ByteToImage(byte[] stream)
        {
            if (stream != null)
            {
                var newStream = new MemoryStream(stream);
                return Image.FromStream(newStream);
            }
            return null;
        }
        #endregion
    }
}
