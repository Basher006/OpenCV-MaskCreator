using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace OpenCV_MaskCreator
{
    public static class OpenCV
    {
        private static Bitmap? result;

        public static Bitmap? GetMask(Mat? image, GUIData data)
        {
            if (image == null)
                return null;

            using Mat sourse = image.Clone();
            //using Mat sourse = new(image, new Rect(0, 0, image.Width, image.Height));
            using Mat mask = new();


            if (data.Blure.Enable)
            {
                var size = new OpenCvSharp.Size(data.Blure.Size, data.Blure.Size);
                for (int i = 0; i < data.Blure.Iter; i++)
                {
                    Cv2.Blur(sourse, sourse, size);
                }
            }

            if (data.Erode.Enable)
            {
                var size = new OpenCvSharp.Size(data.Erode.Size, data.Erode.Size);
                var element = Cv2.GetStructuringElement(MorphShapes.Cross, size, new OpenCvSharp.Point(-1, -1));
                Cv2.Erode(sourse, sourse, element, new OpenCvSharp.Point(-1, -1), data.Erode.Iter, BorderTypes.Constant);
            }

            Cv2.InRange(sourse, data.Lower, data.Upper, mask);

            result?.Dispose();
            result = mask.ToBitmap();

            return result;
        }
    }
}
