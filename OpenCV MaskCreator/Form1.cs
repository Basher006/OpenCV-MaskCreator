using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace OpenCV_MaskCreator
{
    public partial class Form1 : Form
    {
        private readonly string[] ALLOW_IMG_FILE_FORMATS = { "png", "jpg" };
        private Bitmap? LoadedImage_bitmap;
        private Mat? LoadedImage_mat;
        private Mat? LoadedImage_matHSV;
        private Bitmap? Mask;
        private GUIData data;

        public Form1()
        {
            InitializeComponent();
            LoadedImage_bitmap = new Bitmap(pictureBox1.BackgroundImage);

            if (!GUIData.TryParse("L:0, 0, 0;U:255, 255, 255;E:D:1:3;B:D:3:3", out data))
                data = new();
            OnDataUpdate();

            tableLayoutPanel1.AllowDrop = true;
            pictureBox3.Location = new(0, 0);
            pictureBox3.Size = new(Size.Width, Size.Height - 39);

            pictureBox3.BringToFront();
        }

        private void OnDataUpdate()
        {
            textBox1.Text = data.ToString();

            Mask?.Dispose();
            Mask = OpenCV.GetMask(LoadedImage_matHSV, data);
            if (Mask != null)
                pictureBox2.BackgroundImage = Mask;
        }

        private bool IsAllowDataFormat(string filePath)
        {
            var strings = filePath.Split('.');
            if (strings.Length > 0)
            {
                if (ALLOW_IMG_FILE_FORMATS.Contains(strings.Last()))
                    return true;
            }

            return false;
        }

        private void LoadImageToPicturebox1(string filePath)
        {
            // clear mem
            LoadedImage_bitmap?.Dispose();
            LoadedImage_mat?.Dispose();
            LoadedImage_matHSV?.Dispose();

            LoadedImage_bitmap = new(filePath);
            LoadedImage_mat = LoadedImage_bitmap.ToMat();
            LoadedImage_matHSV = new();
            Cv2.CvtColor(LoadedImage_mat, LoadedImage_matHSV, ColorConversionCodes.BGR2HSV);
            pictureBox1.BackgroundImage = LoadedImage_bitmap;

            OnDataUpdate();
        }

        private void UpdateGUI()
        {
            HUEMin_trakBar.Value = data.HUE.Min;
            HUEMax_trakBar.Value = data.HUE.Max;
            HUEMin_upDown.Value = data.HUE.Min;
            HUEMax_upDown.Value = data.HUE.Max;

            SatMin_trakBar.Value = data.Saturation.Min;
            SatMax_trakBar.Value = data.Saturation.Max;
            SatMin_upDown.Value = data.Saturation.Min;
            SatMax_upDown.Value = data.Saturation.Max;

            ValMin_trakBar.Value = data.Value.Min;
            ValMax_trakBar.Value = data.Value.Max;
            ValMin_upDown.Value = data.Value.Min;
            ValMax_upDown.Value = data.Value.Max;

            Erode_chekBox.Checked = data.Erode.Enable;
            ErodeIter_upDown.Value = data.Erode.Iter;
            ErodeSize_upDown.Value = data.Erode.Size;

            Blure_chekBox.Checked = data.Blure.Enable;
            BlureIter_upDown.Value = data.Blure.Iter;
            BlureSize_upDown.Value = data.Blure.Size;
        }

        #region GUI CALLBACKS

        private void tableLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (IsAllowDataFormat(files[0]))
            {
                LoadImageToPicturebox1(files[0]);
            }
        }

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (IsAllowDataFormat(files[0]))
                {
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = pictureBox1.BackgroundImage;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = pictureBox2.BackgroundImage;
            pictureBox3.Visible = true;
        }

        private void Openfile_button_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Imgs (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadImageToPicturebox1(openFileDialog.FileName);
            }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            if (!GUIData.TryParse("L:0, 0, 0;U:255, 255, 255;E:D:1:3;B:D:3:3", out data))
                data = new();
            UpdateGUI();
            OnDataUpdate();
        }

        private void Parse_button_Click(object sender, EventArgs e)
        {
            if (GUIData.TryParse(textBox1.Text, out GUIData tempData))
            {
                data = tempData;
                UpdateGUI();
                OnDataUpdate();
            }
            else
                MessageBox.Show("Wrong parsing data!", "Error when parse", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Mask != null)
                Mask = new(pictureBox2.BackgroundImage);


            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.FileName = "Mask.png";
            saveFileDialog.Filter = "png|*.png|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Mask.Save(saveFileDialog.FileName);
            }
        }


        #region DATA GUI CALLBACKS
        //
        // HUE
        //
        private void HUEMin_trakBar_Scroll(object sender, EventArgs e)
        {
            if (HUEMin_upDown.Value != HUEMin_trakBar.Value)
                HUEMin_upDown.Value = HUEMin_trakBar.Value;

            if (HUEMax_trakBar.Value < HUEMin_trakBar.Value)
                HUEMax_trakBar.Value = HUEMin_trakBar.Value;

            data.HUE.Min = HUEMin_trakBar.Value;
            OnDataUpdate();
        }

        private void HUEMax_trakBar_Scroll(object sender, EventArgs e)
        {
            if (HUEMax_upDown.Value != HUEMax_trakBar.Value)
                HUEMax_upDown.Value = HUEMax_trakBar.Value;

            if (HUEMin_trakBar.Value > HUEMax_trakBar.Value)
                HUEMin_trakBar.Value = HUEMax_trakBar.Value;

            data.HUE.Max = HUEMax_trakBar.Value;
            OnDataUpdate();
        }

        private void HUEMin_upDown_ValueChanged(object sender, EventArgs e)
        {
            if (HUEMin_trakBar.Value != HUEMin_upDown.Value)
                HUEMin_trakBar.Value = (int)HUEMin_upDown.Value;

            if (HUEMax_upDown.Value < HUEMin_upDown.Value)
                HUEMax_upDown.Value = HUEMin_upDown.Value;

            data.HUE.Min = (int)HUEMin_upDown.Value;
            OnDataUpdate();
        }

        private void HUEMax_upDown_ValueChanged(object sender, EventArgs e)
        {
            if (HUEMax_trakBar.Value != HUEMax_upDown.Value)
                HUEMax_trakBar.Value = (int)HUEMax_upDown.Value;

            if (HUEMin_upDown.Value > HUEMax_upDown.Value)
                HUEMin_upDown.Value = HUEMax_upDown.Value;

            data.HUE.Max = (int)HUEMax_upDown.Value;
            OnDataUpdate();
        }

        //
        // Saturation
        //
        private void SatMin_trakBar_Scroll(object sender, EventArgs e)
        {
            if (SatMin_upDown.Value != SatMin_trakBar.Value)
                SatMin_upDown.Value = SatMin_trakBar.Value;

            if (SatMax_trakBar.Value < SatMin_trakBar.Value)
                SatMax_trakBar.Value = SatMin_trakBar.Value;

            data.Saturation.Min = SatMin_trakBar.Value;
            OnDataUpdate();
        }

        private void SatMax_trakBar_Scroll(object sender, EventArgs e)
        {
            if (SatMax_upDown.Value != SatMax_trakBar.Value)
                SatMax_upDown.Value = SatMax_trakBar.Value;

            if (SatMin_trakBar.Value > SatMax_trakBar.Value)
                SatMin_trakBar.Value = SatMax_trakBar.Value;

            data.Saturation.Max = SatMax_trakBar.Value;
            OnDataUpdate();
        }

        private void SatMin_upDown_ValueChanged(object sender, EventArgs e)
        {
            if (SatMin_trakBar.Value != SatMin_upDown.Value)
                SatMin_trakBar.Value = (int)SatMin_upDown.Value;

            if (SatMax_upDown.Value < SatMin_upDown.Value)
                SatMax_upDown.Value = SatMin_upDown.Value;

            data.Saturation.Min = (int)SatMin_upDown.Value;
            OnDataUpdate();
        }

        private void SatMax_upDown_ValueChanged(object sender, EventArgs e)
        {
            if (SatMax_trakBar.Value != SatMax_upDown.Value)
                SatMax_trakBar.Value = (int)SatMax_upDown.Value;

            if (SatMin_upDown.Value > SatMax_upDown.Value)
                SatMin_upDown.Value = SatMax_upDown.Value;

            data.Saturation.Max = (int)SatMax_upDown.Value;
            OnDataUpdate();
        }

        //
        // Value
        //
        private void ValMin_trakBar_Scroll(object sender, EventArgs e)
        {
            if (ValMin_upDown.Value != ValMin_trakBar.Value)
                ValMin_upDown.Value = ValMin_trakBar.Value;

            if (ValMax_trakBar.Value < ValMin_trakBar.Value)
                ValMax_trakBar.Value = ValMin_trakBar.Value;

            data.Value.Min = ValMin_trakBar.Value;
            OnDataUpdate();
        }

        private void ValMax_trakBar_Scroll(object sender, EventArgs e)
        {
            if (ValMax_upDown.Value != ValMax_trakBar.Value)
                ValMax_upDown.Value = ValMax_trakBar.Value;

            if (ValMin_trakBar.Value > ValMax_trakBar.Value)
                ValMin_trakBar.Value = ValMax_trakBar.Value;

            data.Value.Max = ValMax_trakBar.Value;
            OnDataUpdate();
        }

        private void ValMin_upDown_ValueChanged(object sender, EventArgs e)
        {
            if (ValMin_trakBar.Value != ValMin_upDown.Value)
                ValMin_trakBar.Value = (int)ValMin_upDown.Value;

            if (ValMax_upDown.Value < ValMin_upDown.Value)
                ValMax_upDown.Value = ValMin_upDown.Value;

            data.Value.Min = (int)ValMin_upDown.Value;
            OnDataUpdate();
        }

        private void ValMax_upDown_ValueChanged(object sender, EventArgs e)
        {
            if (ValMax_trakBar.Value != ValMax_upDown.Value)
                ValMax_trakBar.Value = (int)ValMax_upDown.Value;

            if (ValMin_upDown.Value > ValMax_upDown.Value)
                ValMin_upDown.Value = ValMax_upDown.Value;

            data.Value.Max = (int)ValMax_upDown.Value;
            OnDataUpdate();
        }

        //
        // Erode
        //
        private void Erode_chekBox_CheckedChanged(object sender, EventArgs e)
        {
            data.Erode.Enable = Erode_chekBox.Checked;
            //data.Erode.Iter = (int)ErodeIter_upDown.Value;
            //data.Erode.Size = (int)ErodeSize_upDown.Value;
            OnDataUpdate();
        }

        private void ErodeIter_upDown_ValueChanged(object sender, EventArgs e)
        {
            data.Erode.Iter = (int)ErodeIter_upDown.Value;
            OnDataUpdate();
        }

        private void ErodeSize_upDown_ValueChanged(object sender, EventArgs e)
        {
            data.Erode.Size = (int)ErodeSize_upDown.Value;
            OnDataUpdate();
        }

        //
        // Blure
        //
        private void Blure_chekBox_CheckedChanged(object sender, EventArgs e)
        {
            data.Blure.Enable = Blure_chekBox.Checked;
            //data.Blure.Iter = (int)BlureIter_upDown.Value;
            //data.Blure.Size = (int)BlureSize_upDown.Value;
            OnDataUpdate();
        }

        private void BlureStrong_upDown_ValueChanged(object sender, EventArgs e)
        {
            data.Blure.Iter = (int)BlureIter_upDown.Value;
            OnDataUpdate();
        }

        private void BlureSize_upDown_ValueChanged(object sender, EventArgs e)
        {
            data.Blure.Size = (int)BlureSize_upDown.Value;
            OnDataUpdate();
        }
        #endregion DATA GUI CALLBACKS


        #endregion GUI CALLBACKS


    }
}
