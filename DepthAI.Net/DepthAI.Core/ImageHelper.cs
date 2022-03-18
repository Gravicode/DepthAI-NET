using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;

namespace DepthAI.Core
{
    public class ImageHelper
    {
        public static int GetStride(int width, PixelFormat pxFormat)
        {
            //float bitsPerPixel = System.Drawing.Image.GetPixelFormatSize(format);
            int bitsPerPixel = ((int)pxFormat >> 8) & 0xFF;
            //Number of bits used to store the image data per line (only the valid data)
            int validBitsPerLine = width * bitsPerPixel;
            //4 bytes for every int32 (32 bits)
            int stride = ((validBitsPerLine + 31) / 32) * 4;
            return stride;
        }
    }
}
