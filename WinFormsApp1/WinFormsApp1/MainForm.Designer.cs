using WinFormsApp1.Properties;

namespace WinFormsApp1
{
	partial class WinFormsApp1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormsApp1));
			StartButton = new Button();
			richTextBox1 = new RichTextBox();
			buttonSettings = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			openFileDialog1 = new OpenFileDialog();
			pictureBox1 = new PictureBox();
			PassKeyButton = new Button();
			KeyPassTextBox1 = new TextBox();
			timeActivating = new Label();
			baf5_status = new Label();
			baf10_status = new Label();
			baf20_status = new Label();
			baf30_status = new Label();
			baf60_status = new Label();
			pictureBox5minRED = new PictureBox();
			pictureBox10minRED = new PictureBox();
			pictureBox20minRED = new PictureBox();
			pictureBox30minRED = new PictureBox();
			pictureBox60minRED = new PictureBox();
			pictureBox60minGREEN = new PictureBox();
			pictureBox30minGREEN = new PictureBox();
			pictureBox5minGREEN = new PictureBox();
			pictureBox10minGREEN = new PictureBox();
			pictureBox20minGREEN = new PictureBox();
			BAFlabel = new Label();
			bafff5_label = new Label();
			reset20mButton = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5minRED).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox10minRED).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox20minRED).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox30minRED).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox60minRED).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox60minGREEN).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox30minGREEN).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5minGREEN).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox10minGREEN).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox20minGREEN).BeginInit();
			SuspendLayout();
			// 
			// StartButton
			// 
			StartButton.Location = new Point(375, 253);
			StartButton.Name = "StartButton";
			StartButton.Size = new Size(122, 37);
			StartButton.TabIndex = 1;
			StartButton.Text = "Запустить";
			StartButton.UseVisualStyleBackColor = true;
			StartButton.Click += button2_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(12, 104);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(187, 142);
			richTextBox1.TabIndex = 10;
			richTextBox1.Text = "";
			richTextBox1.TextChanged += richTextBox1_TextChanged;
			// 
			// buttonSettings
			// 
			buttonSettings.Location = new Point(135, 253);
			buttonSettings.Name = "buttonSettings";
			buttonSettings.Size = new Size(130, 37);
			buttonSettings.TabIndex = 11;
			buttonSettings.Text = "Настройки";
			buttonSettings.UseVisualStyleBackColor = true;
			buttonSettings.Click += button1_Click_1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(63, 9);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 12;
			label1.Text = "Version";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(401, -1);
			label2.Name = "label2";
			label2.Size = new Size(38, 15);
			label2.TabIndex = 13;
			label2.Text = "label2";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 9);
			label3.Name = "label3";
			label3.Size = new Size(38, 15);
			label3.TabIndex = 14;
			label3.Text = "label3";
			label3.Click += label3_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.FileOk += openFileDialog1_FileOk;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Resources.photo_2024_01_06_00_46_591;
			pictureBox1.Location = new Point(256, 27);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(230, 219);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 18;
			pictureBox1.TabStop = false;
			// 
			// PassKeyButton
			// 
			PassKeyButton.Location = new Point(12, 27);
			PassKeyButton.Name = "PassKeyButton";
			PassKeyButton.Size = new Size(114, 23);
			PassKeyButton.TabIndex = 16;
			PassKeyButton.Text = "Ввести Ключ";
			PassKeyButton.UseVisualStyleBackColor = true;
			PassKeyButton.Click += PassKeyButton_Click;
			// 
			// KeyPassTextBox1
			// 
			KeyPassTextBox1.Location = new Point(151, 27);
			KeyPassTextBox1.Name = "KeyPassTextBox1";
			KeyPassTextBox1.Size = new Size(346, 23);
			KeyPassTextBox1.TabIndex = 17;
			KeyPassTextBox1.TextChanged += KeyPassTextBox1_TextChanged;
			// 
			// timeActivating
			// 
			timeActivating.AutoSize = true;
			timeActivating.Location = new Point(22, 269);
			timeActivating.Name = "timeActivating";
			timeActivating.Size = new Size(38, 15);
			timeActivating.TabIndex = 20;
			timeActivating.Text = "label4";
			timeActivating.Click += timeActivating_Click;
			// 
			// baf5_status
			// 
			baf5_status.AutoSize = true;
			baf5_status.Location = new Point(22, 56);
			baf5_status.Name = "baf5_status";
			baf5_status.Size = new Size(0, 15);
			baf5_status.TabIndex = 21;
			// 
			// baf10_status
			// 
			baf10_status.AutoSize = true;
			baf10_status.Location = new Point(16, 71);
			baf10_status.Name = "baf10_status";
			baf10_status.Size = new Size(45, 15);
			baf10_status.TabIndex = 22;
			baf10_status.Text = "10 мин";
			// 
			// baf20_status
			// 
			baf20_status.AutoSize = true;
			baf20_status.Location = new Point(16, 87);
			baf20_status.Name = "baf20_status";
			baf20_status.Size = new Size(45, 15);
			baf20_status.TabIndex = 23;
			baf20_status.Text = "20 мин";
			// 
			// baf30_status
			// 
			baf30_status.AutoSize = true;
			baf30_status.Location = new Point(97, 62);
			baf30_status.Name = "baf30_status";
			baf30_status.Size = new Size(45, 15);
			baf30_status.TabIndex = 24;
			baf30_status.Text = "30 мин";
			// 
			// baf60_status
			// 
			baf60_status.AutoSize = true;
			baf60_status.Location = new Point(95, 77);
			baf60_status.Name = "baf60_status";
			baf60_status.Size = new Size(45, 15);
			baf60_status.TabIndex = 25;
			baf60_status.Text = "60 мин";
			// 
			// pictureBox5minRED
			// 
			pictureBox5minRED.Image = Resources._1644968313_4_fikiwiki_com_p_kartinki_krasnii_kvadrat_4;
			pictureBox5minRED.Location = new Point(63, 59);
			pictureBox5minRED.Name = "pictureBox5minRED";
			pictureBox5minRED.Size = new Size(13, 12);
			pictureBox5minRED.TabIndex = 26;
			pictureBox5minRED.TabStop = false;
			// 
			// pictureBox10minRED
			// 
			pictureBox10minRED.Image = Resources._1644968313_4_fikiwiki_com_p_kartinki_krasnii_kvadrat_4;
			pictureBox10minRED.Location = new Point(63, 74);
			pictureBox10minRED.Name = "pictureBox10minRED";
			pictureBox10minRED.Size = new Size(13, 12);
			pictureBox10minRED.TabIndex = 27;
			pictureBox10minRED.TabStop = false;
			// 
			// pictureBox20minRED
			// 
			pictureBox20minRED.Image = Resources._1644968313_4_fikiwiki_com_p_kartinki_krasnii_kvadrat_4;
			pictureBox20minRED.Location = new Point(63, 89);
			pictureBox20minRED.Name = "pictureBox20minRED";
			pictureBox20minRED.Size = new Size(13, 12);
			pictureBox20minRED.TabIndex = 28;
			pictureBox20minRED.TabStop = false;
			// 
			// pictureBox30minRED
			// 
			pictureBox30minRED.Image = Resources._1644968313_4_fikiwiki_com_p_kartinki_krasnii_kvadrat_4;
			pictureBox30minRED.Location = new Point(148, 62);
			pictureBox30minRED.Name = "pictureBox30minRED";
			pictureBox30minRED.Size = new Size(13, 12);
			pictureBox30minRED.TabIndex = 29;
			pictureBox30minRED.TabStop = false;
			// 
			// pictureBox60minRED
			// 
			pictureBox60minRED.Image = Resources._1644968313_4_fikiwiki_com_p_kartinki_krasnii_kvadrat_4;
			pictureBox60minRED.Location = new Point(148, 80);
			pictureBox60minRED.Name = "pictureBox60minRED";
			pictureBox60minRED.Size = new Size(13, 12);
			pictureBox60minRED.TabIndex = 30;
			pictureBox60minRED.TabStop = false;
			// 
			// pictureBox60minGREEN
			// 
			pictureBox60minGREEN.Image = Resources.channels4_profile;
			pictureBox60minGREEN.Location = new Point(148, 80);
			pictureBox60minGREEN.Name = "pictureBox60minGREEN";
			pictureBox60minGREEN.Size = new Size(14, 13);
			pictureBox60minGREEN.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox60minGREEN.TabIndex = 31;
			pictureBox60minGREEN.TabStop = false;
			// 
			// pictureBox30minGREEN
			// 
			pictureBox30minGREEN.Image = Resources.channels4_profile;
			pictureBox30minGREEN.Location = new Point(148, 62);
			pictureBox30minGREEN.Name = "pictureBox30minGREEN";
			pictureBox30minGREEN.Size = new Size(14, 12);
			pictureBox30minGREEN.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox30minGREEN.TabIndex = 32;
			pictureBox30minGREEN.TabStop = false;
			// 
			// pictureBox5minGREEN
			// 
			pictureBox5minGREEN.Image = Resources.channels4_profile;
			pictureBox5minGREEN.Location = new Point(63, 59);
			pictureBox5minGREEN.Name = "pictureBox5minGREEN";
			pictureBox5minGREEN.Size = new Size(13, 12);
			pictureBox5minGREEN.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5minGREEN.TabIndex = 33;
			pictureBox5minGREEN.TabStop = false;
			// 
			// pictureBox10minGREEN
			// 
			pictureBox10minGREEN.Image = Resources.channels4_profile;
			pictureBox10minGREEN.Location = new Point(63, 74);
			pictureBox10minGREEN.Name = "pictureBox10minGREEN";
			pictureBox10minGREEN.Size = new Size(13, 12);
			pictureBox10minGREEN.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox10minGREEN.TabIndex = 34;
			pictureBox10minGREEN.TabStop = false;
			// 
			// pictureBox20minGREEN
			// 
			pictureBox20minGREEN.Image = Resources.channels4_profile;
			pictureBox20minGREEN.Location = new Point(63, 89);
			pictureBox20minGREEN.Name = "pictureBox20minGREEN";
			pictureBox20minGREEN.Size = new Size(13, 13);
			pictureBox20minGREEN.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox20minGREEN.TabIndex = 35;
			pictureBox20minGREEN.TabStop = false;
			// 
			// BAFlabel
			// 
			BAFlabel.AutoSize = true;
			BAFlabel.Location = new Point(22, 35);
			BAFlabel.Name = "BAFlabel";
			BAFlabel.Size = new Size(38, 15);
			BAFlabel.TabIndex = 36;
			BAFlabel.Text = "Бафы";
			// 
			// bafff5_label
			// 
			bafff5_label.AutoSize = true;
			bafff5_label.Location = new Point(22, 56);
			bafff5_label.Name = "bafff5_label";
			bafff5_label.Size = new Size(39, 15);
			bafff5_label.TabIndex = 37;
			bafff5_label.Text = "5 мин";
			// 
			// reset20mButton
			// 
			reset20mButton.Location = new Point(271, 251);
			reset20mButton.Name = "reset20mButton";
			reset20mButton.Size = new Size(98, 39);
			reset20mButton.TabIndex = 38;
			reset20mButton.Text = "Рестарт   20мин баф";
			reset20mButton.UseVisualStyleBackColor = true;
			reset20mButton.Click += reset20mButton_Click;
			// 
			// WinFormsApp1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonHighlight;
			ClientSize = new Size(522, 301);
			Controls.Add(reset20mButton);
			Controls.Add(bafff5_label);
			Controls.Add(BAFlabel);
			Controls.Add(pictureBox20minGREEN);
			Controls.Add(pictureBox10minGREEN);
			Controls.Add(pictureBox5minGREEN);
			Controls.Add(pictureBox30minGREEN);
			Controls.Add(pictureBox60minGREEN);
			Controls.Add(pictureBox60minRED);
			Controls.Add(pictureBox30minRED);
			Controls.Add(pictureBox20minRED);
			Controls.Add(pictureBox10minRED);
			Controls.Add(pictureBox5minRED);
			Controls.Add(baf60_status);
			Controls.Add(baf30_status);
			Controls.Add(baf20_status);
			Controls.Add(baf10_status);
			Controls.Add(baf5_status);
			Controls.Add(timeActivating);
			Controls.Add(KeyPassTextBox1);
			Controls.Add(PassKeyButton);
			Controls.Add(pictureBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(buttonSettings);
			Controls.Add(richTextBox1);
			Controls.Add(StartButton);
			ForeColor = SystemColors.ActiveCaptionText;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "WinFormsApp1";
			Text = "R2Sound";
			TransparencyKey = Color.FromArgb(255, 128, 0);
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5minRED).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox10minRED).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox20minRED).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox30minRED).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox60minRED).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox60minGREEN).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox30minGREEN).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5minGREEN).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox10minGREEN).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox20minGREEN).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button StartButton;
		private CheckedListBox checkedListBox1;
		private RichTextBox richTextBox1;
		private Button buttonSettings;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private OpenFileDialog openFileDialog1;
		private PictureBox pictureBox1;
		private Button PassKeyButton;
		private TextBox KeyPassTextBox1;
		private Label timeActivating;
		private Label baf5_status;
		private Label baf10_status;
		private Label baf20_status;
		private Label baf30_status;
		private Label baf60_status;
		private PictureBox pictureBox5minRED;
		private PictureBox pictureBox10minRED;
		private PictureBox pictureBox20minRED;
		private PictureBox pictureBox30minRED;
		private PictureBox pictureBox60minRED;
		private PictureBox pictureBox60minGREEN;
		private PictureBox pictureBox30minGREEN;
		private PictureBox pictureBox5minGREEN;
		private PictureBox pictureBox10minGREEN;
		private PictureBox pictureBox20minGREEN;
		private Label BAFlabel;
		private Label bafff5_label;
		private Button reset20mButton;
	}
}