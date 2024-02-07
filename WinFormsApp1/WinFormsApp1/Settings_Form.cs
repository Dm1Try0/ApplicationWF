namespace WinFormsApp1
{
	public partial class Settings_Form : Form
	{
		SettingsData _settings = null;
		public Settings_Form()
		{
			InitializeComponent();
			_settings = SettingsData.GetSettings();
			_initControlls();
		}
		private void _initControlls()
		{
			//надо проинициализировать все кнопки
			switch (_settings.ShopBaf)
			{
				case true: button1.Text = "Включено"; break;
				case false: button1.Text = "Выключено"; break;
			}
			switch (_settings.Baf20)
			{
				case true: button2.Text = "Включено"; break;
				case false: button2.Text = "Выключено"; break;
			}
			switch (_settings.Baf30)
			{
				case true: button3.Text = "Включено"; break;
				case false: button3.Text = "Выключено"; break;
			}
			switch (_settings.Baf60)
			{
				case true: button4.Text = "Включено"; break;
				case false: button4.Text = "Выключено"; break;
			}
			switch (_settings.Baf5)
			{
				case true: Baf5buttonOnOff.Text = "Включено"; break;
				case false: Baf5buttonOnOff.Text = "Выключено"; break;
			}


		}

		private void Settings_Form_Load(object sender, EventArgs e)
		{

			label1.Text = "@r2soundAdmin";
			buttonSaveSettings.Text = "Сохранить настройки";
			label7.Visible = false;
			label1.ForeColor = Color.BlueViolet;
			label4.ForeColor = Color.BlueViolet;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			switch (button1.Text)
			{
				case "Включено":
					button1.Text = "Выключено";
					_settings.ShopBaf = false;
					break;
				case "Выключено":
					_settings.ShopBaf = true;
					button1.Text = "Включено";
					break;
				default: break;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			switch (button2.Text)
			{
				case "Включено":
					button2.Text = "Выключено";
					_settings.Baf20 = false;
					break;
				case "Выключено":
					_settings.Baf20 = true;
					button2.Text = "Включено";
					break;
				default: break;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			switch (button3.Text)
			{
				case "Включено":
					button3.Text = "Выключено";
					_settings.Baf30 = false;
					break;
				case "Выключено":
					_settings.Baf30 = true;
					button3.Text = "Включено";
					break;
				default: break;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			switch (button4.Text)
			{
				case "Включено":
					button4.Text = "Выключено";
					_settings.Baf60 = false;
					break;
				case "Выключено":
					_settings.Baf60 = true;
					button4.Text = "Включено";
					break;
				default: break;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			_settings.Save();
			label7.Visible = true;
			label7.ForeColor = System.Drawing.Color.Green;
			label7.Text = "Настройки сохранены";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			_settings.Baf5 = false;
			_settings.ShopBaf = false;
			_settings.Baf20 = false;
			_settings.Baf30 = false;
			_settings.Baf60 = false;
			_settings.Baf5_file = null;
			_settings.Baf20_file = null;
			_settings.Baf30_file = null;
			_settings.Baf60_file = null;
			_settings.ShopBaf_file = null;
			baf5file_label.Text = "Файл: По умолчанию";
			fileShop.Text = "Файл: По умолчанию";
			filebaf20.Text = "Файл: По умолчанию";
			filebaf30.Text = "Файл: По умолчанию";
			filebaf60.Text = "Файл: По умолчанию";
			button1.Text = "Выключено";
			button2.Text = "Выключено";
			button3.Text = "Выключено";
			button4.Text = "Выключено";
			Baf5buttonOnOff.Text = "Выключено";

			label7.ForeColor = System.Drawing.Color.Red;
			label7.Visible = true;
			label7.Text = "Настройки сброшены";
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			WinFormsApp1 main = new WinFormsApp1();
			main.Show();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void filebaf20_Click(object sender, EventArgs e)
		{

		}

		private void filebaf30_Click(object sender, EventArgs e)
		{

		}

		private void filebaf60_Click(object sender, EventArgs e)
		{

		}

		private void button_fileShop_Click(object sender, EventArgs e)
		{
			// Create OpenFileDialog 

			OpenFileDialog dlg = new OpenFileDialog();


			// Set filter for file extension and default file extension 
			dlg.DefaultExt = ".wav";
			dlg.Filter = "WAV Files (*.wav)|*.wav";


			// Display OpenFileDialog by calling ShowDialog method 
			var result = dlg.ShowDialog();


			// Get the selected file name and display in a TextBox 
			if (result != null)
			{

				// Open document 
				string filename = dlg.FileName;
				fileShop.Text = filename;
				//textBox1.Text = filename;
				_settings.ShopBaf_file = filename;
			}
		}

		private void button_fileBaf20_Click(object sender, EventArgs e)
		{
			// Create OpenFileDialog 

			OpenFileDialog dlg = new OpenFileDialog();


			// Set filter for file extension and default file extension 
			dlg.DefaultExt = ".wav";
			dlg.Filter = "WAV Files (*.wav)|*.wav";


			// Display OpenFileDialog by calling ShowDialog method 
			var result = dlg.ShowDialog();


			// Get the selected file name and display in a TextBox 
			if (result != null)
			{

				// Open document 
				string filename = dlg.FileName;
				filebaf20.Text = filename;
				//textBox1.Text = filename;
				_settings.Baf20_file = filename;
			}
		}

		private void button_fileBaf30_Click(object sender, EventArgs e)
		{
			// Create OpenFileDialog 

			OpenFileDialog dlg = new OpenFileDialog();


			// Set filter for file extension and default file extension 
			dlg.DefaultExt = ".wav";
			dlg.Filter = "WAV Files (*.wav)|*.wav";


			// Display OpenFileDialog by calling ShowDialog method 
			var result = dlg.ShowDialog();


			// Get the selected file name and display in a TextBox 
			if (result != null)
			{

				// Open document 
				string filename = dlg.FileName;
				filebaf30.Text = filename;
				//textBox1.Text = filename;
				_settings.Baf30_file = filename;
			}
		}

		private void button_fileBaf60_Click(object sender, EventArgs e)
		{
			// Create OpenFileDialog 

			OpenFileDialog dlg = new OpenFileDialog();


			// Set filter for file extension and default file extension 
			dlg.DefaultExt = ".wav";
			dlg.Filter = "WAV Files (*.wav)|*.wav";


			// Display OpenFileDialog by calling ShowDialog method 
			var result = dlg.ShowDialog();


			// Get the selected file name and display in a TextBox 
			if (result != null)
			{

				// Open document 
				string filename = dlg.FileName;
				filebaf60.Text = filename;
				//textBox1.Text = filename;
				_settings.Baf60_file = filename;
			}
		}

		private void button8_Click(object sender, EventArgs e) //baf 5 file
		{
			OpenFileDialog dlg = new OpenFileDialog();


			// Set filter for file extension and default file extension 
			dlg.DefaultExt = ".wav";
			dlg.Filter = "WAV Files (*.wav)|*.wav";


			// Display OpenFileDialog by calling ShowDialog method 
			var result = dlg.ShowDialog();


			// Get the selected file name and display in a TextBox 
			if (result != null)
			{

				// Open document 
				string filename = dlg.FileName;
				baf5file_label.Text = filename;
				//textBox1.Text = filename;
				_settings.Baf5_file = filename;
			}
		}

		private void Baf5buttonOnOff_Click(object sender, EventArgs e)
		{
			switch (Baf5buttonOnOff.Text)
			{
				case "Включено":
					Baf5buttonOnOff.Text = "Выключено";
					_settings.Baf5 = false;
					break;
				case "Выключено":
					_settings.Baf5 = true;
					Baf5buttonOnOff.Text = "Включено";
					break;
				default: break;
			}
		}
	}
}
