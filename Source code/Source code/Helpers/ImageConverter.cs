﻿using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Source_code.Helpers
{
    internal static class ImageConverter
    {
        public static byte[] ImageToByte(Image image)
        {
            if (image != null)
            {
                var stream=new MemoryStream();
                image.Save(stream,ImageFormat.Jpeg);
                return stream.ToArray();
            }
            return null;
        }

        public static Image ByteToImage(byte[] Stream)
        {
            if (Stream != null)
            {
                var stream=new MemoryStream(Stream);
                return Image.FromStream(stream);
            }
            return null;
        }
    }
}