using OpenCvSharp;

namespace OpenCV_MaskCreator
{
    public struct GUIData
    {
        public MinMaxPair HUE;
        public MinMaxPair Saturation;
        public MinMaxPair Value;

        public ErodeSetup Erode;
        public BlureSetup Blure;

        public Scalar Lower { get => new(HUE.Min, Saturation.Min, Value.Min); }
        public Scalar Upper { get => new(HUE.Max, Saturation.Max, Value.Max); }

        public static bool TryParse(string data, out GUIData result)
        {
            result = new GUIData();

            try
            {
                // "L:0, 0, 0;U:255, 255, 255;E:D:1:3;B:D:3:3" => ["L:0, 0, 0", "U:255, 255, 255", "E:D:1:3", "B:D:3:3"]
                var segments = data.Split(';');

                // Lower
                // "L:10, 11, 12" => ["L", "10, 11, 12"] => "10, 11, 12" => ["10", "11", 12"]
                var LowerData = segments[0].Split(':').Last().Split(',');
                result.HUE.Min = int.Parse(LowerData[0]);
                result.Saturation.Min = int.Parse(LowerData[1]);
                result.Value.Min = int.Parse(LowerData[2]);


                // Upper
                // "U:10, 11, 12" => ["U", "10, 11, 12"] => "10, 11, 12" => ["10", "11", 12"]
                var UpperData = segments[1].Split(':').Last().Split(',');
                result.HUE.Max = int.Parse(UpperData[0]);
                result.Saturation.Max = int.Parse(UpperData[1]);
                result.Value.Max = int.Parse(UpperData[2]);

                // Erode
                // "E:E:3:3" => ["E", "E", "3", "3"]
                var erodeData = segments[2].Split(':');
                result.Erode.Enable = erodeData[1] == "E";
                result.Erode.Iter = int.Parse(erodeData[2]);
                result.Erode.Size = int.Parse(erodeData[3]);

                // Blure
                // "B:E:3:3" => ["B", "E", "3", "3"]
                var blureData = segments[3].Split(':');
                result.Blure.Enable = blureData[1] == "E";
                result.Blure.Iter = int.Parse(blureData[2]);
                result.Blure.Size = int.Parse(blureData[3]);


                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"L:{HUE.Min}, {Saturation.Min}, {Value.Min};U:{HUE.Max}, {Saturation.Max}, {Value.Max};{Erode};{Blure}";
        }
    }

    public struct MinMaxPair
    {
        public int Min;
        public int Max;
    }

    public struct ErodeSetup
    {
        public bool Enable;
        public int Iter;
        public int Size;

        public override string ToString()
        {
            if (Enable)
                return $"E:E:{Iter}:{Size}";
            else
                return $"E:D:{Iter}:{Size}";
        }
    }

    public struct BlureSetup
    {
        public bool Enable;
        public int Iter;
        public int Size;

        public override string ToString()
        {
            if (Enable)
                return $"B:E:{Iter}:{Size}";
            else
                return $"B:D:{Iter}:{Size}";
        }
    }
}
