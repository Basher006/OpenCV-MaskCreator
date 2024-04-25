namespace OpenCV_MaskCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            HUEMin_trakBar = new TrackBar();
            HUEMin_upDown = new NumericUpDown();
            groupBox1 = new GroupBox();
            HUEMax_upDown = new NumericUpDown();
            label2 = new Label();
            HUEMax_trakBar = new TrackBar();
            groupBox4 = new GroupBox();
            BlureSize_upDown = new NumericUpDown();
            label9 = new Label();
            BlureIter_upDown = new NumericUpDown();
            label10 = new Label();
            Blure_chekBox = new CheckBox();
            ErodeSize_upDown = new NumericUpDown();
            label8 = new Label();
            ErodeIter_upDown = new NumericUpDown();
            label7 = new Label();
            Erode_chekBox = new CheckBox();
            textBox1 = new TextBox();
            button1 = new Button();
            Save_button = new Button();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            SatMax_upDown = new NumericUpDown();
            label3 = new Label();
            SatMax_trakBar = new TrackBar();
            SatMin_upDown = new NumericUpDown();
            label4 = new Label();
            SatMin_trakBar = new TrackBar();
            groupBox3 = new GroupBox();
            ValMax_upDown = new NumericUpDown();
            label5 = new Label();
            ValMax_trakBar = new TrackBar();
            ValMin_upDown = new NumericUpDown();
            label6 = new Label();
            ValMin_trakBar = new TrackBar();
            pictureBox3 = new PictureBox();
            Openfile_button = new Button();
            button2 = new Button();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HUEMin_trakBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HUEMin_upDown).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HUEMax_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HUEMax_trakBar).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BlureSize_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlureIter_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErodeSize_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErodeIter_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SatMax_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SatMax_trakBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SatMin_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SatMin_trakBar).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ValMax_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValMax_trakBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValMin_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValMin_trakBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.OpenImgFile;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 24);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Min";
            // 
            // HUEMin_trakBar
            // 
            HUEMin_trakBar.AutoSize = false;
            HUEMin_trakBar.Location = new Point(43, 22);
            HUEMin_trakBar.Maximum = 255;
            HUEMin_trakBar.Name = "HUEMin_trakBar";
            HUEMin_trakBar.Size = new Size(229, 21);
            HUEMin_trakBar.TabIndex = 3;
            HUEMin_trakBar.TickStyle = TickStyle.None;
            HUEMin_trakBar.Scroll += HUEMin_trakBar_Scroll;
            // 
            // HUEMin_upDown
            // 
            HUEMin_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HUEMin_upDown.Location = new Point(278, 21);
            HUEMin_upDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            HUEMin_upDown.Name = "HUEMin_upDown";
            HUEMin_upDown.Size = new Size(63, 23);
            HUEMin_upDown.TabIndex = 4;
            HUEMin_upDown.ValueChanged += HUEMin_upDown_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(HUEMax_upDown);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(HUEMax_trakBar);
            groupBox1.Controls.Add(HUEMin_upDown);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(HUEMin_trakBar);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 76);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "HUE";
            // 
            // HUEMax_upDown
            // 
            HUEMax_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HUEMax_upDown.Location = new Point(278, 48);
            HUEMax_upDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            HUEMax_upDown.Name = "HUEMax_upDown";
            HUEMax_upDown.Size = new Size(63, 23);
            HUEMax_upDown.TabIndex = 7;
            HUEMax_upDown.Value = new decimal(new int[] { 255, 0, 0, 0 });
            HUEMax_upDown.ValueChanged += HUEMax_upDown_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 51);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Max";
            // 
            // HUEMax_trakBar
            // 
            HUEMax_trakBar.AutoSize = false;
            HUEMax_trakBar.Location = new Point(43, 49);
            HUEMax_trakBar.Maximum = 255;
            HUEMax_trakBar.Name = "HUEMax_trakBar";
            HUEMax_trakBar.Size = new Size(229, 21);
            HUEMax_trakBar.TabIndex = 6;
            HUEMax_trakBar.TickStyle = TickStyle.None;
            HUEMax_trakBar.Value = 255;
            HUEMax_trakBar.Scroll += HUEMax_trakBar_Scroll;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox4.Controls.Add(BlureSize_upDown);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(BlureIter_upDown);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(Blure_chekBox);
            groupBox4.Controls.Add(ErodeSize_upDown);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(ErodeIter_upDown);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(Erode_chekBox);
            groupBox4.Location = new Point(382, 296);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(304, 71);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Extra";
            // 
            // BlureSize_upDown
            // 
            BlureSize_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BlureSize_upDown.Location = new Point(225, 42);
            BlureSize_upDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            BlureSize_upDown.Name = "BlureSize_upDown";
            BlureSize_upDown.Size = new Size(63, 23);
            BlureSize_upDown.TabIndex = 15;
            BlureSize_upDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            BlureSize_upDown.ValueChanged += BlureSize_upDown_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(197, 45);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 14;
            label9.Text = "Size";
            // 
            // BlureIter_upDown
            // 
            BlureIter_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BlureIter_upDown.Location = new Point(112, 42);
            BlureIter_upDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            BlureIter_upDown.Name = "BlureIter_upDown";
            BlureIter_upDown.Size = new Size(63, 23);
            BlureIter_upDown.TabIndex = 13;
            BlureIter_upDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            BlureIter_upDown.ValueChanged += BlureStrong_upDown_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(84, 45);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 12;
            label10.Text = "Iter:";
            // 
            // Blure_chekBox
            // 
            Blure_chekBox.AutoSize = true;
            Blure_chekBox.Location = new Point(6, 44);
            Blure_chekBox.Name = "Blure_chekBox";
            Blure_chekBox.Size = new Size(50, 19);
            Blure_chekBox.TabIndex = 11;
            Blure_chekBox.Text = "Bure";
            Blure_chekBox.UseVisualStyleBackColor = true;
            Blure_chekBox.CheckedChanged += Blure_chekBox_CheckedChanged;
            // 
            // ErodeSize_upDown
            // 
            ErodeSize_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ErodeSize_upDown.Location = new Point(225, 15);
            ErodeSize_upDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ErodeSize_upDown.Name = "ErodeSize_upDown";
            ErodeSize_upDown.Size = new Size(63, 23);
            ErodeSize_upDown.TabIndex = 10;
            ErodeSize_upDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            ErodeSize_upDown.ValueChanged += ErodeSize_upDown_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(197, 20);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 9;
            label8.Text = "Size";
            // 
            // ErodeIter_upDown
            // 
            ErodeIter_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ErodeIter_upDown.Location = new Point(112, 15);
            ErodeIter_upDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ErodeIter_upDown.Name = "ErodeIter_upDown";
            ErodeIter_upDown.Size = new Size(63, 23);
            ErodeIter_upDown.TabIndex = 8;
            ErodeIter_upDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            ErodeIter_upDown.ValueChanged += ErodeIter_upDown_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 20);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 1;
            label7.Text = "Iter:";
            // 
            // Erode_chekBox
            // 
            Erode_chekBox.AutoSize = true;
            Erode_chekBox.Location = new Point(6, 19);
            Erode_chekBox.Name = "Erode_chekBox";
            Erode_chekBox.Size = new Size(56, 19);
            Erode_chekBox.TabIndex = 0;
            Erode_chekBox.Text = "Erode";
            Erode_chekBox.UseVisualStyleBackColor = true;
            Erode_chekBox.CheckedChanged += Erode_chekBox_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(382, 506);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "\"L:0, 0, 0;U:255, 255, 255;E:D:1:3;B:D:3:3\"";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(643, 506);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Parse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Parse_button_Click;
            // 
            // Save_button
            // 
            Save_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Save_button.BackColor = Color.LightGreen;
            Save_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Save_button.Location = new Point(803, 302);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(112, 39);
            Save_button.TabIndex = 13;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = false;
            Save_button.Click += Save_button_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImage = Properties.Resources.OpenImgFile;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(457, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(449, 272);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(909, 278);
            tableLayoutPanel1.TabIndex = 15;
            tableLayoutPanel1.DragDrop += tableLayoutPanel1_DragDrop;
            tableLayoutPanel1.DragEnter += tableLayoutPanel1_DragEnter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(SatMax_upDown);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(SatMax_trakBar);
            groupBox2.Controls.Add(SatMin_upDown);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(SatMin_trakBar);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 373);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 76);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Saturation";
            // 
            // SatMax_upDown
            // 
            SatMax_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SatMax_upDown.Location = new Point(278, 48);
            SatMax_upDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            SatMax_upDown.Name = "SatMax_upDown";
            SatMax_upDown.Size = new Size(63, 23);
            SatMax_upDown.TabIndex = 7;
            SatMax_upDown.Value = new decimal(new int[] { 255, 0, 0, 0 });
            SatMax_upDown.ValueChanged += SatMax_upDown_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 51);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Max";
            // 
            // SatMax_trakBar
            // 
            SatMax_trakBar.AutoSize = false;
            SatMax_trakBar.Location = new Point(43, 49);
            SatMax_trakBar.Maximum = 255;
            SatMax_trakBar.Name = "SatMax_trakBar";
            SatMax_trakBar.Size = new Size(229, 21);
            SatMax_trakBar.TabIndex = 6;
            SatMax_trakBar.TickStyle = TickStyle.None;
            SatMax_trakBar.Value = 255;
            SatMax_trakBar.Scroll += SatMax_trakBar_Scroll;
            // 
            // SatMin_upDown
            // 
            SatMin_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SatMin_upDown.Location = new Point(278, 21);
            SatMin_upDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            SatMin_upDown.Name = "SatMin_upDown";
            SatMin_upDown.Size = new Size(63, 23);
            SatMin_upDown.TabIndex = 4;
            SatMin_upDown.ValueChanged += SatMin_upDown_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 24);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 2;
            label4.Text = "Min";
            // 
            // SatMin_trakBar
            // 
            SatMin_trakBar.AutoSize = false;
            SatMin_trakBar.Location = new Point(43, 22);
            SatMin_trakBar.Maximum = 256;
            SatMin_trakBar.Name = "SatMin_trakBar";
            SatMin_trakBar.Size = new Size(229, 21);
            SatMin_trakBar.TabIndex = 3;
            SatMin_trakBar.TickStyle = TickStyle.None;
            SatMin_trakBar.Scroll += SatMin_trakBar_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(ValMax_upDown);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(ValMax_trakBar);
            groupBox3.Controls.Add(ValMin_upDown);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(ValMin_trakBar);
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 455);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(355, 76);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Value";
            // 
            // ValMax_upDown
            // 
            ValMax_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ValMax_upDown.Location = new Point(278, 48);
            ValMax_upDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ValMax_upDown.Name = "ValMax_upDown";
            ValMax_upDown.Size = new Size(63, 23);
            ValMax_upDown.TabIndex = 7;
            ValMax_upDown.Value = new decimal(new int[] { 255, 0, 0, 0 });
            ValMax_upDown.ValueChanged += ValMax_upDown_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 51);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 5;
            label5.Text = "Max";
            // 
            // ValMax_trakBar
            // 
            ValMax_trakBar.AutoSize = false;
            ValMax_trakBar.Location = new Point(43, 49);
            ValMax_trakBar.Maximum = 255;
            ValMax_trakBar.Name = "ValMax_trakBar";
            ValMax_trakBar.Size = new Size(229, 21);
            ValMax_trakBar.TabIndex = 6;
            ValMax_trakBar.TickStyle = TickStyle.None;
            ValMax_trakBar.Value = 255;
            ValMax_trakBar.Scroll += ValMax_trakBar_Scroll;
            // 
            // ValMin_upDown
            // 
            ValMin_upDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ValMin_upDown.Location = new Point(278, 21);
            ValMin_upDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            ValMin_upDown.Name = "ValMin_upDown";
            ValMin_upDown.Size = new Size(63, 23);
            ValMin_upDown.TabIndex = 4;
            ValMin_upDown.ValueChanged += ValMin_upDown_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(9, 24);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 2;
            label6.Text = "Min";
            // 
            // ValMin_trakBar
            // 
            ValMin_trakBar.AutoSize = false;
            ValMin_trakBar.Location = new Point(43, 22);
            ValMin_trakBar.Maximum = 255;
            ValMin_trakBar.Name = "ValMin_trakBar";
            ValMin_trakBar.Size = new Size(229, 21);
            ValMin_trakBar.TabIndex = 3;
            ValMin_trakBar.TickStyle = TickStyle.None;
            ValMin_trakBar.Scroll += ValMin_trakBar_Scroll;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(620, 411);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Openfile_button
            // 
            Openfile_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Openfile_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Openfile_button.Location = new Point(803, 491);
            Openfile_button.Name = "Openfile_button";
            Openfile_button.Size = new Size(112, 39);
            Openfile_button.TabIndex = 17;
            Openfile_button.Text = "Open";
            Openfile_button.UseVisualStyleBackColor = true;
            Openfile_button.Click += Openfile_button_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.LightCoral;
            button2.Location = new Point(692, 302);
            button2.Name = "button2";
            button2.Size = new Size(109, 39);
            button2.TabIndex = 18;
            button2.Text = "Reset all";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Reset_button_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(444, 421);
            label11.Name = "label11";
            label11.Size = new Size(145, 15);
            label11.TabIndex = 19;
            label11.Text = "This is hidden picture box ";
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(444, 436);
            label12.Name = "label12";
            label12.Size = new Size(174, 15);
            label12.TabIndex = 20;
            label12.Text = "Im use it for zoom feature ---->";
            label12.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 537);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(Openfile_button);
            Controls.Add(pictureBox3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Save_button);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            MinimumSize = new Size(942, 576);
            Name = "Form1";
            Text = "OpenCV Mask Creator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HUEMin_trakBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)HUEMin_upDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HUEMax_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)HUEMax_trakBar).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BlureSize_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlureIter_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErodeSize_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErodeIter_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SatMax_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SatMax_trakBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SatMin_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SatMin_trakBar).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ValMax_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValMax_trakBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValMin_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValMin_trakBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TrackBar HUEMin_trakBar;
        private NumericUpDown HUEMin_upDown;
        private GroupBox groupBox1;
        private NumericUpDown HUEMax_upDown;
        private Label label2;
        private TrackBar HUEMax_trakBar;
        private GroupBox groupBox4;
        private NumericUpDown BlureSize_upDown;
        private Label label9;
        private NumericUpDown BlureIter_upDown;
        private Label label10;
        private CheckBox Blure_chekBox;
        private NumericUpDown ErodeSize_upDown;
        private Label label8;
        private NumericUpDown ErodeIter_upDown;
        private Label label7;
        private CheckBox Erode_chekBox;
        private TextBox textBox1;
        private Button button1;
        private Button Save_button;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private NumericUpDown SatMax_upDown;
        private Label label3;
        private TrackBar SatMax_trakBar;
        private NumericUpDown SatMin_upDown;
        private Label label4;
        private TrackBar SatMin_trakBar;
        private GroupBox groupBox3;
        private NumericUpDown ValMax_upDown;
        private Label label5;
        private TrackBar ValMax_trakBar;
        private NumericUpDown ValMin_upDown;
        private Label label6;
        private TrackBar ValMin_trakBar;
        private Button Openfile_button;
        private PictureBox pictureBox3;
        private Button button2;
        private Label label11;
        private Label label12;
    }
}
