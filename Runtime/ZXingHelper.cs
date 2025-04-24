using UnityEngine;
using ZXing;
using ZXing.QrCode;

namespace KC
{
    public static partial class ZXingHelper
    {
        public static Texture2D Generate(string url,int size = 256)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions()
                {
                    CharacterSet = "UTF-8",
                    Width = size,
                    Height = size
                }
            };
            var pixels = writer.Write(url);
            var texture = new Texture2D(size, size);
            texture.SetPixels32(pixels);
            texture.Apply();
            return texture;
        }
    }
}